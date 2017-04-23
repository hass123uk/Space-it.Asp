using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Space_it.Core.Entities;
using Space_it.Core.Repositories;

namespace Space_it.Core.Services.Impl
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepository;

        public AuthService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User GetByEmail(string email)
        {
            return _userRepository.GetByEmail(email);
        }

        public bool Validate(string email, string password)
        {
            var user = _userRepository.GetByEmail(email);
            if (user == null)
            {
                return false;
            }

            return ToHashString($"{user.Salt}{password}") == user.Password;
        }
        
        public User RegisterUser(string email, string password)
        {
            var user = _userRepository.GetByEmail(email);
            if (user != null) return null;


            var salt = Guid.NewGuid().ToString();
            var hashedPassword = ToHashString($"{salt}{password}");
            var security = new Tuple<string, string>(salt, hashedPassword);

            user = new User
            {
                Email = email,
                Password = security.Item1,
                Salt = security.Item1,
                Created = DateTime.UtcNow
            };

            _userRepository.SaveOrUpdate(user);

            return user;
        }

        public string ToHashString(string source)
        {
            var builder = new StringBuilder();
            foreach (var b in GetHash(source))
                builder.Append(b.ToString("X2"));

            return builder.ToString();
        }

        private static byte[] GetHash(string source)
        {
            var algorithm = MD5.Create();
            return algorithm.ComputeHash(Encoding.UTF8.GetBytes(source));
        }
    }
}
