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
            string query = "SELECT   Per.Area.Id,Codigo,Abreviatura, Per.Area.Nombre,NombreIngles,IdTipo,ValidacionParcial,Color,Estado,IdUsuario,NombreEstacion,Fechaserver,Per.Parametro.Id ,Per.Parametro.Tipo ,Per.Parametro.Nombre  ,Per.Parametro.Valor " +
                "FROM Per.Area  " +
                "inner join Per.Parametro On Per.Parametro.Valor= Per.Area.IdTipo AND Per.Parametro.Tipo='T_ARE'";
            var areas = await _dapperSource.QueryAsync<DgLab.Domain.Entities.Area,
                                        DgLab.Domain.Entities.Parametro,
                                        DgLab.Domain.Entities.Area>
                 (query, (area, tipo) => { 
                        area.Tipo=tipo;
                     return area;
                 });

            return _mapper.Map<List<AreaDto>>(areas);
        }
    }
}
