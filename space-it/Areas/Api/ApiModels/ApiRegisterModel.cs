using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Space_it.Web.Areas.Api.ApiModels
{
    public class ApiRegisterModel
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public bool RememberMe { get; set; }

        public ApiUserModel User { get; set; }
    }
}