
using DgLab.Application.Requisito.Dto;
using DgLab.Application.Requisito.Queries;
using DgLab.Application.Unidad.Commands;
using DgLab.Application.Unidad.Dto;
using DgLab.Application.Usuario.Commands;
using DgLab.Application.Usuario.Dto;
using DgLab.Application.Usuario.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DgLab.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        readonly IMediator _mediator = default!;

        public UsuarioController(IMediator mediator) => _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));

        [HttpPost]
        public async Task<UsuarioDto> Post(UsuarioCreateCommand usuario) => await _mediator.Send(usuario);

        [HttpPost("ingresar")]
        public async Task<UsuarioDto> ingresar(IncioSesionCommand usuario) => await _mediator.Send(usuario);

        [HttpGet]
        public async Task<List<UsuarioDto>> Get() => await _mediator.Send(new UsuarioQuery());

        [HttpGet("{id}")]
        public async Task<UsuarioDto> Get(int id) => await _mediator.Send(new UsuarioOneQuery(id));

        [HttpPut("{id}")]
        public async Task<UsuarioDto> Put(UsuarioUpdateDto usuario, int id)
        {

            var usuarioUpdateRequest = new UsuarioUpdateCommand(
                id, usuario.Identificacion, usuario.Nombre, usuario.Apellido, usuario.Codigo, usuario.Correo,
                usuario.Firma,usuario.Foto,usuario.Estado
            );

            return await _mediator.Send(usuarioUpdateRequest);
        }

        [HttpDelete("{id}")]
        public async Task<UsuarioDto> Delete(int id) => await _mediator.Send(new UsuarioDeleteCommand(id));

    }
}
