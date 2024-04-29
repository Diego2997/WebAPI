using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Application.Cursos.CursoCreate;
using static WebAPI.Application.Cursos.CursoCreate.CursoCreateCommand;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/cursos")]
    public class CursosControllers : ControllerBase
    {
        private readonly ISender sender;

        public CursosControllers(ISender sender)
        {
            this.sender = sender;
        }

        [HttpPost("create")]
        public async Task<ActionResult<Guid>> Post([FromForm] CursoCreateRequest request
            ,CancellationToken cancellationToken)
        {
            var command = new CursoCreateCommandRequest(request);
            var resultado = await sender.Send(command, cancellationToken);
            return Ok(resultado);
        }
    }
}
