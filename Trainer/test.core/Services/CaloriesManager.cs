﻿using Mapster;
using Microsoft.AspNetCore.JsonPatch;
using Shared.Core;
using Shared.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using test.core.Interfaces;
using test.core.Model;

namespace test.core.Services
{
    public class CaloriesManager: ICaloriesManager
    {
        protected IUnitOfWork _unitOfWork;
        public CaloriesManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IEnumerable<CaloriesDto> GetAll()
        {
            IEnumerable<CaloriesDto> result = new List<CaloriesDto>();
            result =  _unitOfWork.TestRepository.Get().Adapt(result);
            return result;
        }

        public bool Insert(CaloriesDto calory)
        {
            try {

                _unitOfWork.TestRepository.Insert(calory.Adapt<Calories>());
                _unitOfWork.Commit();
                return true;
            }
            catch(Exception error)
            {
                return false;
            }
        }

        public CaloriesDto GetById(short id)
        {
            try
            {
                var calory = _unitOfWork.TestRepository.GetById(id);
                _unitOfWork.Commit();
                return calory.Adapt<CaloriesDto>();
            }
            catch (Exception error)
            {
                return null;
            }
        }

        public bool Update(CaloriesDto calory, short id)
        {
            try
            {
                var oldCalory = _unitOfWork.TestRepository.GetById(id);
                if (oldCalory != null)
                {
                    oldCalory.Description = calory.Description;
                    oldCalory.Name = calory.Name;
                    oldCalory.Value = calory.Value;
                    _unitOfWork.TestRepository.Update(oldCalory);
                    _unitOfWork.Commit();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception error)
            {
                return false;
            }
        }

        public bool Delete(short id)
        {
            try
            {

                _unitOfWork.TestRepository.Delete(id);
                _unitOfWork.Commit();
                return true;
            }
            catch (Exception error)
            {
                return false;
            }
        }

        public bool Patch(short id, JsonPatchDocument<CaloriesDto> caloryPatch)
        {
            try
            {
                var calory = _unitOfWork.TestRepository.GetById(id);
         
                if (calory != null)
                {
                    var caloryDto = calory.Adapt<CaloriesDto>();
                    caloryPatch.ApplyTo(caloryDto);
                    calory = caloryDto.Adapt(calory);
                    _unitOfWork.TestRepository.Update(calory);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

                return false;
            }  
        }
    }
}
