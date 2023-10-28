﻿using System.ComponentModel.DataAnnotations;

namespace S11.Common.Dto.Auth
{
    public class LoginPostDto
    {
        [EmailAddress]
        public string UserName { get; set; }
        //politicas del password
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
