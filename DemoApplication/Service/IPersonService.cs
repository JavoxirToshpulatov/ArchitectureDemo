using Demo.Application.Models;
using Demo.Application.Models.PersonModels;
using Demo.Application.Models.RoomModels;
using Demo.Core.Entities;

namespace DemoApplication.Service
{
    public interface IPersonService
    {
        Task<CreatePersonResponseModel> CreateAsync(CreatePersonModel person);

        Task<BaseResponseModel> DeleteAsync(int id);

        Task<IEnumerable<Person>> GetAllAsync();
        Task<PersonResponseModel> GetById(int id);

        Task<UpdatePersonResponseModel> UpdateAsync(int id, UpdatePersonModel updateRoomModel);

    }
}
