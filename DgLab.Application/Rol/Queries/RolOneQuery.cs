using DgLab.Application.Rol.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Rol.Queries
{
    public record RolOneQuery([Required] Guid Id) : IRequest<RolDto>;
}
