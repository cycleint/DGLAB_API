using AutoMapper;
using DgLab.Application.Tecnica.Dto;
using DgLab.Application.Unidad.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Tecnica
{
    public class TecnicaProfile: Profile
    {
        public TecnicaProfile()
        {
            CreateMap<DgLab.Domain.Entities.Tecnica, TecnicaDto>().ReverseMap();
        }
    }
}
