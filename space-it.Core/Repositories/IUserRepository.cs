using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Space_it.Core.Entities;

namespace Space_it.Core.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        User GetByEmail(string email);
    }
}
