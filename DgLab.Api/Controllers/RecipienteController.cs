using DgLab.Application.Alarma.Commands;
using DgLab.Application.Alarma.Dto;
using DgLab.Application.Alarma.Queries;
using DgLab.Application.Recipiente.Commands;
using DgLab.Application.Recipiente.Dto;
using DgLab.Application.Recipiente.Queries;
using DgLab.Application.Requisito.Command;
using DgLab.Application.Requisito.Dto;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DgLab.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipienteController : ControllerBase
    {
        readonly IMediator _mediator = default!;

        public RecipienteController(IMediator mediator) => _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));

        [HttpPost]
        public async Task<RecipienteDto> Post(RecipienteCreateCommand recipiente) => await _mediator.Send(recipiente);

        [HttpGet]
        public async Task<List<RecipienteDto>> Get() => await _mediator.Send(new RecipienteQuery());

        [HttpGet("{id}")]
        public async Task<RecipienteDto> Get(int id) => await _mediator.Send(new RecipienteOneQuery(id));

        [HttpPut("{id}")]
        public async Task<RecipienteDto> Put(RecipienteCreateCommand recipiente, int id)
        {
            var recipienteUpdateRequest = new RecipienteUpdateCommand(
               id, recipiente.Nombre, recipiente.Imagen,recipiente.IdUnidad, recipiente.Estado
            );

            return await _mediator.Send(recipienteUpdateRequest);
        }

        [HttpDelete("{id}")]
        public async Task<RecipienteDto> Delete(int id) => await _mediator.Send(new RecipienteDeleteCommand(id));
    }
}
