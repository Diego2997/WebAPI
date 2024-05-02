using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Application.Cursos.CursoUpdate
{
    public class CursoUpdateRequest
    {
        public string? Titulo { get; set; }
        public string? Descripcion { get; set; }
        public DateTime FechaPublicacion { get; set; }
    }
}
