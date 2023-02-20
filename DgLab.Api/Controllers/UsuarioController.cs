
using DgLab.Application.Requisito.Dto;
using DgLab.Application.Requisito.Queries;
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

    }
}
