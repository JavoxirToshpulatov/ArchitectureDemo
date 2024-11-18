using AutoMapper;
using Demo.Application.Models;
using Demo.Application.Models.PersonModels;
using Demo.Application.Models.RoomModels;
using Demo.Core.Entities;
using Demo.DataAccess.Repositories;

namespace Demo.Application.Service.Implemnet
{
    public class RoomService : IRoomService
    {
        private readonly IRoomRepository _roomRepository;
        private readonly IMapper _mapper;

        public RoomService(IRoomRepository roomRepository, IMapper mapper)
        {
            _roomRepository = roomRepository;
            _mapper = mapper;
        }

        public async Task<RoomForCreationResponse> CreateAsync(RoomForCreation roomForCreation)
        {
            var room = _mapper.Map<Room>(roomForCreation);

            return new RoomForCreationResponse
            {
                Id = (await _roomRepository.AddAsync(room)).Id
            };
        }

        public async Task<BaseResponseModel> DeleteAsync(int id)
        {
            var room = await _roomRepository.GetFirstAsync(r => r.Id == id);

            return new BaseResponseModel
            {
                Id = (await _roomRepository.DeleteAsync(room)).Id
            };
        }

        public async Task<IEnumerable<Room>> GetAllAsync()
        {
            var rooms = _roomRepository.GetAllAsEnumurable();
            return rooms;
        }

        public async Task<RoomResponseModel> GetById(int id)
        {
            var room = await _roomRepository.GetFirstAsync(r => r.Id == id);

            return new RoomResponseModel
            {
                Description = room.Description,
                Name = room.Name,
                Stage = room.Stage
            };
        }

        public async Task<UpdateRoomResponseModel> UpdateAsync(int id, UpdateRoomModel updateRoomModel)
        {
            var room = await _roomRepository.GetFirstAsync(r => r.Id == id);
            _mapper.Map(updateRoomModel,room);

            return new UpdateRoomResponseModel
            {
                Id = (await _roomRepository.UpdateAsync(room)).Id
            };

        }
    }
}
