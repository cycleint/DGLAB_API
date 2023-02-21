using AutoMapper;
using DgLab.Application.GrupoEtario.Dto;
using DgLab.Application.Requisito.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.GrupoEtario
{
    public class GrupoEtarioProfile : Profile
    {
        public GrupoEtarioProfile()
        {
            CreateMap<DgLab.Domain.Entities.GrupoEtario, GrupoEtarioDto>().ReverseMap();
        }
    }
}
