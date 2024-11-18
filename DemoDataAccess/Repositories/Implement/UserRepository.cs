using Demo.Core.Entities;
using DemoDataAccess;

namespace Demo.DataAccess.Repositories.Implement
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(DatabaseContext databaseContext) : base(databaseContext) { }
    }
}
