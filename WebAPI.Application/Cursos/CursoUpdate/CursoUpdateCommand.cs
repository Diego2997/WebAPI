using Bogus;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using WebAPI.Application.Core;
using WebAPI.Persistence;

namespace WebAPI.Application.Cursos.CursoUpdate
{
    public class CursoUpdateCommand
    {

        public record CursoUpdateCommandRequest(CursoUpdateRequest cursoUpdateRequest, Guid Id)
            : IRequest<Result<Guid>>;

        internal class CursoUpdateCommandHandler : IRequestHandler<CursoUpdateCommandRequest, Result<Guid>>
        {
            private readonly ApplicationDbContext context;

            public CursoUpdateCommandHandler(ApplicationDbContext context)
            {
                this.context = context;
            }
            public async Task<Result<Guid>> Handle(CursoUpdateCommandRequest request, CancellationToken cancellationToken)
            {
                var cursoId = request.Id;

                var curso = await context.Cursos!.FirstOrDefaultAsync(x => x.Id ==  cursoId);
                if (curso == null)
                {
                    return Result<Guid>.Failure("El id del curso no existe");
                }
                curso.Descripcion = request.cursoUpdateRequest.Descripcion;
                curso.Titulo = request.cursoUpdateRequest.Titulo;
                curso.FechaPublicacion = request.cursoUpdateRequest.FechaPublicacion;

                context.Entry(curso).State = EntityState.Modified;
                var resultado = await context.SaveChangesAsync() > 0;// si se actualizo es igual a 1

                return resultado 
                    ? Result<Guid>.Success(curso.Id) 
                    : Result<Guid>.Failure("Errores en el update");



                
            }
        }

        public class CursoUpdateCommandRequestValidator : AbstractValidator<CursoUpdateCommandRequest>
        {
            public CursoUpdateCommandRequestValidator()
            {
                RuleFor(x => x.cursoUpdateRequest).SetValidator(new CursoUpdateValidator());
                RuleFor(x => x.Id).NotNull();
            }
        }
    }
}
