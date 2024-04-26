using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Domain
{
    public class Curso : ClaseBase
    {
        public string? Titulo { get; set; }
        public string? Descripcion { get; set; }
        public DateTime? FechaPublicacion { get; set; }
        public ICollection<Calificacion>? Calificaciones { get; set; }
        public ICollection<Precio>? Precios { get; set; }
        public ICollection<CursoPrecio>? CursoPrecios { get; set; }

        public ICollection<Instructor>? Instructores { get; set;}
        public ICollection<CursoInstructor>? CursoInstructores { get; set; }

        public ICollection<Foto>? Fotos { get; set;}
     
    }
}
