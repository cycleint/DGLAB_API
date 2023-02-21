using DgLab.Application.GrupoEtario.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.GrupoEtario.Queries
{   
    public record GrupoEtarioOneQuery([Required] int Id) : IRequest<GrupoEtarioDto>;
}
