using AutoMapper;
using DgLab.Application.Unidad.Dto;
using DgLab.Application.Usuario.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Usuario
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<DgLab.Domain.Entities.Usuario, UsuarioDto>().ReverseMap();
        }
    }
}
