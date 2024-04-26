using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Domain
{
    public class Foto : ClaseBase
    {
        public string? Url { get; set; }
        public Guid? CursoId { get; set; }
        public Curso? Curso { get; set; }
    }
}
