using AutoMapper;
using Dapper;
using DgLab.Application.Area.Dto;
using DgLab.Application.Requisito.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Area.Queries
{
    public class AreaQueryHandler : IRequestHandler<AreaQuery, List<AreaDto>>
    {
        private readonly IDbConnection _dapperSource;
        private readonly IMapper _mapper;

        public AreaQueryHandler(IDbConnection dapperSource, IMapper mapper)
        {
            _dapperSource = dapperSource ?? throw new ArgumentNullException(nameof(dapperSource));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public async Task<List<AreaDto>> Handle(AreaQuery request, CancellationToken cancellationToken)
        {
            var areas = await _dapperSource.QueryAsync
                 ("SELECT  Id,Codigo,Abreviatura,Nombre,NombreIngles,Tipo,ValidacionParcial,Color,Estado,IdUsuario,NombreEstacion,Fechaserver" +
                 " FROM Per.Area");

            return _mapper.Map<List<AreaDto>>(areas);
        }
    }
}
