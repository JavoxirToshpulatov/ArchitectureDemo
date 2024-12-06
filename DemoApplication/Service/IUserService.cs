using Demo.Application.Models.UserModels;
using Demo.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Application.Service
{
    public interface IUserService
    {
        Task<CreateUserResponseModel> RegisterUser(CreateUserModel userDto);
        //Task<UserResponseModel> GetUsers();
        Task<User> GetUser(string username);
    }
}
