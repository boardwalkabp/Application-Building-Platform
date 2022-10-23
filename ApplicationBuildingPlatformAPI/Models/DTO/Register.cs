﻿using System.ComponentModel.DataAnnotations;

namespace ApplicationBuildingPlatformAPI.Models.DTO
{
    public class Register
    {
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Username { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }
    }
}
