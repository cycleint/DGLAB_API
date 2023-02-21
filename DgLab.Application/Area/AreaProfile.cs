using AutoMapper;
using DgLab.Application.Area.Dto;
using DgLab.Application.Requisito.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Area
{
    public class AreaProfile : Profile
    {
        public AreaProfile()
        {
            CreateMap<DgLab.Domain.Entities.Area, AreaDto>().ReverseMap();
        }
    }
}
