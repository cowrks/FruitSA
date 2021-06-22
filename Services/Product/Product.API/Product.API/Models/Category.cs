﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Product.API.Models
{
    public class Category
    {
        [Key]
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public string CategoryCode { get; set; }
        public bool IsActive { get; set; }
    }
}
