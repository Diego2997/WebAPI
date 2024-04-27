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
    [Migration("20240427222154_MigracionSeguridad")]
    partial class MigracionSeguridad
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
                            Id = "f329e790-18c7-4bb3-ac38-ff99ef1ef65c",
                            Name = "ADMIN",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "bca41688-5562-42ce-93d4-2b3c926d998a",
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
                            RoleId = "f329e790-18c7-4bb3-ac38-ff99ef1ef65c"
                        },
                        new
                        {
                            Id = 2,
                            ClaimType = "POLICIES",
                            ClaimValue = "CURSO_UPDATE",
                            RoleId = "f329e790-18c7-4bb3-ac38-ff99ef1ef65c"
                        },
                        new
                        {
                            Id = 3,
                            ClaimType = "POLICIES",
                            ClaimValue = "CURSO_WRITE",
                            RoleId = "f329e790-18c7-4bb3-ac38-ff99ef1ef65c"
                        },
                        new
                        {
                            Id = 4,
                            ClaimType = "POLICIES",
                            ClaimValue = "CURSO_DELETE",
                            RoleId = "f329e790-18c7-4bb3-ac38-ff99ef1ef65c"
                        },
                        new
                        {
                            Id = 5,
                            ClaimType = "POLICIES",
                            ClaimValue = "INSTRUCTOR_CREATE",
                            RoleId = "f329e790-18c7-4bb3-ac38-ff99ef1ef65c"
                        },
                        new
                        {
                            Id = 6,
                            ClaimType = "POLICIES",
                            ClaimValue = "INSTRUCTOR_READ",
                            RoleId = "f329e790-18c7-4bb3-ac38-ff99ef1ef65c"
                        },
                        new
                        {
                            Id = 7,
                            ClaimType = "POLICIES",
                            ClaimValue = "INSTRUCTOR_UPDATE",
                            RoleId = "f329e790-18c7-4bb3-ac38-ff99ef1ef65c"
                        },
                        new
                        {
                            Id = 8,
                            ClaimType = "POLICIES",
                            ClaimValue = "COMENTARIO_READ",
                            RoleId = "f329e790-18c7-4bb3-ac38-ff99ef1ef65c"
                        },
                        new
                        {
                            Id = 9,
                            ClaimType = "POLICIES",
                            ClaimValue = "COMENTARIO_DELETE",
                            RoleId = "f329e790-18c7-4bb3-ac38-ff99ef1ef65c"
                        },
                        new
                        {
                            Id = 10,
                            ClaimType = "POLICIES",
                            ClaimValue = "COMENTARIO_CREATE",
                            RoleId = "f329e790-18c7-4bb3-ac38-ff99ef1ef65c"
                        },
                        new
                        {
                            Id = 11,
                            ClaimType = "POLICIES",
                            ClaimValue = "CURSO_READ",
                            RoleId = "bca41688-5562-42ce-93d4-2b3c926d998a"
                        },
                        new
                        {
                            Id = 12,
                            ClaimType = "POLICIES",
                            ClaimValue = "INSTRUCTOR_READ",
                            RoleId = "bca41688-5562-42ce-93d4-2b3c926d998a"
                        },
                        new
                        {
                            Id = 13,
                            ClaimType = "POLICIES",
                            ClaimValue = "COMENTARIO_READ",
                            RoleId = "bca41688-5562-42ce-93d4-2b3c926d998a"
                        },
                        new
                        {
                            Id = 14,
                            ClaimType = "POLICIES",
                            ClaimValue = "COMENTARIO_CREATE",
                            RoleId = "bca41688-5562-42ce-93d4-2b3c926d998a"
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
                            Id = new Guid("e09dc59b-ec35-4d06-a895-9f3740a0c3c3"),
                            Descripcion = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            FechaPublicacion = new DateTime(2024, 4, 27, 22, 21, 53, 659, DateTimeKind.Utc).AddTicks(4040),
                            Titulo = "Handmade Frozen Bike"
                        },
                        new
                        {
                            Id = new Guid("a7f5e2c5-62d1-40af-985d-9211d4e7da61"),
                            Descripcion = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
                            FechaPublicacion = new DateTime(2024, 4, 27, 22, 21, 53, 659, DateTimeKind.Utc).AddTicks(4066),
                            Titulo = "Rustic Granite Car"
                        },
                        new
                        {
                            Id = new Guid("5d304c0d-316f-474b-9e7a-4293ddaf2185"),
                            Descripcion = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            FechaPublicacion = new DateTime(2024, 4, 27, 22, 21, 53, 659, DateTimeKind.Utc).AddTicks(4093),
                            Titulo = "Small Concrete Gloves"
                        },
                        new
                        {
                            Id = new Guid("8202c941-ad02-4603-93e6-5a05646cc0f3"),
                            Descripcion = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",
                            FechaPublicacion = new DateTime(2024, 4, 27, 22, 21, 53, 659, DateTimeKind.Utc).AddTicks(4109),
                            Titulo = "Handmade Rubber Chair"
                        },
                        new
                        {
                            Id = new Guid("0ff4e256-7b34-4955-9276-5a674f00a195"),
                            Descripcion = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            FechaPublicacion = new DateTime(2024, 4, 27, 22, 21, 53, 659, DateTimeKind.Utc).AddTicks(4129),
                            Titulo = "Practical Granite Chicken"
                        },
                        new
                        {
                            Id = new Guid("60d7704c-b557-408e-9d7f-4d539951743b"),
                            Descripcion = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            FechaPublicacion = new DateTime(2024, 4, 27, 22, 21, 53, 659, DateTimeKind.Utc).AddTicks(4146),
                            Titulo = "Awesome Metal Table"
                        },
                        new
                        {
                            Id = new Guid("8ce73704-49e1-4ed0-bad5-d6ca506f156a"),
                            Descripcion = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",
                            FechaPublicacion = new DateTime(2024, 4, 27, 22, 21, 53, 659, DateTimeKind.Utc).AddTicks(4164),
                            Titulo = "Incredible Wooden Cheese"
                        },
                        new
                        {
                            Id = new Guid("f74fcc58-f98d-45e4-85d4-ea9c24d8c3a0"),
                            Descripcion = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            FechaPublicacion = new DateTime(2024, 4, 27, 22, 21, 53, 659, DateTimeKind.Utc).AddTicks(4180),
                            Titulo = "Unbranded Wooden Chair"
                        },
                        new
                        {
                            Id = new Guid("ffe34f44-1e1a-48bc-b122-f050e7a54f20"),
                            Descripcion = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",
                            FechaPublicacion = new DateTime(2024, 4, 27, 22, 21, 53, 659, DateTimeKind.Utc).AddTicks(4200),
                            Titulo = "Practical Rubber Computer"
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
                            Id = new Guid("44dac8a1-b469-4d97-9033-d3dca137a5e9"),
                            Apellidos = "Vandervort",
                            Grado = "Legacy Data Manager",
                            Nombre = "Leda"
                        },
                        new
                        {
                            Id = new Guid("53463b71-d084-4b97-8e06-d7718b487982"),
                            Apellidos = "Grant",
                            Grado = "Dynamic Response Designer",
                            Nombre = "Candelario"
                        },
                        new
                        {
                            Id = new Guid("16bcbf8d-f3f3-45a7-90ce-600fbddf2978"),
                            Apellidos = "O'Hara",
                            Grado = "Chief Web Orchestrator",
                            Nombre = "Lauryn"
                        },
                        new
                        {
                            Id = new Guid("462d9748-9a92-4150-9835-5315b43cf274"),
                            Apellidos = "Maggio",
                            Grado = "Corporate Markets Director",
                            Nombre = "Nyasia"
                        },
                        new
                        {
                            Id = new Guid("50392920-1f15-46da-a546-8d6697fe6d77"),
                            Apellidos = "Roberts",
                            Grado = "Regional Usability Assistant",
                            Nombre = "Bulah"
                        },
                        new
                        {
                            Id = new Guid("368f4136-08b9-4893-b1e4-79f911da7415"),
                            Apellidos = "Vandervort",
                            Grado = "Future Identity Architect",
                            Nombre = "Queenie"
                        },
                        new
                        {
                            Id = new Guid("3c5c98c1-a2cf-4621-a4fa-98f00975c0d5"),
                            Apellidos = "Kulas",
                            Grado = "Senior Response Officer",
                            Nombre = "Ron"
                        },
                        new
                        {
                            Id = new Guid("dedc9892-1b90-4299-8be6-6ac742bbafd6"),
                            Apellidos = "Schultz",
                            Grado = "District Usability Designer",
                            Nombre = "Mathias"
                        },
                        new
                        {
                            Id = new Guid("c0844c95-48f6-4e7f-b5d7-443db29e2564"),
                            Apellidos = "Bruen",
                            Grado = "Dynamic Markets Facilitator",
                            Nombre = "Amiya"
                        },
                        new
                        {
                            Id = new Guid("ad61f0a9-d51a-4d26-b235-9857e0b5a40b"),
                            Apellidos = "Rice",
                            Grado = "Future Configuration Administrator",
                            Nombre = "Brenna"
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
                            Id = new Guid("a8cc8b79-16f3-44a6-be84-86e52b777abc"),
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
