using DgLab.Application.Person.Queries;
using AutoMapper;

namespace DgLab.Application.Person
{

    public class PersonProfile : Profile
    {
        public PersonProfile()
        {
            CreateMap<DgLab.Domain.Entities.Person, PersonDto>().ReverseMap();
        }
    }
}