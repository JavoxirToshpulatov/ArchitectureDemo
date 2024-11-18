using Demo.Application.Models.RoomModels;
using Demo.Application.Service;
using Microsoft.AspNetCore.Mvc;

namespace DemoVersion.Controllers
{
    [Controller]
    [Route("api/[controller]")]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;

        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateAsync(RoomForCreation roomForCreation)
        {
            return Ok(await _roomService.CreateAsync(roomForCreation));
        }

        [HttpGet("GetAllRooms")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _roomService.GetAllAsync());
        }

        [HttpGet("GetRoomById")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(_roomService.GetById(id));
        }

        [HttpPost("Update")]
        public async Task<IActionResult> UpdateAsync(int id, UpdateRoomModel updateRoomModel)
        {
            return Ok(await _roomService.UpdateAsync(id, updateRoomModel));
        }
    }
}
