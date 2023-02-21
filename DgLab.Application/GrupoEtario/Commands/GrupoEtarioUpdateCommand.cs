using DgLab.Application.GrupoEtario.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.GrupoEtario.Commands
{

    public record GrupoEtarioUpdateCommand(
        [Required] int Id,
        [Required][MaxLength(5)] string Codigo,
        [Required] string Nombre,
        [Required] int Genero,
        [Required] int IdUnidad,
        [Required] int RangoInicial,
        [Required] int RangoFinal,
        [Required] bool Estado       
        ) : IRequest<GrupoEtarioDto>;
}
