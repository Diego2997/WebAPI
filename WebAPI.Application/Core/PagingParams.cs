﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Application.Core
{
    public abstract class PagingParams
    {
        public int PageNumber { get; set; } = 1;
        private const int MaxPageSize = 50;
        private int _pageSize = 10;
        public int PageSize
        {
            get => _pageSize;
            set => _pageSize = (value > MaxPageSize) ? MaxPageSize : value;
        }

        public string? OrderBy {  get; set; }
        public bool? OrderAsc { get; set; } = true;
    }
}
