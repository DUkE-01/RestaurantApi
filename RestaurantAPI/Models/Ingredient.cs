﻿using System.ComponentModel.DataAnnotations;

namespace RestaurantAPI.Models
{
    public class Ingredient
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
