using DgLab.Application.Unidad.Commands;
using DgLab.Application.Unidad.Dto;
using DgLab.Application.Unidad.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DgLab.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnidadController : ControllerBase
    {
        readonly IMediator _mediator = default!;

        public UnidadController(IMediator mediator) => _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));

        [HttpPost]
        public async Task<UnidadDto> Post(UnidadCreateCommand unidad) => await _mediator.Send(unidad);

        [HttpGet]
        public async Task<List<UnidadDto>> Get() => await _mediator.Send(new UnidadQuery());

        [HttpGet("{id}")]
        public async Task<UnidadDto> Get(int id) => await _mediator.Send(new UnidadOneQuery(id));

        [HttpPut("{id}")]
        public async Task<UnidadDto> Put(UnidadCreateCommand unidad, int id)
        {

            var unidadUpdateRequest = new UnidadUpdateCommand(
                id, unidad.Nombre, unidad.NombreInter, unidad.Factor, unidad.Estado
            );

           return  await _mediator.Send(unidadUpdateRequest);
        }

        [HttpDelete("{id}")]
        public async Task<UnidadDto> Delete(int id) => await _mediator.Send(new UnidadDeleteCommand(id));

    }
}
