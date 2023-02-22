using AutoMapper;
using Dapper;
using DgLab.Application.Muestra.Dto;
using DgLab.Application.Recipiente.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Muestra.Queries
{
    public class MuestraOneQueryHandler : IRequestHandler<MuestraOneQuery, MuestraDto>
    {
        private readonly IDbConnection _dapperSource;
        private readonly IMapper _mapper;

        public MuestraOneQueryHandler(IDbConnection dapperSource, IMapper mapper)
        {
            _dapperSource = dapperSource ?? throw new ArgumentNullException(nameof(dapperSource));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public async Task<MuestraDto> Handle(MuestraOneQuery request, CancellationToken cancellationToken)
        {
            var muestra = await _dapperSource.QuerySingleOrDefaultAsync<DgLab.Domain.Entities.Muestra>
               ("SELECT Id,Codigo,Nombre,IdRecipiente,CantEtiqueta,DiasAlmacena,AlmacenaEspecial,TipoLaboratorio,Informacion," +
               "Valoracion,Estado,IdUsuario,NombreEstacion,Fechaserver  FROM Per.Muestra where Id = @Id", new { Id = request.Id });
            return _mapper.Map<MuestraDto>(muestra);
        }
    }
}
