using Demo.Application.Models.ExamModels;
using Demo.Application.Service;
using Microsoft.AspNetCore.Mvc;

namespace DemoVersion.Controllers
{
    [Controller]
    [Route("api/[controller]")]
    public class ExamController : ControllerBase
    {
        private readonly IExamService _examService;

        public ExamController(IExamService examService)
        {
            _examService = examService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateAsync(CreateExamModel roomForCreation)
        {
            return Ok(await _examService.CreateAsync(roomForCreation));
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _examService.GetAllAsync());
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(_examService.GetById(id));
        }

        [HttpPost("Update")]
        public async Task<IActionResult> UpdateAsync(int id, UpdateExamModel updateRoomModel)
        {
            return Ok(await _examService.UpdateAsync(id, updateRoomModel));
        }
    }
}
