using Demo.Application.Models.EmployeeModels;
using Demo.Application.Models;
using Demo.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Application.Models.ExamModels;

namespace Demo.Application.Service
{
    public interface IExamService
    {
        Task<CreateExamResponseModel> CreateAsync(CreateExamModel createExamModel);

        Task<BaseResponseModel> DeleteAsync(int id);

        Task<IEnumerable<Exam>> GetAllAsync();
        Task<Exam> GetById(int id);

        Task<UpdateExamResponseModel> UpdateAsync(int id, UpdateExamModel updateExamModel);
    }
}
