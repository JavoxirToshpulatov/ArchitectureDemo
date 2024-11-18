using Demo.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DemoDataAccess.Repositories.Implement
{
    public class PersonRepository : IPersonRepository
    {
        private readonly DatabaseContext _databaseContext;
        public PersonRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<Person> CreateAsync(Person person)
        {
            await _databaseContext.AddAsync(person);
            _databaseContext.SaveChanges();
            return person;
        }

        public async Task<Person> DeleteAsync(Person person)
        {
            var deletePerson =  _databaseContext.People.FirstOrDefault(person => person.Id == person.Id);
            _databaseContext.People.Remove(deletePerson);
            _databaseContext.SaveChanges();
            return deletePerson;
        }

        public async Task<List<Person>> GetAllAsync()
        {
            var person = _databaseContext.People.AsQueryable().ToList();
            _databaseContext.SaveChanges();
            return person;
        }

        public async Task<Person> GetByIdAsync(int id)
        {
            var person = _databaseContext.People.FirstOrDefault(p => p.Id == id);
            _databaseContext.SaveChanges();
            return person;
        }

        public async Task<Person> UpdateAsync(Person person)
        {
             _databaseContext.People.Update(person);
            _databaseContext.SaveChanges();
            return person;
        }

        public async Task<Person> GetFirstAsync(Expression<Func<Person, bool>> predicate)
        {
            var entity = await _databaseContext.People.Where(predicate).FirstOrDefaultAsync();

            if (entity == null) throw new Exception("Bunaqa model yo'q");

            return await _databaseContext.People.Where(predicate).FirstOrDefaultAsync();
        }
    }
}
