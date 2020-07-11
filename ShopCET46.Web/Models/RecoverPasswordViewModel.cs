﻿using System.ComponentModel.DataAnnotations;

namespace ShopCET46.Web.Models
{
    public class RecoverPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
