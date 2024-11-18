using Demo.Core.Entities;

namespace Demo.Application.Models.RoomModels
{
    public class UpdateRoomModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Stage { get; set; }
    }

    public class UpdateRoomResponseModel : BaseEntity { }
}
