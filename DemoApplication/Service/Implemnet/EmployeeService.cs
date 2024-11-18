using AutoMapper;
using Demo.Application.Models;
using Demo.Application.Models.EmployeeModels;
using Demo.Core.Entities;
using Demo.DataAccess.Repositories;

namespace Demo.Application.Service.Implemnet
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;

        public EmployeeService(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }

        public async Task<EmployeeForCreateResponseModel> CreateAsync(EmployeeForCreate employeeForCreate)
        {
            var employee = _mapper.Map<Employee>(employeeForCreate);

            return new EmployeeForCreateResponseModel
            {
                Id = (await _employeeRepository.AddAsync(employee)).Id,
            };
        }

        public async Task<BaseResponseModel> DeleteAsync(int id)
        {
            var employee = await _employeeRepository.GetFirstAsync(e => e.Id == id);

            return new BaseResponseModel
            {
                Id = (await _employeeRepository.DeleteAsync(employee)).Id,
            };
        }

        public async Task<IEnumerable<Employee>> GetAllAsync()
        {
            var employees = _employeeRepository.GetAll();

            return employees;
        }

        public async Task<Employee> GetById(int id)
        {
            var employee = await _employeeRepository.GetFirstAsync(e => e.Id == id);

            return employee;
        }

        public async Task<UpdateEmployeeResponseModel> UpdateAsync(int id, UpdateEmployeeModel updateEmployeeModel)
        {
            var employee = await _employeeRepository.GetFirstAsync(e => e.Id == id);

            return new UpdateEmployeeResponseModel
            {
                Id = (await _employeeRepository.UpdateAsync(employee)).Id
            };
        }
    }
}
