﻿using Attachments.Core.Models;
using Microsoft.AspNetCore.Http;
using Shared.Core.Utilities.Models;
using System.Collections.Generic;

namespace Articles.Core.Models
{
    public class ArticleAddDto : IUserDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public string ProfilePicture { get; set; }
        public List<SliderItemDto> Images { get; set; }
        public List<SliderItemDto> UpdatedImages { get; set; }
        public string UserId { get; set; }
    }
}
