﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Products.Core.Models
{
    public class ProductsDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? ExpDate { get; set; }
        public DateTime? ProdDate { get; set; }
        public decimal Price { get; set; }
        public string OwnerId { get; set; }
        public string ProfilePicture { get; set; }
        public int SubcategoryId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }
    }
}