using Bogus;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebAPI.Domain;
using WebAPI.Persistence;
using WebAPI.Persistence.Models;

namespace WebAPI.WebAPI.Extensions
{
    public static class DataSeed
    {
        public static async Task SeedDataAuthentication(
            this IApplicationBuilder app
            )
        {
            using var scope = app.ApplicationServices.CreateScope();
            var service = scope.ServiceProvider;
            var loggerFactory = service.GetRequiredService<ILoggerFactory>();

            try
            {
                var context = service.GetRequiredService<ApplicationDbContext>();
                await context.Database.MigrateAsync();
                var userManager = service.GetRequiredService<UserManager<AppUser>>();

                if (!userManager.Users.Any())
                {
                    var userAdmin = new AppUser
                    {
                        NombreCompleto = "Diego Mercado",
                        UserName = "diegomercado",
                        Email = "diego.mercado@gmail.com"
                    };
                    //lo encripta solo el usermanager
                    await userManager.CreateAsync( userAdmin,"Password123$" );
                    await userManager.AddToRoleAsync(userAdmin, CustomRoles.ADMIN);


                    var userClient = new AppUser
                    {
                        NombreCompleto = "Juan Perez",
                        UserName = "juanperez",
                        Email = "juan.perez@gmail.com"
                    };
                    //lo encripta solo el usermanager
                    await userManager.CreateAsync(userClient, "Password123$");
                    await userManager.AddToRoleAsync(userClient,CustomRoles.CLIENT);
                }

                //forma para llamar el modelo que no esta inicializado
                // en Application DbContext
                var cursos = await context.Cursos!.Take(10).Skip(0).ToListAsync();
                if (!context.Set<CursoInstructor>().Any())
                {
                    var instructores = await context.Instructores!.Take(10).Skip(0).ToListAsync();

                    foreach (var curso in cursos)
                    {
                        curso.Instructores = instructores;
                    }

                }

                if (!context.Set<CursoPrecio>().Any())
                {
                    var precios = await context.Precios.ToListAsync();

                    foreach (var curso in cursos)
                    {
                        curso.Precios = precios;
                    }
                }

                if (!context.Set<Calificacion>().Any())
                {
                    foreach (var curso in cursos)
                    {
                        var fakerCalificacion = new Faker<Calificacion>()
                            .RuleFor(x => x.Id, _ => Guid.NewGuid())
                            .RuleFor(x => x.Alumno, f => f.Name.FullName())
                            .RuleFor(x => x.Comentario, f => f.Commerce.ProductDescription())
                            .RuleFor(x => x.Puntaje, 5)
                            .RuleFor(x => x.CursoId, curso.Id);
                        var calificiones = fakerCalificacion.Generate(10);
                        context.AddRange(calificiones);
                    }
                }

                await context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<ApplicationDbContext>();
                logger.LogError(ex.Message);
            }
        }
    }
}
