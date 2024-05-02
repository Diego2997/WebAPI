﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Application.Core;

namespace WebAPI.Application.Cursos.GetCursos
{
    public  class GetCursosRequest : PagingParams
    {
        public string? Titulo {  get; set; }
        public string? Descripcion { get; set; }
    }
}
