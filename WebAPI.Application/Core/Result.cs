﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Application.Core
{
    public class Result<T>
    {
        public bool IsSuccess { get; set; }
        public T? Value { get; set; }
        public string? Error { get; set; }

        public static Result<T> Success(T value) => new Result<T>
        {
            IsSuccess = true, Value = value
        };
        public static Result<T> Failure(string error) //otra forma de hacer lo de arriba
        {
            return new Result<T>
            {

                IsSuccess = false,
                Error = error
            };
        }
    }
}
