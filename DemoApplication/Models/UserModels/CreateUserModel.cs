using Demo.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Application.Models.UserModels
{
    public class CreateUserModel
    {
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string MobilePhone { get; set; } = null!; 
    }
    public class CreateUserResponseModel : BaseEntity { }
}
