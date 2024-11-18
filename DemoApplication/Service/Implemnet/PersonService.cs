using AutoMapper;
using Demo.Application.Models;
using Demo.Application.Models.PersonModels;
using Demo.Application.Models.RoomModels;
using Demo.Core.Entities;
using DemoDataAccess.Repositories;

namespace DemoApplication.Service.Implemnet
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;
        private readonly IMapper _mapper;
        public PersonService(IPersonRepository personRepository, IMapper mapper)
        {
            _personRepository = personRepository;
            _mapper = mapper;
        }

        public async Task<CreatePersonResponseModel> CreateAsync(CreatePersonModel createPersonModel)
        {
            var person = _mapper.Map<Person>(createPersonModel);

            return new CreatePersonResponseModel
            {
                Id = (await _personRepository.CreateAsync(person)).Id
            };
        }

        //public async Task<BasePersonModel> DeleteAsync(int id)
        //{
        //    var person = await _personRepository.GetFirstAsync(p => p.Id == id);

        //    return new BasePersonModel
        //    {
        //        Id = (await _personRepository.DeleteAsync(person)).Id
        //    };
        //}

        public async Task<IEnumerable<Person>> GetAllAsync()
        {
            return await _personRepository.GetAllAsync();
        }

        public async Task<PersonResponseModel> GetById(int id)
        {
            var person = await _personRepository.GetByIdAsync(id);
            var personModel = _mapper.Map<PersonResponseModel>(person);

            return personModel;
        }

        public async Task<UpdatePersonResponseModel> UpdateAsync(int id, UpdatePersonModel updatePersonModel)
        {
            var person = await _personRepository.GetFirstAsync(p => p.Id == id);

            return new UpdatePersonResponseModel
            {
                Id = (await _personRepository.UpdateAsync(person)).Id
            };
        }

       public async Task<BaseResponseModel> DeleteAsync(int id)
        {
            var person = await _personRepository.GetFirstAsync(p => p.Id == id);

            return new BaseResponseModel
            {
                Id = (await _personRepository.DeleteAsync(person)).Id
            };
        }
    }
}
