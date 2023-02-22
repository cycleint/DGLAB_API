using DgLab.Application.Alarma.Dto;
using DgLab.Application.Alarma.Queries;
using DgLab.Application.Muestra.Commands;
using DgLab.Application.Muestra.Dto;
using DgLab.Application.Muestra.Queries;
using DgLab.Application.Recipiente.Commands;
using DgLab.Application.Recipiente.Dto;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DgLab.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MuestraController : ControllerBase
    {
        readonly IMediator _mediator = default!;

        public MuestraController(IMediator mediator) => _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));

        [HttpPost]
        public async Task<MuestraDto> Post(MuestraCreateCommand muestra) => await _mediator.Send(muestra);

        [HttpGet]
        public async Task<List<MuestraDto>> Get() => await _mediator.Send(new MuestraQuery());

        [HttpGet("{id}")]
        public async Task<MuestraDto> Get(int id) => await _mediator.Send(new MuestraOneQuery(id));

        [HttpPut("{id}")]
        public async Task<MuestraDto> Put(MuestraCreateCommand muestra, int id)
        {
            var muestraUpdateRequest = new MuestraUpdateCommand(
               id,muestra.Codigo,muestra.Nombre,muestra.IdRecipiente,muestra.CantEtiqueta,muestra.DiasAlmacena,
               muestra.AlmacenaEspecial,muestra.TipoLaboratorio,muestra.Informacion,muestra.Valoracion,muestra.Estado
            );

            return await _mediator.Send(muestraUpdateRequest);
        }

        [HttpDelete("{id}")]
        public async Task<MuestraDto> Delete(int id) => await _mediator.Send(new MuestraDeleteCommand(id));
    }
}
