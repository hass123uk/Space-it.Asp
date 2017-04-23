using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Space_it.Core.Entities;

namespace Space_it.Core.NHibernate_Data.Mappings
{
    public class UserMap : BaseMap<User>
    {
        public UserMap()
        {
            Map(x => x.Email)
                .Unique();
            Map(x => x.Salt);
            Map(x => x.Password);
            HasMany(x => x.Messages)
                .Cascade.AllDeleteOrphan();
            HasManyToMany(x => x.Projects)
                .Cascade.All()
                .Table("Users_Projects");
        }
    }
}