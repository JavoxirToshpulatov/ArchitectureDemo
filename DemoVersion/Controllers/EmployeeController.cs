using Demo.Application.Models.EmployeeModels;
using Demo.Application.Models.PersonModels;
using Demo.Application.Service;
using Demo.DataAccess.Repositories;
using DemoApplication.Service;
using Microsoft.AspNetCore.Mvc;

namespace DemoVersion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService  _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateAsync(EmployeeForCreate employeeForCreate )
        {
            return Ok(await _employeeService.CreateAsync(employeeForCreate));
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            return Ok(await _employeeService.DeleteAsync(id));
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await _employeeService.GetAllAsync());
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            return Ok(await _employeeService.GetById(id));
        }

        [HttpPut("update")]
        public async Task<IActionResult> UpdateAsync(int id, UpdateEmployeeModel updatePersonModel)
        {
            return Ok(await _employeeService.UpdateAsync(id, updatePersonModel));
        }
    }
}
