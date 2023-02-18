using AutoMapper;
using Dapper;
using DgLab.Application.Requisito.Dto;
using DgLab.Application.Tecnica.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Requisito.Queries
{
    public class RequisitoQueryHandler : IRequestHandler<RequisitoQuery, List<RequisitoDto>>
    {
        private readonly IDbConnection _dapperSource;
        private readonly IMapper _mapper;

        public RequisitoQueryHandler(IDbConnection dapperSource, IMapper mapper)
        {
            _dapperSource = dapperSource ?? throw new ArgumentNullException(nameof(dapperSource));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<List<RequisitoDto>> Handle(RequisitoQuery request, CancellationToken cancellationToken)
        {
            var requisitos = await _dapperSource.QueryAsync
                 ("SELECT Id,Nombre,Descripcion,Estado,IdUsuario,NombreEstacion,Fechaserver  FROM Per.Requisito");

            return _mapper.Map<List<RequisitoDto>>(requisitos);
        }
    }
}
