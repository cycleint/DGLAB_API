using AutoMapper;
using DgLab.Application.Requisito.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Requisito
{
    public class RequisitoProfile : Profile
    {
        public RequisitoProfile()
        {
            CreateMap<DgLab.Domain.Entities.Requisito, RequisitoDto>().ReverseMap();
        }
    }
}
