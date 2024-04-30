using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Application.interfaces;
using WebAPI.Domain;
using WebAPI.Persistence;

namespace WebAPI.Application.Cursos.CursoReporteExcel
{
    public class CursoReporteExcelQuery
    {
        public record CursoReporteExcelQueryRequest : IRequest<MemoryStream>;

        internal class CursoReporteExcelQueryHandler : IRequestHandler<CursoReporteExcelQueryRequest, MemoryStream>
        {
            private readonly ApplicationDbContext context;
            private readonly IReportService<Curso> reportService;

            public CursoReporteExcelQueryHandler(ApplicationDbContext context,IReportService<Curso> reportService)
            {
                this.context = context;
                this.reportService = reportService;
            }
            public async Task<MemoryStream> Handle(CursoReporteExcelQueryRequest request, CancellationToken cancellationToken)
            {
                var cursos = await context.Cursos!.Take(10).Skip(0).ToListAsync();

                return await reportService.GetCsvReport(cursos);
            }
        }
    }
}
