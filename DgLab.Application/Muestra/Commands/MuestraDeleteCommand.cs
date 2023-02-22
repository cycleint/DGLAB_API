using DgLab.Application.Muestra.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Muestra.Commands
{
   

    public record MuestraDeleteCommand(
            [Required] int Id
          
        ) : IRequest<MuestraDto>;
}
