using Demo.Application.Models.PersonModels;
using Demo.Application.Models;
using Demo.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Application.Models.EmployeeModels;

namespace Demo.Application.Service
{
    public interface IEmployeeService
    {
        Task<EmployeeForCreateResponseModel> CreateAsync(EmployeeForCreate employeeForCreate);

        Task<BaseResponseModel> DeleteAsync(int id);

        Task<IEnumerable<Employee>> GetAllAsync();
        Task<Employee> GetById(int id);

        Task<UpdateEmployeeResponseModel> UpdateAsync(int id, UpdateEmployeeModel updateEmployeeModel);
    }
}
