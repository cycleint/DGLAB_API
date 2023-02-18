using AutoMapper;
using DgLab.Application.Unidad.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Unidad
{
    internal class UnidadProfile : Profile
    {
        public UnidadProfile()
        {
            CreateMap<DgLab.Domain.Entities.Unidad, UnidadDto>().ReverseMap();
        }
    }
}
