using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Domain;
using WebAPI.Persistence;

namespace WebAPI.Application.Cursos.CursoCreate
{
    public class CursoCreateCommand
    {
        public record CursoCreateCommandRequest(CursoCreateRequest cursoCreateRequest)
        : IRequest<Guid>;


        internal class CursoCreateCommandHandler
        : IRequestHandler<CursoCreateCommandRequest, Guid>
        {
            private readonly ApplicationDbContext _context;

            public CursoCreateCommandHandler(ApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<Guid> Handle(
                CursoCreateCommandRequest request,
                CancellationToken cancellationToken
            )
            {

                var curso = new Curso
                {
                    Id = Guid.NewGuid(),
                    Titulo = request.cursoCreateRequest.Titulo,
                    Descripcion = request.cursoCreateRequest.Descripcion,
                    FechaPublicacion = request.cursoCreateRequest.FechaPublicacion
                };

                _context.Add(curso);

                await _context.SaveChangesAsync(cancellationToken);

                return curso.Id;
            }
        }
    }
}
