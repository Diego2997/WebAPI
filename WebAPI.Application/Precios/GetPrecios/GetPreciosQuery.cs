using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Application.Cursos.GetCurso;

namespace WebAPI.Application.Precios.GetPrecios
{
    //USANDO CLASS EN VEZ DE RECORD PARA EL RESPONSE
    public class PrecioResponse
    {
        public Guid? Id { get; set; }
        public string? Nombre { get; set; }
        public decimal? PrecioActual { get; set; }
        public decimal? PrecioPromocion { get; set; }

    }
}
