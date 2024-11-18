using AutoMapper;
using Demo.Application.Models.RoomModels;
using Demo.Core.Entities;

namespace Demo.Application.MappingProfile
{
    public class RoomMappingProfile : Profile
    {
        public RoomMappingProfile()
        {
            CreateMap<RoomForCreation, Room>().ReverseMap();
            CreateMap<UpdateRoomModel, Room>().ReverseMap();
        }
    }
}
