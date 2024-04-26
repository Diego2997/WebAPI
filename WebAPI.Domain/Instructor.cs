using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Domain
{
    public class Instructor : ClaseBase
    {
        public string? Apellidos { get; set; }
        public string? Nombre { get; set; }
        public string? Grado { get; set; }
        public ICollection<Curso>? Cursos { get; set; }
        public ICollection<CursoInstructor>? CursoInstructores { get; set; }
    }
}
