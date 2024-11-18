using Demo.Core.Entities;
using System.Linq.Expressions;

namespace DemoDataAccess.Repositories
{
    public interface IPersonRepository
    {
        public Task<Person> CreateAsync(Person person);
        public Task<Person> UpdateAsync(Person person);
        public Task<Person> DeleteAsync(Person  person);
        public Task<Person> GetByIdAsync(int id);
        public Task<List<Person>> GetAllAsync();
        public Task<Person> GetFirstAsync(Expression<Func<Person, bool>> predicate);
    }
}
