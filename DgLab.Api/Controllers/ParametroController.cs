using DgLab.Application.Parametro.Dto;
using DgLab.Application.Parametro.Queries;
using DgLab.Application.Recipiente.Dto;
using DgLab.Application.Recipiente.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DgLab.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParametroController : ControllerBase
    {
        readonly IMediator _mediator = default!;

        public ParametroController(IMediator mediator) => _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));

        [HttpGet("{tipo}")]
        public async Task<List<ParametroDto>> Get(string tipo) => await _mediator.Send(new ParametroTipoQuery(tipo));
    }
}
