﻿using Bogus;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Domain;

namespace WebAPI.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Curso>? Cursos { get; set; }
        public DbSet<Instructor>? Instructores { get; set; }
        public DbSet<Precio> Precios { get; set; }
        public DbSet<Calificacion> Calificaciones { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LocalDataBase.db")
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


            modelBuilder.Entity<Curso>().HasData(DataMaster().Item1);
            modelBuilder.Entity<Precio>().HasData(DataMaster().Item2);
            modelBuilder.Entity<Instructor>().HasData(DataMaster().Item3);
        }

        public Tuple<Curso[], Precio[], Instructor[]> DataMaster()
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
                ,precios.ToArray()
                ,instructores.ToArray());
        }
    }
}
