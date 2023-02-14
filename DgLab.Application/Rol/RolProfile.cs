using AutoMapper;
using DgLab.Application.Rol.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Rol
{
    public class RolProfile : Profile
    {
        public RolProfile()
        {
            CreateMap<DgLab.Domain.Entities.Rol, RolDto>().ReverseMap();
        }
    }
}
