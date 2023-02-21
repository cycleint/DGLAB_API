using AutoMapper;
using Dapper;
using DgLab.Application.Alarma.Dto;
using DgLab.Application.Area.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Alarma.Queries
{
    public class AlarmaQueryHandler : IRequestHandler<AlarmaQuery, List<AlarmaDto>>
    {
        private readonly IDbConnection _dapperSource;
        private readonly IMapper _mapper;

        public AlarmaQueryHandler(IDbConnection dapperSource, IMapper mapper)
        {
            _dapperSource = dapperSource ?? throw new ArgumentNullException(nameof(dapperSource));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<List<AlarmaDto>> Handle(AlarmaQuery request, CancellationToken cancellationToken)
        {
            var alarmas = await _dapperSource.QueryAsync
                ("SELECT Id,Nombre,Descripcion,Estado,IdUsuario,NombreEstacion,Fechaserver  FROM Per.Alarma");

            return _mapper.Map<List<AlarmaDto>>(alarmas);
        }
    }
}
