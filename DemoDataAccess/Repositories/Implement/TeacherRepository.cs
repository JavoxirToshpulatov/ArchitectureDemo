using Demo.Core.Entities;
using DemoDataAccess;

namespace Demo.DataAccess.Repositories.Implement
{
    public class TeacherRepository : BaseRepository<Teacher>, ITeacherRepository
    {
        public TeacherRepository(DatabaseContext databaseContext) : base(databaseContext) { }
    }
}
