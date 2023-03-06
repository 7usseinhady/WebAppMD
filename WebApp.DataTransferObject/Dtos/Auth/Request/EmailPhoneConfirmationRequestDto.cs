﻿using System.ComponentModel.DataAnnotations;

namespace WebApp.DataTransferObjects.Dtos.Auth.Request
{
    public class EmailPhoneConfirmationRequestDto
    {
        [Display(Name = "PersonalKey"), Required(ErrorMessage = "Required")]
        public string PersonalKey { get; set; }

        [Display(Name = "TokenCode"), Required(ErrorMessage = "Required"), StringLength(6)]
        public string TokenCode { get; set; }
    }
}
