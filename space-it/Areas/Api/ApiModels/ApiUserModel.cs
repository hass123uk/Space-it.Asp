using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using Space_it.Core.Entities;

namespace Space_it.Web.Areas.Api.ApiModels
{
    public class ApiUserModel : ApiModel
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        public ApiUserModel(User model) : base(model)
        {
            Email = model.Email;
        }
    }
}