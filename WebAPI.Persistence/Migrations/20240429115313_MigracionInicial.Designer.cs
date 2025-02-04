﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPI.Persistence;

#nullable disable

namespace WebAPI.Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240429115313_MigracionInicial")]
    partial class MigracionInicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "5f47026f-93dc-42bc-a92c-1539eb0b9ace",
                            Name = "ADMIN",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "a57eaf92-bef4-4956-8f80-d5c39b2e4ab1",
                            Name = "CLIENT",
                            NormalizedName = "CLIENT"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClaimType = "POLICIES",
                            ClaimValue = "CURSO_READ",
                            RoleId = "5f47026f-93dc-42bc-a92c-1539eb0b9ace"
                        },
                        new
                        {
                            Id = 2,
                            ClaimType = "POLICIES",
                            ClaimValue = "CURSO_UPDATE",
                            RoleId = "5f47026f-93dc-42bc-a92c-1539eb0b9ace"
                        },
                        new
                        {
                            Id = 3,
                            ClaimType = "POLICIES",
                            ClaimValue = "CURSO_WRITE",
                            RoleId = "5f47026f-93dc-42bc-a92c-1539eb0b9ace"
                        },
                        new
                        {
                            Id = 4,
                            ClaimType = "POLICIES",
                            ClaimValue = "CURSO_DELETE",
                            RoleId = "5f47026f-93dc-42bc-a92c-1539eb0b9ace"
                        },
                        new
                        {
                            Id = 5,
                            ClaimType = "POLICIES",
                            ClaimValue = "INSTRUCTOR_CREATE",
                            RoleId = "5f47026f-93dc-42bc-a92c-1539eb0b9ace"
                        },
                        new
                        {
                            Id = 6,
                            ClaimType = "POLICIES",
                            ClaimValue = "INSTRUCTOR_READ",
                            RoleId = "5f47026f-93dc-42bc-a92c-1539eb0b9ace"
                        },
                        new
                        {
                            Id = 7,
                            ClaimType = "POLICIES",
                            ClaimValue = "INSTRUCTOR_UPDATE",
                            RoleId = "5f47026f-93dc-42bc-a92c-1539eb0b9ace"
                        },
                        new
                        {
                            Id = 8,
                            ClaimType = "POLICIES",
                            ClaimValue = "COMENTARIO_READ",
                            RoleId = "5f47026f-93dc-42bc-a92c-1539eb0b9ace"
                        },
                        new
                        {
                            Id = 9,
                            ClaimType = "POLICIES",
                            ClaimValue = "COMENTARIO_DELETE",
                            RoleId = "5f47026f-93dc-42bc-a92c-1539eb0b9ace"
                        },
                        new
                        {
                            Id = 10,
                            ClaimType = "POLICIES",
                            ClaimValue = "COMENTARIO_CREATE",
                            RoleId = "5f47026f-93dc-42bc-a92c-1539eb0b9ace"
                        },
                        new
                        {
                            Id = 11,
                            ClaimType = "POLICIES",
                            ClaimValue = "CURSO_READ",
                            RoleId = "a57eaf92-bef4-4956-8f80-d5c39b2e4ab1"
                        },
                        new
                        {
                            Id = 12,
                            ClaimType = "POLICIES",
                            ClaimValue = "INSTRUCTOR_READ",
                            RoleId = "a57eaf92-bef4-4956-8f80-d5c39b2e4ab1"
                        },
                        new
                        {
                            Id = 13,
                            ClaimType = "POLICIES",
                            ClaimValue = "COMENTARIO_READ",
                            RoleId = "a57eaf92-bef4-4956-8f80-d5c39b2e4ab1"
                        },
                        new
                        {
                            Id = 14,
                            ClaimType = "POLICIES",
                            ClaimValue = "COMENTARIO_CREATE",
                            RoleId = "a57eaf92-bef4-4956-8f80-d5c39b2e4ab1"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("WebAPI.Domain.Calificacion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Alumno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comentario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CursoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Puntaje")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CursoId");

                    b.ToTable("calificaciones", (string)null);
                });

            modelBuilder.Entity("WebAPI.Domain.Curso", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FechaPublicacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("cursos", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("e2c240ea-6c2b-4e6f-a94d-90a75d121714"),
                            Descripcion = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
                            FechaPublicacion = new DateTime(2024, 4, 29, 11, 53, 13, 74, DateTimeKind.Utc).AddTicks(6567),
                            Titulo = "Awesome Cotton Cheese"
                        },
                        new
                        {
                            Id = new Guid("1d419b7a-a26a-45bc-9118-b7165e53a435"),
                            Descripcion = "The Football Is Good For Training And Recreational Purposes",
                            FechaPublicacion = new DateTime(2024, 4, 29, 11, 53, 13, 74, DateTimeKind.Utc).AddTicks(6643),
                            Titulo = "Rustic Fresh Sausages"
                        },
                        new
                        {
                            Id = new Guid("2f23ce72-a33a-4f9b-b74e-97872cd0f81c"),
                            Descripcion = "The Football Is Good For Training And Recreational Purposes",
                            FechaPublicacion = new DateTime(2024, 4, 29, 11, 53, 13, 74, DateTimeKind.Utc).AddTicks(6659),
                            Titulo = "Sleek Granite Sausages"
                        },
                        new
                        {
                            Id = new Guid("b2914511-98be-4261-b926-381742e3dcd7"),
                            Descripcion = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            FechaPublicacion = new DateTime(2024, 4, 29, 11, 53, 13, 74, DateTimeKind.Utc).AddTicks(6678),
                            Titulo = "Licensed Metal Keyboard"
                        },
                        new
                        {
                            Id = new Guid("69d25b49-3318-4b63-a90e-baf7bdc18615"),
                            Descripcion = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            FechaPublicacion = new DateTime(2024, 4, 29, 11, 53, 13, 74, DateTimeKind.Utc).AddTicks(6693),
                            Titulo = "Fantastic Cotton Tuna"
                        },
                        new
                        {
                            Id = new Guid("c684c1ee-07d6-4426-bdfc-58c53a53e7d1"),
                            Descripcion = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            FechaPublicacion = new DateTime(2024, 4, 29, 11, 53, 13, 74, DateTimeKind.Utc).AddTicks(6730),
                            Titulo = "Practical Plastic Soap"
                        },
                        new
                        {
                            Id = new Guid("88851365-dc8b-4b96-ada7-edf9319d7444"),
                            Descripcion = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            FechaPublicacion = new DateTime(2024, 4, 29, 11, 53, 13, 74, DateTimeKind.Utc).AddTicks(6744),
                            Titulo = "Practical Granite Pizza"
                        },
                        new
                        {
                            Id = new Guid("bef9637e-bcad-4ee5-a5dc-afd1e3d24a31"),
                            Descripcion = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            FechaPublicacion = new DateTime(2024, 4, 29, 11, 53, 13, 74, DateTimeKind.Utc).AddTicks(6761),
                            Titulo = "Tasty Wooden Bike"
                        },
                        new
                        {
                            Id = new Guid("f603e1a1-ff56-4dee-a09e-2b904783f695"),
                            Descripcion = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            FechaPublicacion = new DateTime(2024, 4, 29, 11, 53, 13, 74, DateTimeKind.Utc).AddTicks(6777),
                            Titulo = "Tasty Plastic Chair"
                        });
                });

            modelBuilder.Entity("WebAPI.Domain.CursoInstructor", b =>
                {
                    b.Property<Guid?>("InstructorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CursoId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("InstructorId", "CursoId");

                    b.HasIndex("CursoId");

                    b.ToTable("cursos_instructores", (string)null);
                });

            modelBuilder.Entity("WebAPI.Domain.CursoPrecio", b =>
                {
                    b.Property<Guid?>("PrecioId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CursoId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PrecioId", "CursoId");

                    b.HasIndex("CursoId");

                    b.ToTable("cursos_precios", (string)null);
                });

            modelBuilder.Entity("WebAPI.Domain.Foto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CursoId")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CursoId");

                    b.ToTable("imagenes", (string)null);
                });

            modelBuilder.Entity("WebAPI.Domain.Instructor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Grado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("instructores", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("ec7464ed-32fc-45ba-bfb4-b4c381988c2b"),
                            Apellidos = "Konopelski",
                            Grado = "National Implementation Producer",
                            Nombre = "Nels"
                        },
                        new
                        {
                            Id = new Guid("257a348c-7e46-48d3-a76a-b75633ee4258"),
                            Apellidos = "Will",
                            Grado = "Future Tactics Strategist",
                            Nombre = "Icie"
                        },
                        new
                        {
                            Id = new Guid("25fe1faa-d07f-4a18-a02d-38483e5435b4"),
                            Apellidos = "Considine",
                            Grado = "Customer Marketing Officer",
                            Nombre = "Brett"
                        },
                        new
                        {
                            Id = new Guid("6593bab9-80ca-4c55-9504-b1918763cd28"),
                            Apellidos = "Douglas",
                            Grado = "Regional Implementation Engineer",
                            Nombre = "Grady"
                        },
                        new
                        {
                            Id = new Guid("038f2a83-5180-47f2-af8a-80e7a50e62f1"),
                            Apellidos = "Zboncak",
                            Grado = "Direct Optimization Consultant",
                            Nombre = "Twila"
                        },
                        new
                        {
                            Id = new Guid("2e886301-0fcc-4851-a826-c9090620fb66"),
                            Apellidos = "Hackett",
                            Grado = "Investor Functionality Technician",
                            Nombre = "Tavares"
                        },
                        new
                        {
                            Id = new Guid("4dd7a0e0-c7c9-40fb-99d5-921593a9d09d"),
                            Apellidos = "Von",
                            Grado = "Central Applications Liaison",
                            Nombre = "Broderick"
                        },
                        new
                        {
                            Id = new Guid("485a153c-95c4-485c-9db5-ac27890b4d2e"),
                            Apellidos = "Marvin",
                            Grado = "Direct Optimization Orchestrator",
                            Nombre = "Kayla"
                        },
                        new
                        {
                            Id = new Guid("59dae626-fc92-455a-b4c5-fd39d1b64417"),
                            Apellidos = "Bergnaum",
                            Grado = "Chief Program Representative",
                            Nombre = "Camden"
                        },
                        new
                        {
                            Id = new Guid("41c07424-e7c7-4c07-b7b0-3f2772c5ba2b"),
                            Apellidos = "Mann",
                            Grado = "Dynamic Web Coordinator",
                            Nombre = "Isabella"
                        });
                });

            modelBuilder.Entity("WebAPI.Domain.Precio", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nombre")
                        .HasMaxLength(250)
                        .HasColumnType("VARCHAR");

                    b.Property<decimal>("PrecioActual")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("PrecioPromocion")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.ToTable("precios", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("2911261a-2932-43ca-acca-3f9417ea0499"),
                            Nombre = "Precio Regular",
                            PrecioActual = 10.0m,
                            PrecioPromocion = 8.0m
                        });
                });

            modelBuilder.Entity("WebAPI.Persistence.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Carrera")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NombreCompleto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("WebAPI.Persistence.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("WebAPI.Persistence.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAPI.Persistence.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("WebAPI.Persistence.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebAPI.Domain.Calificacion", b =>
                {
                    b.HasOne("WebAPI.Domain.Curso", "Curso")
                        .WithMany("Calificaciones")
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Curso");
                });

            modelBuilder.Entity("WebAPI.Domain.CursoInstructor", b =>
                {
                    b.HasOne("WebAPI.Domain.Curso", "Curso")
                        .WithMany("CursoInstructores")
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAPI.Domain.Instructor", "Instructor")
                        .WithMany("CursoInstructores")
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Curso");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("WebAPI.Domain.CursoPrecio", b =>
                {
                    b.HasOne("WebAPI.Domain.Curso", "Curso")
                        .WithMany("CursoPrecios")
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAPI.Domain.Precio", "Precio")
                        .WithMany("CursoPrecios")
                        .HasForeignKey("PrecioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Curso");

                    b.Navigation("Precio");
                });

            modelBuilder.Entity("WebAPI.Domain.Foto", b =>
                {
                    b.HasOne("WebAPI.Domain.Curso", "Curso")
                        .WithMany("Fotos")
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Curso");
                });

            modelBuilder.Entity("WebAPI.Domain.Curso", b =>
                {
                    b.Navigation("Calificaciones");

                    b.Navigation("CursoInstructores");

                    b.Navigation("CursoPrecios");

                    b.Navigation("Fotos");
                });

            modelBuilder.Entity("WebAPI.Domain.Instructor", b =>
                {
                    b.Navigation("CursoInstructores");
                });

            modelBuilder.Entity("WebAPI.Domain.Precio", b =>
                {
                    b.Navigation("CursoPrecios");
                });
#pragma warning restore 612, 618
        }
    }
}
