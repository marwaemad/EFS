﻿using Articles.Core.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Articles.Core.Validators
{
    public class ArticleAddDtoValidator: AbstractValidator<ArticleAddDto>
    {
        public ArticleAddDtoValidator()
        {
            RuleFor(a => a.Name).NotEmpty();
            RuleFor(a => a.Description).NotEmpty();
            RuleFor(a => a.CategoryId).NotEmpty();
            RuleFor(a => a.ProfilePicture).NotEmpty();

        }
    }
}