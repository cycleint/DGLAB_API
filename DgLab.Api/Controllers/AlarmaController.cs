using DgLab.Application.Alarma.Commands;
using DgLab.Application.Alarma.Dto;
using DgLab.Application.Alarma.Queries;
using DgLab.Application.Area.Commands;
using DgLab.Application.Area.Dto;
using DgLab.Application.Area.Queries;
using DgLab.Application.Requisito.Command;
using DgLab.Application.Requisito.Dto;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DgLab.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlarmaController : ControllerBase
    {
        readonly IMediator _mediator = default!;

        public AlarmaController(IMediator mediator) => _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));

        [HttpPost]
        public async Task<AlarmaDto> Post(AlarmaCreateCommand area) => await _mediator.Send(area);

        [HttpGet]
        public async Task<List<AlarmaDto>> Get() => await _mediator.Send(new AlarmaQuery());

        [HttpGet("{id}")]
        public async Task<AlarmaDto> Get(int id) => await _mediator.Send(new AlarmaOneQuery(id));

        [HttpPut("{id}")]
        public async Task<AlarmaDto> Put(AlarmaCreateCommand alarma, int id)
        {
            var alarmaUpdateRequest = new AlarmaUpdateCommand(
               id, alarma.Nombre,alarma.Descripcion,alarma.Estado
            );

            return await _mediator.Send(alarmaUpdateRequest);
        }

        [HttpDelete("{id}")]
        public async Task<AlarmaDto> Delete(int id) => await _mediator.Send(new AlarmaDeleteCommand(id));
    }
}
