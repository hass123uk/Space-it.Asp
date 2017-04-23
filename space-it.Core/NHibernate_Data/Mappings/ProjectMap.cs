using Space_it.Core.Entities;

namespace Space_it.Core.NHibernate_Data.Mappings
{
    public class ProjectMap : BaseMap<Project>
    {
        public ProjectMap()
        {
            Map(x => x.Name);
            HasMany(x => x.Messages)
                .Cascade.AllDeleteOrphan();
            HasManyToMany(x => x.Users)
                .Cascade.All()
               .Table("Users_Projects");

        }
    }
}