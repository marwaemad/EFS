﻿using Authentication.Interfaces;
using Authentication.Models;
using Shared.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IdentityModel.Tokens.Jwt;
using Mapster;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using Microsoft.Extensions.Options;
using Shared.Core.Models;
using Shared.Core.Utilities;
using FluentValidation;

namespace Authentication.Services
{
    public class UserService : IUserService
    {
        protected IUnitOfWork _unitOfWork;
        private readonly AuthenticationSettings _settings;
        private readonly IValidator<RegisterDto> _validator;
        public UserService(IUnitOfWork unitOfWork, IOptions<AuthenticationSettings> settings, IValidator<RegisterDto>validator)
        {
            _unitOfWork = unitOfWork;
            _settings = settings.Value;
            _validator = validator;
        }
        public User Authenticate(string username, string password)
        {
            var userEntity = _unitOfWork.UsersRepository.Get(usr => usr.UserName == username && usr.PasswordHash == password,null, "AspNetUserRoles").SingleOrDefault();
            if (userEntity == null)
            {
                return null;
            }
            var userRoles = new List<string>();
            if (userEntity.AspNetUserRoles != null && userEntity.AspNetUserRoles.Count > 0)
            {
                userRoles = GetUserRoles(userEntity.AspNetUserRoles.Select(x => x.RoleId).ToList());
            }
            var userClaims = setUserClaims(userEntity.Id.ToString(), userRoles);
            var user = userEntity.Adapt<User>();
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_settings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(userClaims),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            user.Token = tokenHandler.WriteToken(token);
            user.Password = null;
            return user;
        }

        private Claim[] setUserClaims(string userId, List<string> userRoles)
        {
            var claims = new List<Claim>();
            foreach(var role in userRoles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }
            claims.Add(new Claim(ClaimTypes.Name, userId));
            return claims.ToArray();
        }

        private List<string> GetUserRoles (List<string> rolesIds)
        {
            var userRoles = new List<string>();
            foreach (var roleId in rolesIds)
            {
                userRoles.Add(_unitOfWork.RolesRepository.GetById(roleId).Name);
            }
            return userRoles;
        }

        public IEnumerable<User> GetAll()
        {
            var users = _unitOfWork.UsersRepository.Get().ToList();
            return users.Adapt<List<User>>();
        }

        public bool AddRoleToUser(AddRoleToUserDto data)
        {
            var userEntity = _unitOfWork.UsersRepository.Get(u => u.UserName == data.Username).FirstOrDefault();
            if (userEntity == null)
            {
                return false;
            }
            var roleEntity = _unitOfWork.RolesRepository.Get(r => r.Name == data.RoleName).FirstOrDefault();
            if (userEntity == null)
            {
                return false;
            }
            try
            {
                _unitOfWork.UsersRolesRepository.Insert(new AspNetUserRoles { RoleId = roleEntity.Id, UserId = userEntity.Id });
                _unitOfWork.Commit();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public bool AddRole(RoleDto data)
        {
            try
            {
                var roleEntity = data.Adapt<AspNetRoles>();
                roleEntity.Id = Guid.NewGuid().ToString();
                _unitOfWork.RolesRepository.Insert(roleEntity);
                _unitOfWork.Commit();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public bool DeleteRole(string roleName)
        {
            try
            {
                var roleEntity = _unitOfWork.RolesRepository.Get(r => r.Name == roleName).FirstOrDefault();
                if (roleEntity == null)
                {
                    return false;
                }
                var usersInRole = _unitOfWork.UsersRolesRepository.Get(x => x.RoleId == roleEntity.Id);
                foreach(var userRole in usersInRole)
                {
                    _unitOfWork.UsersRolesRepository.Delete(userRole);
                }
                _unitOfWork.RolesRepository.Delete(roleEntity);
                _unitOfWork.Commit();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
        public ResultMessage Register(RegisterDto userData)
        {
            var validatationResult = _validator.Validate(userData);
            if (!validatationResult.IsValid)
            {
                var message = "";
                if (validatationResult.Errors.Count > 0)
                {
                    message = validatationResult.Errors.Select(e => e.ErrorMessage).Aggregate((i, j) => i + '\n' + j);
                }
                return new ResultMessage { Status = (int)ResultStatus.InvalidData, Message = message };
            }
            try
            {
                var userEntity = userData.Adapt<AspNetUsers>();
                userEntity.Id = Guid.NewGuid().ToString();
                userEntity.UserName = userEntity.Email;
                _unitOfWork.UsersRepository.Insert(userEntity);
                _unitOfWork.Commit();
                switch (userData.Type)
                {
                    case Enums.UserEnum.Clinet:
                        _unitOfWork.ClientsRepository.Insert(new Clients { Id = userEntity.Id });
                        _unitOfWork.Commit();
                        break;
                    case Enums.UserEnum.ProductOwner:
                        _unitOfWork.ProductOwnersRepository.Insert(new ProductsOwners { Id = userEntity.Id });
                        _unitOfWork.Commit();
                        break;
                    case Enums.UserEnum.Trainer:
                        _unitOfWork.TrainersRepository.Insert(new Trainers { Id = userEntity.Id });
                        _unitOfWork.Commit();
                        break;
                }
                return new ResultMessage { Status = (int)ResultStatus.Success };
            }
            catch (Exception ex)
            {

                return new ResultMessage { Status = (int)ResultStatus.Error};
            }


        }
    }
}
