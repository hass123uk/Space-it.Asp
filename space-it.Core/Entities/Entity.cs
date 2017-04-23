using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_it.Core.Entities
{
    public abstract class Entity
    {
        public virtual long Id { get; set; }

        public virtual DateTime Modified { get; set; }

        public virtual DateTime Created { get; set; }

        public virtual bool Deleted { get; set; }
    }
}