﻿namespace AspNetCoreMvcSharedLocalization.Models.AccountViewModels
{
    using System.ComponentModel.DataAnnotations;
    
    public class ResetPasswordViewModel
    {
        [Required(ErrorMessage = "emailRequired")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "passwordRequired")]
        [StringLength(100, ErrorMessage = "passwordStringLength", MinimumLength = 8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "confirmPasswordNotMatching")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }
}
