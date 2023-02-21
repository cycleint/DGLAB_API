using AutoMapper;
using DgLab.Application.Alarma.Dto;
using DgLab.Application.Area.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Alarma
{
    public class AlarmaProfile : Profile
    {
        public AlarmaProfile()
        {
            CreateMap<DgLab.Domain.Entities.Alarma, AlarmaDto>().ReverseMap();
        }
    }
}
