using System;
using Space_it.Core.Entities;

namespace Space_it.Web.Areas.Api.ApiModels
{
    public abstract class ApiModel
    {
        public long Id { get; set; }

        public DateTime Modified { get; set; }

        public DateTime Created { get; set; }

        protected ApiModel(BaseModel model)
        {
            Id = model.Id;
            Modified = model.Modified;
            Created = model.Created;
        } 
    }
}