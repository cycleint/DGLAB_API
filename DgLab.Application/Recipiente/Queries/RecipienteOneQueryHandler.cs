using AutoMapper;
using Dapper;
using DgLab.Application.Recipiente.Dto;
using DgLab.Application.Requisito.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgLab.Application.Recipiente.Queries
{
    public class RecipienteOneQueryHandler : IRequestHandler<RecipienteOneQuery, RecipienteDto>
    {
        private readonly IDbConnection _dapperSource;
        private readonly IMapper _mapper;

        public RecipienteOneQueryHandler(IDbConnection dapperSource, IMapper mapper)
        {
            _dapperSource = dapperSource ?? throw new ArgumentNullException(nameof(dapperSource));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<RecipienteDto> Handle(RecipienteOneQuery request, CancellationToken cancellationToken)
        {
            var recipiente = await _dapperSource.QuerySingleOrDefaultAsync<DgLab.Domain.Entities.Recipiente>
                ("SELECT Id,Nombre,Imagen,IdUnidad,Estado,IdUsuario,NombreEstacion,Fechaserver FROM Per.Recipiente where Id = @Id", new { Id = request.Id });
            return _mapper.Map<RecipienteDto>(recipiente);
        }
    }
}
