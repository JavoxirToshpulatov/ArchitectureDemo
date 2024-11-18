using Demo.Core.Entities;

namespace Demo.Application.Models.RoomModels
{
    public class RoomForCreation
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Stage {  get; set; }
    }
    public class RoomForCreationResponse : BaseEntity { }
}
