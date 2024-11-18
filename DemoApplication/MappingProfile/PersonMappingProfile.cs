﻿using AutoMapper;
using Demo.Application.Models;
using Demo.Core.Entities;
using DemoApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication.MappingProfile
{
    public class PersonMappingProfile : Profile
    {
        public PersonMappingProfile()
        {
            CreateMap<CreatePersonModel, Person>().ReverseMap();
            CreateMap<UpdatePersonModel, Person>().ReverseMap();
            CreateMap<Person, PersonResponseModel>().ReverseMap();
        }
    }
}