using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Application.Authentification
{
    public interface IAuthentificationService
    {
        LoginResultDto LoginAsync(string username, string password);
    }
}
