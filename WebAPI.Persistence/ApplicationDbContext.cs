using Bogus;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Domain;
using WebAPI.Persistence.Models;

namespace WebAPI.Persistence
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {

        public DbSet<Curso>? Cursos { get; set; }
        public DbSet<Instructor>? Instructores { get; set; }
        public DbSet<Precio> Precios { get; set; }
        public DbSet<Calificacion> Calificaciones { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=dbclean;Integrated Security=True")
                .LogTo(Console.WriteLine,
                new[] { DbLoggerCategory.Database.Command.Name },
                Microsoft.Extensions.Logging.LogLevel.Information
                ).EnableSensitiveDataLogging();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Curso>().ToTable("cursos");
            modelBuilder.Entity<Instructor>().ToTable("instructores");
            modelBuilder.Entity<CursoInstructor>().ToTable("cursos_instructores");
            modelBuilder.Entity<Precio>().ToTable("precios");
            modelBuilder.Entity<CursoPrecio>().ToTable("cursos_precios");
            modelBuilder.Entity<Calificacion>().ToTable("calificaciones");
            modelBuilder.Entity<Foto>().ToTable("imagenes");

            modelBuilder.Entity<Precio>()
                .Property(x => x.PrecioPromocion)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Precio>()
                .Property(x => x.PrecioActual)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Precio>()
                .Property(x => x.Nombre)
                .HasColumnType("VARCHAR")
                .HasMaxLength(250);


            modelBuilder.Entity<Curso>()
                .HasMany(x => x.Fotos)
                .WithOne(x => x.Curso)
                .HasForeignKey(x => x.CursoId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Curso>()
                .HasMany(x => x.Calificaciones)
                .WithOne(x => x.Curso)
                .HasForeignKey(x => x.CursoId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Curso>()
                .HasMany(x => x.Precios)
                .WithMany(x => x.Cursos)
                .UsingEntity<CursoPrecio>(
                    j => j
                          .HasOne(p => p.Precio)
                          .WithMany(p => p.CursoPrecios)
                          .HasForeignKey(p => p.PrecioId),
                    j => j
                          .HasOne(p => p.Curso)
                          .WithMany(p => p.CursoPrecios)
                          .HasForeignKey(p => p.CursoId),
                    j =>
                    {
                        j.HasKey(x => new { x.PrecioId, x.CursoId });
                    }
                 );

            modelBuilder.Entity<Curso>()
                .HasMany(x => x.Instructores)
                .WithMany(x => x.Cursos)
                .UsingEntity<CursoInstructor>(
                    j => j
                           .HasOne(p => p.Instructor)
                           .WithMany(p => p.CursoInstructores)
                           .HasForeignKey(p => p.InstructorId),
                    j => j
                           .HasOne(p => p.Curso)
                           .WithMany(p => p.CursoInstructores)
                           .HasForeignKey(p => p.CursoId),
                    j =>
                    {
                        j.HasKey(t => new { t.InstructorId, t.CursoId });
                    }

                );


            modelBuilder.Entity<Curso>().HasData(CargarDataMaster().Item1);
            modelBuilder.Entity<Precio>().HasData(CargarDataMaster().Item2);
            modelBuilder.Entity<Instructor>().HasData(CargarDataMaster().Item3);


            CargarDataSeguridad(modelBuilder);
        }

        private void CargarDataSeguridad(ModelBuilder modelBuilder)
        {
            var admindId = Guid.NewGuid().ToString();
            var clientId = Guid.NewGuid().ToString();


            modelBuilder.Entity<IdentityRole>().HasData(
                 new IdentityRole
                 {
                     Id = admindId,
                     Name = CustomRoles.ADMIN,
                     NormalizedName = CustomRoles.ADMIN,
                 }
             );
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = clientId,
                    Name = CustomRoles.CLIENT,
                    NormalizedName = CustomRoles.CLIENT,
                }
               );

            modelBuilder.Entity<IdentityRoleClaim<string>>()
                .HasData(
                    new IdentityRoleClaim<string>
                    {
                        Id = 1,
                        ClaimType = CustomClaims.POLICIES,
                        ClaimValue = PolicyMaster.CURSO_READ,
                        RoleId = admindId
                    },
                    new IdentityRoleClaim<string>
                    {
                        Id = 2,
                        ClaimType = CustomClaims.POLICIES,
                        ClaimValue = PolicyMaster.CURSO_UPDATE,
                        RoleId = admindId
                    },
                    new IdentityRoleClaim<string>
                    {
                        Id = 3,
                        ClaimType = CustomClaims.POLICIES,
                        ClaimValue = PolicyMaster.CURSO_WRITE,
                        RoleId = admindId
                    },
                    new IdentityRoleClaim<string>
                    {
                        Id = 4,
                        ClaimType = CustomClaims.POLICIES,
                        ClaimValue = PolicyMaster.CURSO_DELETE,
                        RoleId = admindId
                    },
                    new IdentityRoleClaim<string>
                    {
                        Id = 5,
                        ClaimType = CustomClaims.POLICIES,
                        ClaimValue = PolicyMaster.INSTRUCTOR_CREATE,
                        RoleId = admindId
                    },
                    new IdentityRoleClaim<string>
                    {
                        Id = 6,
                        ClaimType = CustomClaims.POLICIES,
                        ClaimValue = PolicyMaster.INSTRUCTOR_READ,
                        RoleId = admindId
                    },
                    new IdentityRoleClaim<string>
                    {
                        Id = 7,
                        ClaimType = CustomClaims.POLICIES,
                        ClaimValue = PolicyMaster.INSTRUCTOR_UPDATE,
                        RoleId = admindId
                    },
                    new IdentityRoleClaim<string>
                    {
                        Id = 8,
                        ClaimType = CustomClaims.POLICIES,
                        ClaimValue = PolicyMaster.COMENTARIO_READ,
                        RoleId = admindId
                    },
                    new IdentityRoleClaim<string>
                    {
                        Id = 9,
                        ClaimType = CustomClaims.POLICIES,
                        ClaimValue = PolicyMaster.COMENTARIO_DELETE,
                        RoleId = admindId
                    },
                    new IdentityRoleClaim<string>
                    {
                        Id = 10,
                        ClaimType = CustomClaims.POLICIES,
                        ClaimValue = PolicyMaster.COMENTARIO_CREATE,
                        RoleId = admindId
                    },
                    new IdentityRoleClaim<string>
                    {
                        Id = 11,
                        ClaimType = CustomClaims.POLICIES,
                        ClaimValue = PolicyMaster.CURSO_READ,
                        RoleId = clientId
                    },
                    new IdentityRoleClaim<string>
                    {
                        Id = 12,
                        ClaimType = CustomClaims.POLICIES,
                        ClaimValue = PolicyMaster.INSTRUCTOR_READ,
                        RoleId = clientId
                    },
                    new IdentityRoleClaim<string>
                    {
                        Id = 13,
                        ClaimType = CustomClaims.POLICIES,
                        ClaimValue = PolicyMaster.COMENTARIO_READ,
                        RoleId = clientId
                    },
                    new IdentityRoleClaim<string>
                    {
                        Id = 14,
                        ClaimType = CustomClaims.POLICIES,
                        ClaimValue = PolicyMaster.COMENTARIO_CREATE,
                        RoleId = clientId
                    }

                );
        }

        private Tuple<Curso[], Precio[], Instructor[]> CargarDataMaster()
        {
            //Se crea arreglos porque solo recibe de ese tipo en OnModelCreating

            var cursos = new List<Curso>();
            var faker = new Faker();

            for (var i = 1; i < 10; i++)
            {
                var cursoId = Guid.NewGuid();
                cursos.Add(
                    new Curso
                    {
                        Id = cursoId,
                        Descripcion = faker.Commerce.ProductDescription(),
                        Titulo = faker.Commerce.ProductName(),
                        FechaPublicacion = DateTime.UtcNow
                    }
                 );
            }

            var precioId = Guid.NewGuid();
            var precio = new Precio
            {
                Id = precioId,
                PrecioActual = 10.0m,
                PrecioPromocion = 8.0m,
                Nombre = "Precio Regular"
            };
            var precios = new List<Precio>()
            {
                precio
            };



            var fakerInstructor = new Faker<Instructor>()
                .RuleFor(t => t.Id, _ => Guid.NewGuid())
                .RuleFor(t => t.Nombre, f => f.Name.FirstName())
                .RuleFor(t => t.Apellidos, f => f.Name.LastName())
                .RuleFor(t => t.Grado, f => f.Name.JobTitle());


            var instructores = fakerInstructor.Generate(10);
            return Tuple.Create(cursos.ToArray()
                , precios.ToArray()
                , instructores.ToArray());
        }
    }
}
