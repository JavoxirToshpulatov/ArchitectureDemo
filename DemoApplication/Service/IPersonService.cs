using Demo.Application.Models;
using Demo.Core.Entities;
using DemoApplication.Models;

namespace DemoApplication.Service
{
    public interface IPersonService
    {
        Task<CreatePersonResponseModel> CreateAsync(CreatePersonModel person);

        Task<BasePersonModel> DeleteAsync(int id);

        Task<IEnumerable<Person>> GetAllAsync();
        Task<PersonResponseModel> GetById(int id);

        Task<UpdatePersonResponseModel> UpdateAsync(int id, UpdatePersonModel updatePersonModel);

    }
}
