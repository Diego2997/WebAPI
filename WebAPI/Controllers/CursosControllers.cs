using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Application.Core;
using WebAPI.Application.Cursos.CursoCreate;
using WebAPI.Application.Cursos.CursoReporteExcel;
using static WebAPI.Application.Cursos.CursoCreate.CursoCreateCommand;
using static WebAPI.Application.Cursos.CursoReporteExcel.CursoReporteExcelQuery;

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
        public async Task<ActionResult<Result<Guid>>> Post([FromForm] CursoCreateRequest request
            ,CancellationToken cancellationToken)
        {
            var command = new CursoCreateCommandRequest(request);
            return await sender.Send(command, cancellationToken);
           
        }


        [HttpGet("reporte")]
        public async Task<IActionResult> ReporteCSV(CancellationToken cancellationToken)
        {
            var query = new CursoReporteExcelQueryRequest();
            var resultado =  await sender.Send(query,cancellationToken);
            byte[] excelBytes = resultado.ToArray();
            return File(excelBytes, "text/csv","cursos.csv");
        }
    }
}
