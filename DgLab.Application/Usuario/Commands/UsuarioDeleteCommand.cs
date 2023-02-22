﻿using DgLab.Application.Usuario.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Usuario.Commands
{
  
    public record UsuarioDeleteCommand(
        [Required] int Id        
    ) : IRequest<UsuarioDto>;
}
