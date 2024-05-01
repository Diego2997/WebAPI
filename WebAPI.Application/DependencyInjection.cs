using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Application.Core;
using WebAPI.Application.Cursos.CursoCreate;

namespace WebAPI.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAplication( this IServiceCollection services)
        {
            services.AddMediatR(configuration =>
            {
                configuration.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly);
            });
            services.AddFluentValidationAutoValidation();
            services.AddValidatorsFromAssemblyContaining<CursoCreateCommand>();

            services.AddAutoMapper(typeof(MappingProfile).Assembly);
            return services;
        }
    }
}
