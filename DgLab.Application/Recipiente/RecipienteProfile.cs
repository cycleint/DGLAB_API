using AutoMapper;
using DgLab.Application.Recipiente.Dto;
using DgLab.Application.Requisito.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Recipiente
{
    public class RecipienteProfile : Profile
    {
        public RecipienteProfile()
        {
            CreateMap<DgLab.Domain.Entities.Recipiente, RecipienteDto>().ReverseMap();
        }
    }
}
