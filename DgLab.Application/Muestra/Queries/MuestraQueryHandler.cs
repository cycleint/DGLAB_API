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
    public class MuestraQueryHandler : IRequestHandler<MuestraQuery, List<MuestraDto>>
    {
        private readonly IDbConnection _dapperSource;
        private readonly IMapper _mapper;

        public MuestraQueryHandler(IDbConnection dapperSource, IMapper mapper)
        {
            _dapperSource = dapperSource ?? throw new ArgumentNullException(nameof(dapperSource));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public async Task<List<MuestraDto>> Handle(MuestraQuery request, CancellationToken cancellationToken)
        {
            var muestras = await _dapperSource.QueryAsync
                 ("SELECT Id,Codigo,Nombre,IdRecipiente,CantEtiqueta,DiasAlmacena,AlmacenaEspecial,TipoLaboratorio,Informacion," +
                 "Valoracion,Estado,IdUsuario,NombreEstacion,Fechaserver  FROM Per.Muestra");

            return _mapper.Map<List<MuestraDto>>(muestras);
        }
    }
}
