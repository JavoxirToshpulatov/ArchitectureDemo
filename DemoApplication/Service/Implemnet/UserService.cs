using AutoMapper;
using Demo.Application.Models.UserModels;
using Demo.Core.Entities;
using Demo.DataAccess.Repositories;

namespace Demo.Application.Service.Implemnet
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
        }

        public async Task<User> GetUser(string username)
        {
            var user = await userRepository.GetFirstAsync(u => u.Username == username);
            return user;
        }

        public async Task<CreateUserResponseModel> RegisterUser(CreateUserModel userDto)
        {
            var user = mapper.Map<User>(userDto);


            return new CreateUserResponseModel
            {
                Id = (await userRepository.AddAsync(user)).Id
            };
        }
    }
}
