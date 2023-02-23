using AutoMapper;
using Dapper;
using DgLab.Application.Parametro.Dto;
using DgLab.Application.Requisito.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Parametro.Queries
{
    public class ParametroTipoQueryHandler : IRequestHandler<ParametroTipoQuery, List<ParametroDto>>
    {
        private readonly IDbConnection _dapperSource;
        private readonly IMapper _mapper;

        public ParametroTipoQueryHandler(IDbConnection dapperSource, IMapper mapper)
        {
            _dapperSource = dapperSource ?? throw new ArgumentNullException(nameof(dapperSource));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public async Task<List<ParametroDto>> Handle(ParametroTipoQuery request, CancellationToken cancellationToken)
        {
            var parametros = await _dapperSource.QueryAsync
                 ("SELECT Id,Tipo,Nombre,Valor  FROM Per.Parametro where Tipo = @Tipo", new { Tipo = request.Tipo });

            return _mapper.Map<List<ParametroDto>>(parametros);
        }
    }
}
