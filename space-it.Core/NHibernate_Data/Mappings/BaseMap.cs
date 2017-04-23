using FluentNHibernate.Mapping;
using Space_it.Core.Entities;

namespace Space_it.Core.NHibernate_Data.Mappings
{
    public abstract class BaseMap<T> : ClassMap<T> where T : Entity
    {
        protected BaseMap()
        {
            Id(x => x.Id)
                 .GeneratedBy.Identity();

            Map(x => x.Created);
            Map(x => x.Modified);
            Map(x => x.Deleted);
        }
    }
}