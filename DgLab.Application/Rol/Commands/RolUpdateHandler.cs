using AutoMapper;
using DgLab.Application.Rol.Dto;
using DgLab.Domain.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Rol.Commands
{
    public class RolUpdateHandler : IRequestHandler<RolUpdateCommand, RolDto>
    {
        private readonly RolService _RolService;
        private readonly IMapper _mapper;
        public RolUpdateHandler(RolService rolService, IMapper mapper)
        {
            _RolService = rolService ?? throw new ArgumentNullException(nameof(rolService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public Task<RolDto> Handle(RolUpdateCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
