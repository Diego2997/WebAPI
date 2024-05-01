using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Application.Precios.GetPrecios
{
    public  record PrecioResponse(
        Guid? Id,
        string? nombre,
        decimal? PrecioActual,
        decimal? PrecioPromocion

        )
    {
        public PrecioResponse (): this(null, null, null, null)
        {

        }
    }
}
