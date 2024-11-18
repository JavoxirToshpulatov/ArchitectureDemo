using Demo.Application.Models.PersonModels;
using DemoApplication.Service;
using Microsoft.AspNetCore.Mvc;

namespace DemoVersion.Controllers
{
    [Controller]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;
        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateAsync(CreatePersonModel createPersonModel)
        {
            return Ok(await _personService.CreateAsync(createPersonModel));
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            return Ok(await _personService.DeleteAsync(id));
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await _personService.GetAllAsync());
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            return Ok(await _personService.GetById(id));
        }

        [HttpPut("update")]
        public async Task<IActionResult> UpdateAsync(int id, UpdatePersonModel updatePersonModel)
        {
            return Ok(await _personService.UpdateAsync(id, updatePersonModel));
        }

    }
}
