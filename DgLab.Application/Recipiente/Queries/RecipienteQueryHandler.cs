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
    public class RecipienteQueryHandler : IRequestHandler<RecipienteQuery, List<RecipienteDto>>
    {

        private readonly IDbConnection _dapperSource;
        private readonly IMapper _mapper;

        public RecipienteQueryHandler(IDbConnection dapperSource, IMapper mapper)
        {
            _dapperSource = dapperSource ?? throw new ArgumentNullException(nameof(dapperSource));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<List<RecipienteDto>> Handle(RecipienteQuery request, CancellationToken cancellationToken)
        {
            var recipientes = await _dapperSource.QueryAsync
                 ("SELECT Id,Nombre,Imagen,IdUnidad,Estado,IdUsuario,NombreEstacion,Fechaserver FROM Per.Recipiente");

            return _mapper.Map<List<RecipienteDto>>(recipientes);
        }
    }
}
