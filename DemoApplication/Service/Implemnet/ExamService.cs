using AutoMapper;
using Demo.Application.Models.PersonModels;
using Demo.Application.Models;
using Demo.Core.Entities;
using DemoDataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.DataAccess.Repositories;
using Demo.Application.Models.ExamModels;

namespace Demo.Application.Service.Implemnet
{
    public class ExamService : IExamService
    {
        private readonly IExamRepository _examRepository;
        private readonly IMapper _mapper;
        public ExamService(IExamRepository examRepository, IMapper mapper)
        {
            _examRepository = examRepository;
            _mapper = mapper;
        }

        public async Task<CreateExamResponseModel> CreateAsync(CreateExamModel createPersonModel)
        {
            var exam = _mapper.Map<Exam>(createPersonModel);

            return new CreateExamResponseModel
            {
                Id = (await _examRepository.AddAsync(exam)).Id
            };
        }

        

        public async Task<IEnumerable<Exam>> GetAllAsync()
        {
            return  _examRepository.GetAllAsEnumurable();
        }

        public async Task<Exam> GetById(int id)
        {
            var exam = await _examRepository.GetFirstAsync(e=>e.Id == id);
           
            return exam;
        }

        public async Task<UpdateExamResponseModel> UpdateAsync(int id, UpdateExamModel updatePersonModel)
        {
            var exam = await _examRepository.GetFirstAsync(p => p.Id == id);

            return new UpdateExamResponseModel
            {
                Id = (await _examRepository.UpdateAsync(exam)).Id
            };
        }

        public async Task<BaseResponseModel> DeleteAsync(int id)
        {
            var person = await _examRepository.GetFirstAsync(p => p.Id == id);

            return new BaseResponseModel
            {
                Id = (await _examRepository.DeleteAsync(person)).Id
            };
        }
    }
}
