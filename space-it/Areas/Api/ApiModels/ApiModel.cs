using System;
using Newtonsoft.Json;
using Space_it.Core.Entities;

namespace Space_it.Web.Areas.Api.ApiModels
{
    public abstract class ApiModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("modified")]
        public DateTime Modified { get; set; }
        [JsonProperty("created")]
        public DateTime Created { get; set; }

        protected ApiModel(Entity model)
        {
            Id = model.Id;
            Modified = model.Modified;
            Created = model.Created;
        } 
    }
}