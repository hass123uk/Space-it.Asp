using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Space_it.Core.Entities;

namespace Space_it.Core.Services
{
    public interface IAuthService
    {
        User GetByEmail(string email);

        bool Validate(string username, string password);
        User RegisterUser(string username, string password);
    }
}
