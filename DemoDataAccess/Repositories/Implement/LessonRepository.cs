using Demo.Core.Entities;
using DemoDataAccess;

namespace Demo.DataAccess.Repositories.Implement
{
    public class LessonRepository : BaseRepository<Lesson>, ILessonRepository
    {
        public LessonRepository(DatabaseContext databaseContext) : base(databaseContext) { }
    }
}
