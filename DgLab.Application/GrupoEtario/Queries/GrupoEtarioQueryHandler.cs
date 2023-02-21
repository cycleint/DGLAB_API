using AutoMapper;
using Dapper;
using DgLab.Application.GrupoEtario.Dto;
using DgLab.Application.Requisito.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.GrupoEtario.Queries
{
    public class GrupoEtarioQueryHandler : IRequestHandler<GrupoEtarioQuery, List<GrupoEtarioDto>>
    {
        private readonly IDbConnection _dapperSource;
        private readonly IMapper _mapper;

        public GrupoEtarioQueryHandler(IDbConnection dapperSource, IMapper mapper)
        {
            _dapperSource = dapperSource ?? throw new ArgumentNullException(nameof(dapperSource));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public async Task<List<GrupoEtarioDto>> Handle(GrupoEtarioQuery request, CancellationToken cancellationToken)
        {
            var gruposEtario = await _dapperSource.QueryAsync
                ("SELECT Id,Codigo,Nombre,Genero,IdUnidad,RangoInicial,RangoFinal,Estado,IdUsuario,NombreEstacion,Fechaserver" +
                " FROM Per.GrupoEtario");

            return _mapper.Map<List<GrupoEtarioDto>>(gruposEtario);
        }
    }
}
