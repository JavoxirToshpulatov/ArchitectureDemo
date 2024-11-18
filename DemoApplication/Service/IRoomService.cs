using Demo.Application.Models;
using Demo.Application.Models.PersonModels;
using Demo.Application.Models.RoomModels;
using Demo.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Application.Service
{
    public interface IRoomService
    {
        Task<RoomForCreationResponse> CreateAsync(RoomForCreation roomForCreation);

        Task<BaseResponseModel> DeleteAsync(int id);

        Task<IEnumerable<Room>> GetAllAsync();
        Task<RoomResponseModel> GetById(int id);

        Task<UpdateRoomResponseModel> UpdateAsync(int id, UpdateRoomModel updatePersonModel);
    }
}
