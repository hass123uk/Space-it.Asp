using Newtonsoft.Json;
using Space_it.Core.Entities;

namespace Space_it.Web.Areas.Api.ApiModels
{
    public class ApiProjectModel : ApiModel
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        public ApiProjectModel(Project model) : base(model)
        {
            Name = model.Name;
        }
    }
}