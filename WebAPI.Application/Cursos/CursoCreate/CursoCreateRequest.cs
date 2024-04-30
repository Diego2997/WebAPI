using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Application.Cursos.CursoCreate
{
    public class CursoCreateRequest 
    {
        public string? Titulo { get; set; }
        public string? Descripcion { get; set; }
        public DateTime? FechaPublicacion { get; set; }
        public IFormFile? Foto  { get; set; }
        public Guid? PrecioId { get; set; }
        public Guid? InstructorId { get; set; }
    }
}
