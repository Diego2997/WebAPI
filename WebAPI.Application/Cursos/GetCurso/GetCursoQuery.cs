using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Application.Calificaciones.GetCalificaciones;
using WebAPI.Application.Core;
using WebAPI.Application.Fotos.GetFoto;
using WebAPI.Application.Instructores.GetInstructores;
using WebAPI.Application.Precios.GetPrecios;
using WebAPI.Persistence;

namespace WebAPI.Application.Cursos.GetCurso
{
    public class GetCursoQuery
    {
        public record GetCursoQueryRequest : IRequest<Result<CursoResponse>>
        {
            public Guid Id { get; set; }
        } //
          //CursoResponse es un DTO


        internal class GetCursoQueryHandler : IRequestHandler<GetCursoQueryRequest, Result<CursoResponse>>
        {
            private readonly ApplicationDbContext context;
            private readonly IMapper mapper;

            public GetCursoQueryHandler(ApplicationDbContext context,IMapper mapper)
            {
                this.context = context;
                this.mapper = mapper;
            }
            public async Task<Result<CursoResponse>> Handle(
                GetCursoQueryRequest request,
                CancellationToken cancellationToken)
            {
                var curso = await context.Cursos!.Where(x => x.Id == request.Id)
                            .Include(x => x.Instructores)
                            .Include(x => x.Precios)
                            .Include(x => x.Calificaciones)
                            .ProjectTo<CursoResponse>(mapper.ConfigurationProvider)
                            .FirstOrDefaultAsync();

                return Result<CursoResponse>.Success(curso!);
            }
        }
    }

    public record CursoResponse(
        Guid Id,
        string Titulo,
        string Descripcion,
   
        DateTime? FechaPublicacion,
        List<InstructorResponse> Instructores,
        List<CalificacionResponse> Calificaciones,
        List<PrecioResponse> Precios,
        List<FotoResponse> Fotos
        );
}
