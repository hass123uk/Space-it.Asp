using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Space_it.Core.Entities;

namespace Space_it.Core.Repositories.Impl
{
    public class NhUserRepo : NhBaseRepository<User>, IUserRepository
    {
        public User GetByEmail(string email)
        {
            return Query().FirstOrDefault(u =>  u.Email.Equals(email));
        }
    }
}
