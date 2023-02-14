using AutoMapper;
using DgLab.Application.Rol.Commands;
using DgLab.Application.Rol.Dto;
using DgLab.Domain.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Rol.Queries
{
    public class RolQueryHandler : IRequestHandler<RolQuery, List<RolDto>>
    {
        private readonly RolService _RolService;
        private readonly IMapper _mapper;
        public RolQueryHandler(RolService rolService, IMapper mapper)
        {
            _RolService = rolService ?? throw new ArgumentNullException(nameof(rolService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public Task<List<RolDto>> Handle(RolQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
