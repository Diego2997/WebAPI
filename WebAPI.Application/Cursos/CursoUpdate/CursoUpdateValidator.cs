using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Application.Cursos.CursoUpdate
{
    public class CursoUpdateValidator : AbstractValidator<CursoUpdateRequest>
    {
        public CursoUpdateValidator()
        {
            RuleFor(x => x.Titulo).NotEmpty().WithMessage("El titulo no debe ser vacio");
            RuleFor(x => x.Descripcion).NotEmpty()
                .WithMessage("La descripcion no debe ser vacio");
            RuleFor(x => x.FechaPublicacion).NotEmpty()
                 .WithMessage("La fecha de publicacion no debe ser vacio");
        }
    }
}
