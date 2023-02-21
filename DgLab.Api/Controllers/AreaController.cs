using DgLab.Application.Area.Commands;
using DgLab.Application.Area.Dto;
using DgLab.Application.Area.Queries;
using DgLab.Application.Requisito.Command;
using DgLab.Application.Requisito.Dto;
using DgLab.Application.Requisito.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DgLab.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AreaController : ControllerBase
    {
        readonly IMediator _mediator = default!;

        public AreaController(IMediator mediator) => _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));

        [HttpPost]
        public async Task<AreaDto> Post(AreaCreateCommand area) => await _mediator.Send(area);

        [HttpGet]
        public async Task<List<AreaDto>> Get() => await _mediator.Send(new AreaQuery());

        [HttpGet("{id}")]
        public async Task<AreaDto> Get(int id) => await _mediator.Send(new AreaOneQuery(id));

        [HttpPut("{id}")]
        public async Task<AreaDto> Put(AreaCreateCommand area, int id)
        {
            var areaUpdateRequest = new AreaUpdateCommand(
               id,area.Codigo,area.Abreviatura,area.Nombre,area.NombreIngles,area.Tipo,area.ValidacionParcial,area.Codigo,area.Estado
            );

            return await _mediator.Send(areaUpdateRequest);
        }

        [HttpDelete("{id}")]
        public async Task<AreaDto> Delete(int id) => await _mediator.Send(new AreaDeleteCommand(id));
    }
}
