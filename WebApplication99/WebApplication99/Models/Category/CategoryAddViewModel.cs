﻿using System.ComponentModel.DataAnnotations;

namespace WebApplication99.Models.Category
{
    public class CategoryAddViewModel
    {
        [Required(ErrorMessage = "Вкажіть назву категорії")]
        public string Name { get; set; }
        public string Description { get; set; }
        public IFormFile Image { get; set; }
    }
}
