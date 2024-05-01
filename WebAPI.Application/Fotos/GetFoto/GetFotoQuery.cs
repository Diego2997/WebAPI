using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Application.Fotos.GetFoto
{
    public  record FotoResponse(
        
        Guid? Id,
        string? Url,
        Guid? CursoId
        )
    {
        public FotoResponse(): this(null, null, null) { }
    }
}
