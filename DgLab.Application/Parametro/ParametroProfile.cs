using AutoMapper;
using DgLab.Application.Parametro.Dto;
using DgLab.Application.Rol.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Parametro
{
    internal class ParametroProfile : Profile
    {
        public ParametroProfile()
        {
            CreateMap<DgLab.Domain.Entities.Parametro, ParametroDto>().ReverseMap();
        }
    }
}
