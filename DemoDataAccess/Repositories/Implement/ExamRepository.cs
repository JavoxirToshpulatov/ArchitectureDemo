using Demo.Core.Entities;
using DemoDataAccess;

namespace Demo.DataAccess.Repositories.Implement
{
    public class ExamRepository : BaseRepository<Exam>, IExamRepository
    {
        public ExamRepository(DatabaseContext databaseContext) : base(databaseContext) { }
    }
}
