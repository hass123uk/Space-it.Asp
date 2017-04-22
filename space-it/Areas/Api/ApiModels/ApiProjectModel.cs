using Space_it.Core.Entities;

namespace Space_it.Web.Areas.Api.ApiModels
{
    public class ApiProjectModel : ApiModel
    {
        public string Name { get; set; }

        public ApiProjectModel(ProjectModel model) : base(model)
        {
            Name = model.Name;
        }
    }
}