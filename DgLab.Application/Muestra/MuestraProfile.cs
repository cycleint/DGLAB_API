using AutoMapper;
using DgLab.Application.Muestra.Dto;
using DgLab.Application.Recipiente.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Muestra
{
    public class MuestraProfile : Profile
    {
        public MuestraProfile()
        {
            CreateMap<DgLab.Domain.Entities.Muestra, MuestraDto>().ReverseMap();
        }
    }
}
