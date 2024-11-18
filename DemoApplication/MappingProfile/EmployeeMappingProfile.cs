using AutoMapper;
using Demo.Application.Models.EmployeeModels;
using Demo.Core.Entities;

namespace Demo.Application.MappingProfile
{
    public class EmployeeMappingProfile : Profile
    {
        public EmployeeMappingProfile()
        {
            CreateMap<EmployeeForCreate, Employee>()
                .ForPath(o => o.Person.Age, e => e.MapFrom(d => d.Age))
                .ForPath(o => o.Person.Status, e => e.MapFrom(d => d.Status))
                .ForPath(o => o.Person.Name, e => e.MapFrom(d => d.Name));
            CreateMap<UpdateEmployeeModel, Employee>()
                .ForPath(o => o.Person.Age, e => e.MapFrom(d => d.Age))
                .ForPath(o => o.Person.Status, e => e.MapFrom(d => d.Status))
                .ForPath(o => o.Person.Name, e => e.MapFrom(d => d.Name));

        }
    }
}
