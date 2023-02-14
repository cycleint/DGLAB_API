using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Rol.Commands
{
   

    public record RolDeleteCommand(
     [Required] Guid Id    
   ) : IRequest;
}
