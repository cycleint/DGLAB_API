using DgLab.Application.Requisito.Command;
using DgLab.Application.Requisito.Dto;
using DgLab.Application.Requisito.Queries;
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
    public class RequisitoController : ControllerBase
    {
        readonly IMediator _mediator = default!;

        public RequisitoController(IMediator mediator) => _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));

        [HttpPost]
        public async Task<RequisitoDto> Post(RequisitoCreateCommand requisito) => await _mediator.Send(requisito);

        [HttpGet]
        public async Task<List<RequisitoDto>> Get() => await _mediator.Send(new RequisitoQuery());

        [HttpGet("{id}")]
        public async Task<RequisitoDto> Get(int id) => await _mediator.Send(new RequisitoOneQuery(id));

        [HttpPut("{id}")]
        public async Task<RequisitoDto> Put(RequisitoCreateCommand tecnica, int id)
        {

            var requisitoUpdateRequest = new RequisitoUpdateCommand(
                id, tecnica.Nombre, tecnica.Descripcion, tecnica.Estado
            );

            return await _mediator.Send(requisitoUpdateRequest);
        }

        [HttpDelete("{id}")]
        public async Task<RequisitoDto> Delete(int id) => await _mediator.Send(new RequisitoDeleteCommand(id));
    }
}
