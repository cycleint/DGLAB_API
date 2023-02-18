using AutoMapper;
using Dapper;
using DgLab.Application.Tecnica.Dto;
using DgLab.Application.Unidad.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Tecnica.Queries
{
    public class TecnicaOneQueryHandler : IRequestHandler<TecnicaOneQuery, TecnicaDto>
    {
        private readonly IDbConnection _dapperSource;
        private readonly IMapper _mapper;

        public TecnicaOneQueryHandler(IDbConnection dapperSource, IMapper mapper)
        {
            _dapperSource = dapperSource ?? throw new ArgumentNullException(nameof(dapperSource));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<TecnicaDto> Handle(TecnicaOneQuery request, CancellationToken cancellationToken)
        {
            var unidad = await _dapperSource.QuerySingleOrDefaultAsync<DgLab.Domain.Entities.Tecnica>
                 ("SELECT Id,Codigo,Descripcion,Estado,IdUsuario,NombreEstacion,Fechaserver  FROM Per.Tecnica where Id = @Id", new { Id = request.Id });
            return _mapper.Map<TecnicaDto>(unidad);
        }
    }
}
