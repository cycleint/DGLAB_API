using DgLab.Application.Tecnica.Commands;
using DgLab.Application.Tecnica.Dto;
using DgLab.Application.Tecnica.Queries;
using DgLab.Application.Unidad.Commands;
using DgLab.Application.Unidad.Dto;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DgLab.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TecnicaController : ControllerBase
    {
        readonly IMediator _mediator = default!;

        public TecnicaController(IMediator mediator) => _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));

        [HttpPost]
        public async Task<TecnicaDto> Post(TecnicaCreateCommand tecnica) => await _mediator.Send(tecnica);

        [HttpGet]
        public async Task<List<TecnicaDto>> Get() => await _mediator.Send(new TecnicaQuery());

        [HttpGet("{id}")]
        public async Task<TecnicaDto> Get(int id) => await _mediator.Send(new TecnicaOneQuery(id));

        [HttpPut("{id}")]
        public async Task<TecnicaDto> Put(TecnicaCreateCommand tecnica, int id)
        {

            var tecnicaUpdateRequest = new TecnicaUpdateCommand(
                id,tecnica.Codigo, tecnica.Descripcion, tecnica.Estado
            );

            return await _mediator.Send(tecnicaUpdateRequest);
        }

        [HttpDelete("{id}")]
        public async Task<TecnicaDto> Delete(int id) => await _mediator.Send(new TecnicaDeleteCommand(id));
    }
}
