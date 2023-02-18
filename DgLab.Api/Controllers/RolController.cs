
using DgLab.Application.Rol.Commands;
using DgLab.Application.Rol.Dto;
using DgLab.Application.Rol.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DgLab.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolController : ControllerBase
    {
        readonly IMediator _mediator = default!;

        public RolController(IMediator mediator) => _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));

        [HttpGet]
        public async Task<List<RolDto>> Get() => await _mediator.Send(new RolQuery());

        [HttpGet("{id}")]
        public async Task<RolDto> Get(int id) => await _mediator.Send(new RolOneQuery(id));

        [HttpPost]
        public async Task<RolDto> Post(RolCreateCommand rol) => await _mediator.Send(rol);

        [HttpPut("{id}")]
        public async Task<RolDto> Put(RolCreateCommand rol, int id)
        {

            var rolUpdateCommand = new RolUpdateCommand(
                id, rol.Nombre,rol.Estado
            );

            return await _mediator.Send(rolUpdateCommand);
        }

        [HttpDelete("{id}")]
        public async Task<RolDto> Delete(int id) => await _mediator.Send(new RolDeleteCommand(id));
    }
}
