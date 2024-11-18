using AutoMapper;
using Demo.Application.Models.ExamModels;
using Demo.Core.Entities;

namespace Demo.Application.MappingProfile
{
    public class ExamMappingProfile : Profile
    {
        public ExamMappingProfile()
        {
            CreateMap<UpdateExamModel, Exam>().ReverseMap();
            CreateMap<CreateExamModel, Exam>().ReverseMap();
        }
    }
}
