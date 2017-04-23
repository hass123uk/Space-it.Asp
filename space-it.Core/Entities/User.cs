using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_it.Core.Entities
{
    public class User : Entity
    {
        public virtual string Email { get; set; }
        public virtual string Salt { get; set; }
        public virtual string Password { get; set; }
        public virtual IList<Project> Projects { get; set; }
        public virtual IList<Message> Messages { get; set; }
    }
}