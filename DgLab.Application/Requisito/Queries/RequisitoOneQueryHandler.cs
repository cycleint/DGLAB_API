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
    public class RequisitoOneQueryHandler : IRequestHandler<RequisitoOneQuery, RequisitoDto>
    {
        private readonly IDbConnection _dapperSource;
        private readonly IMapper _mapper;

        public RequisitoOneQueryHandler(IDbConnection dapperSource, IMapper mapper)
        {
            _dapperSource = dapperSource ?? throw new ArgumentNullException(nameof(dapperSource));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public async Task<RequisitoDto> Handle(RequisitoOneQuery request, CancellationToken cancellationToken)
        {
            var requisito = await _dapperSource.QuerySingleOrDefaultAsync<DgLab.Domain.Entities.Requisito>
                ("SELECT Id,Nombre,Descripcion,Estado,IdUsuario,NombreEstacion,Fechaserver  FROM Per.Requisito where Id = @Id", new { Id = request.Id });
            return _mapper.Map<RequisitoDto>(requisito);
        }
    }

}
