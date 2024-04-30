using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Application.Core;
using WebAPI.Domain;
using WebAPI.Persistence;

namespace WebAPI.Application.Cursos.CursoCreate
{
    public class CursoCreateCommand
    {
        public record CursoCreateCommandRequest(CursoCreateRequest cursoCreateRequest)
        : IRequest<Result<Guid>>;


        internal class CursoCreateCommandHandler
        : IRequestHandler<CursoCreateCommandRequest, Result<Guid>>
        {
            private readonly ApplicationDbContext _context;

            public CursoCreateCommandHandler(ApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<Result<Guid>> Handle(
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

                if (request.cursoCreateRequest.InstructorId is not null)
                {
                    var instructor = await _context.Instructores!.FindAsync( request.cursoCreateRequest.InstructorId);
                if(instructor is null)
                {
                    return Result<Guid>.Failure("El id del instructor no existe");
                }

                curso.Instructores = new List<Instructor>() { instructor };
                }
                _context.Add(curso);

                var resultado = await _context.SaveChangesAsync(cancellationToken) > 0;

                return resultado 
                    ? Result<Guid>.Success(curso.Id) 
                    : Result<Guid>.Failure("No se pudo insertar el curso");
                
            }
        }

        public class CursoCreateCommandRequestValidator
            : AbstractValidator<CursoCreateCommandRequest>
        {
            public CursoCreateCommandRequestValidator()
            {
                RuleFor(x => x.cursoCreateRequest).SetValidator(new CursoCreateCommandValidator());
            }
        }
    }
}
