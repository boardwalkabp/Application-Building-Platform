﻿using System.ComponentModel.DataAnnotations;

namespace ApplicationBuildingPlatformAPI.Models.DTO
{
    public class ChangePassword
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string CurrentPassword { get; set; }
        [Required]
        public string NewPassword { get; set; }
        [Required]
        [Compare("NewPassword")]
        public string ConfirmNewPassword { get; set; }

    }
}
