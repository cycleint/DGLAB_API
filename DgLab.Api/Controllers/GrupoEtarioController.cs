using DgLab.Application.Area.Dto;
using DgLab.Application.Area.Queries;
using DgLab.Application.GrupoEtario.Commands;
using DgLab.Application.GrupoEtario.Dto;
using DgLab.Application.GrupoEtario.Queries;
using DgLab.Application.Requisito.Command;
using DgLab.Application.Requisito.Dto;
using DgLab.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DgLab.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GrupoEtarioController : ControllerBase
    {
        readonly IMediator _mediator = default!;

        public GrupoEtarioController(IMediator mediator) => _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));

        [HttpPost]
        public async Task<GrupoEtarioDto> Post(GrupoEtarioCreateCommand grupoEtario) => await _mediator.Send(grupoEtario);

        [HttpGet]
        public async Task<List<GrupoEtarioDto>> Get() => await _mediator.Send(new GrupoEtarioQuery());

        [HttpGet("{id}")]
        public async Task<GrupoEtarioDto> Get(int id) => await _mediator.Send(new GrupoEtarioOneQuery(id));

        [HttpPut("{id}")]
        public async Task<GrupoEtarioDto> Put(GrupoEtarioCreateCommand grupoEtario, int id)
        {

            var grupoEtarioUpdateRequest = new GrupoEtarioUpdateCommand(
                id, grupoEtario.Codigo,grupoEtario.Nombre,grupoEtario.Genero,grupoEtario.IdUnidad,grupoEtario.RangoInicial,grupoEtario.RangoFinal,grupoEtario.Estado
            );

            return await _mediator.Send(grupoEtarioUpdateRequest);
        }

        [HttpDelete("{id}")]
        public async Task<GrupoEtarioDto> Delete(int id) => await _mediator.Send(new GrupoEtarioDeleteCommand(id));
    }
}
