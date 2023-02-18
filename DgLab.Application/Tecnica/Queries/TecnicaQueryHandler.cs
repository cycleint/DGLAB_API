using AutoMapper;
using Dapper;
using DgLab.Application.Tecnica.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Tecnica.Queries
{
    public class TecnicaQueryHandler : IRequestHandler<TecnicaQuery, List<TecnicaDto>>
    {
        private readonly IDbConnection _dapperSource;
        private readonly IMapper _mapper;

        public TecnicaQueryHandler(IDbConnection dapperSource, IMapper mapper)
        {
            _dapperSource = dapperSource ?? throw new ArgumentNullException(nameof(dapperSource));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public async Task<List<TecnicaDto>> Handle(TecnicaQuery request, CancellationToken cancellationToken)
        {
            var tecnicas = await _dapperSource.QueryAsync
                  ("SELECT Id,Codigo,Descripcion,Estado,IdUsuario,NombreEstacion,Fechaserver  FROM Per.Tecnica"
                  );

            return _mapper.Map<List<TecnicaDto>>(tecnicas);
        }
    }
}
