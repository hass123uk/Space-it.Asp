using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_it.Core.Entities
{
    public abstract class BaseModel
    {
        public long Id { get; set; }

        public DateTime Modified { get; set; }

        public DateTime Created { get; set; }
    }
}
