using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAPI.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class MigracionInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cursos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaPublicacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cursos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "instructores",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Grado = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_instructores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "precios",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "VARCHAR(250)", maxLength: 250, nullable: true),
                    PrecioActual = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    PrecioPromocion = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_precios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "calificaciones",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Alumno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Puntaje = table.Column<int>(type: "int", nullable: false),
                    Comentario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CursoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_calificaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_calificaciones_cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "imagenes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CursoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_imagenes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_imagenes_cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cursos_instructores",
                columns: table => new
                {
                    CursoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InstructorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cursos_instructores", x => new { x.InstructorId, x.CursoId });
                    table.ForeignKey(
                        name: "FK_cursos_instructores_cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cursos_instructores_instructores_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "instructores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cursos_precios",
                columns: table => new
                {
                    CursoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PrecioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cursos_precios", x => new { x.PrecioId, x.CursoId });
                    table.ForeignKey(
                        name: "FK_cursos_precios_cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cursos_precios_precios_PrecioId",
                        column: x => x.PrecioId,
                        principalTable: "precios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "cursos",
                columns: new[] { "Id", "Descripcion", "FechaPublicacion", "Titulo" },
                values: new object[,]
                {
                    { new Guid("01a86c75-5e4a-47ab-8695-913fadee17fb"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new DateTime(2024, 4, 26, 23, 25, 37, 831, DateTimeKind.Utc).AddTicks(1234), "Practical Cotton Shirt" },
                    { new Guid("0f41dbd4-32ca-4828-9060-2670ba567dc3"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new DateTime(2024, 4, 26, 23, 25, 37, 831, DateTimeKind.Utc).AddTicks(1215), "Ergonomic Frozen Towels" },
                    { new Guid("3210950c-b624-40b6-a21b-9295678b68b4"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new DateTime(2024, 4, 26, 23, 25, 37, 831, DateTimeKind.Utc).AddTicks(1326), "Ergonomic Frozen Tuna" },
                    { new Guid("3a8ab74b-15bf-41b0-a5aa-3d5ee242d356"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new DateTime(2024, 4, 26, 23, 25, 37, 831, DateTimeKind.Utc).AddTicks(1288), "Practical Wooden Soap" },
                    { new Guid("3cb36900-8db7-45dd-9bd3-ea7b9ab09c35"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new DateTime(2024, 4, 26, 23, 25, 37, 831, DateTimeKind.Utc).AddTicks(1360), "Sleek Soft Shirt" },
                    { new Guid("74dfabca-eb45-4acc-a23e-bd2e1045f557"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new DateTime(2024, 4, 26, 23, 25, 37, 831, DateTimeKind.Utc).AddTicks(1254), "Refined Soft Towels" },
                    { new Guid("781f5eae-3f9e-4d20-a5de-5bb726bc0eab"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new DateTime(2024, 4, 26, 23, 25, 37, 831, DateTimeKind.Utc).AddTicks(1271), "Unbranded Wooden Mouse" },
                    { new Guid("b66ad4bf-20f0-4fbc-8d3b-ccc670ec8e20"), "The Football Is Good For Training And Recreational Purposes", new DateTime(2024, 4, 26, 23, 25, 37, 831, DateTimeKind.Utc).AddTicks(1344), "Fantastic Concrete Gloves" },
                    { new Guid("ec099243-4c06-43ea-ade2-fc5305b0ad7c"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new DateTime(2024, 4, 26, 23, 25, 37, 831, DateTimeKind.Utc).AddTicks(1192), "Unbranded Steel Table" }
                });

            migrationBuilder.InsertData(
                table: "instructores",
                columns: new[] { "Id", "Apellidos", "Grado", "Nombre" },
                values: new object[,]
                {
                    { new Guid("087e0256-4e1f-4352-8de9-50bc6ef83bc6"), "Hessel", "Dynamic Identity Orchestrator", "Lavern" },
                    { new Guid("2dc71dc5-745c-4165-8686-d1a27ac7d800"), "Watsica", "Lead Branding Architect", "Salvatore" },
                    { new Guid("52323171-e60f-4a57-877c-eb08047648cc"), "Witting", "District Integration Producer", "Katrina" },
                    { new Guid("66745964-313e-4cbe-9c9c-f513c4bc58b8"), "Wehner", "Direct Implementation Coordinator", "Isadore" },
                    { new Guid("a8f3f0fe-e40f-4a33-a365-a3351bb50db9"), "Dooley", "Global Configuration Developer", "Orie" },
                    { new Guid("cd9b0746-98d1-4dac-a2e6-b27f287e752d"), "Lueilwitz", "District Accounts Assistant", "Leatha" },
                    { new Guid("ce0ef028-2bf9-4e41-9263-7edfefacd874"), "Franecki", "Customer Web Administrator", "Ulises" },
                    { new Guid("cf0b978b-bdef-4243-b984-65a3f09eaf55"), "Windler", "Product Usability Engineer", "Catharine" },
                    { new Guid("d2ea00d6-149a-441b-82d8-51cf2c8d52be"), "Konopelski", "Human Operations Strategist", "Nona" },
                    { new Guid("fc700844-d0dc-479e-92ee-0dde90eaf962"), "Wisozk", "Central Solutions Strategist", "Elliott" }
                });

            migrationBuilder.InsertData(
                table: "precios",
                columns: new[] { "Id", "Nombre", "PrecioActual", "PrecioPromocion" },
                values: new object[] { new Guid("e742b3c4-0e54-4f81-9929-c3dd3a8dfbff"), "Precio Regular", 10.0m, 8.0m });

            migrationBuilder.CreateIndex(
                name: "IX_calificaciones_CursoId",
                table: "calificaciones",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_cursos_instructores_CursoId",
                table: "cursos_instructores",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_cursos_precios_CursoId",
                table: "cursos_precios",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_imagenes_CursoId",
                table: "imagenes",
                column: "CursoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "calificaciones");

            migrationBuilder.DropTable(
                name: "cursos_instructores");

            migrationBuilder.DropTable(
                name: "cursos_precios");

            migrationBuilder.DropTable(
                name: "imagenes");

            migrationBuilder.DropTable(
                name: "instructores");

            migrationBuilder.DropTable(
                name: "precios");

            migrationBuilder.DropTable(
                name: "cursos");
        }
    }
}
