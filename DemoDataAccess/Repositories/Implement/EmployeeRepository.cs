using Demo.Core.Entities;
using DemoDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DataAccess.Repositories.Implement
{
    public class EmployeeRepository: BaseRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(DatabaseContext databaseContext) : base(databaseContext) { }
    }
}
