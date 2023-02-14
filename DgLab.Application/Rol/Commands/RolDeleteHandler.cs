using AutoMapper;
using DgLab.Application.Person.Commands;
using DgLab.Domain.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Rol.Commands
{
    public class RolDeleteHandler : AsyncRequestHandler<RolDeleteCommand>
    {
        private readonly RolService _RolService;
       

        public RolDeleteHandler(RolService rolService, IMapper mapper)
        {
            _RolService = rolService ?? throw new ArgumentNullException(nameof(rolService));           
        }

        protected override Task Handle(RolDeleteCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
