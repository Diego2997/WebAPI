using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Application.Calificaciones.GetCalificaciones
{
    public record CalificacionResponse(
        string? Alumno,
        int? Puntaje,
        string? Comentario,
        string? NombreCurso

        )
    {
        public CalificacionResponse() : this(null, null, null, null) { }
    }
}
