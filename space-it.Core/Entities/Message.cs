using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_it.Core.Entities
{
    public class Message : Entity
    {
        public virtual string Text { get; set; }

        public virtual Project Project { get; set; }

        public virtual User User { get; set; }
    }
}
