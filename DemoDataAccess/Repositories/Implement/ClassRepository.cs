using Demo.Core.Entities;
using DemoDataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DataAccess.Repositories.Implement
{
    public class ClassRepository : BaseRepository<Class> , IClassRepository
    {
        public ClassRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
            
        }
    }
}
