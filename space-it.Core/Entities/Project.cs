
using System.Collections.Generic;

namespace Space_it.Core.Entities
{
    public class Project : Entity
    {
        public virtual string Name { get; set; }

        public virtual IList<Message> Messages { get; set; }

        public virtual IList<User> Users { get; set; }
    }
}
