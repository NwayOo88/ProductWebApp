﻿using System.ComponentModel.DataAnnotations;

namespace ProductWebApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than 0")]
        public decimal Price { get; set; }
        public string? Description { get; set; } 
        public DateTime CreatedDate { get; set; }
    }
}
