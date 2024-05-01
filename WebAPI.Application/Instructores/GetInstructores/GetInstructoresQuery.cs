using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Application.Instructores.GetInstructores
{
    public record InstructorResponse(
        Guid? Id,
        string? Nombre,
        string? Apellido,
        string? Grado
        )
    {
        public InstructorResponse() : this(null, null, null, null)
        {

        }
    }
}
