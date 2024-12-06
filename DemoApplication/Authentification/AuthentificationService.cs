using Demo.Application.Service;
using Demo.Core.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Application.Authentification
{
    public class AuthentificationService : IAuthentificationService
    {
        private readonly IUserService _userService;

        public AuthentificationService(IUserService userService)
        {
            _userService = userService;
        }

        public async LoginResultDto LoginAsync(string username, string password)
        {
            var user = await _userService.GetUser(username);

            if(user == null)
            {
                throw new Exception("User not found");
            }

            if (PasswordHasher.GenerateHash(password, user.PasswordSalt) != user.PasswordHash)
            {
                throw new Exception("Password is incorrect");
            }
            //if(user.PasswordHash)

        }
    }
}
