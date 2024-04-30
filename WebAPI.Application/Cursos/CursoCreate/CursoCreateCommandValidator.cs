using FluentValidation;
using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Application.Cursos.CursoCreate
{
    public class CursoCreateCommandValidator : AbstractValidator<CursoCreateRequest>
    {
        public CursoCreateCommandValidator()
        {
            RuleFor(x => x.Titulo).NotEmpty();
            RuleFor(x => x.Descripcion).NotEmpty();

        }
    }
}
