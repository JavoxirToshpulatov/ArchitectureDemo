using Demo.Core.Entities;
using DemoDataAccess;

namespace Demo.DataAccess.Repositories.Implement
{
    public class RoomRepository : BaseRepository<Room>, IRoomRepository
    {
        public RoomRepository(DatabaseContext databaseContext) : base(databaseContext) { }
    }
}
