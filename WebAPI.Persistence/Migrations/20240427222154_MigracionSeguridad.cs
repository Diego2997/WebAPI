using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAPI.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class MigracionSeguridad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("01a86c75-5e4a-47ab-8695-913fadee17fb"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("0f41dbd4-32ca-4828-9060-2670ba567dc3"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("3210950c-b624-40b6-a21b-9295678b68b4"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("3a8ab74b-15bf-41b0-a5aa-3d5ee242d356"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("3cb36900-8db7-45dd-9bd3-ea7b9ab09c35"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("74dfabca-eb45-4acc-a23e-bd2e1045f557"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("781f5eae-3f9e-4d20-a5de-5bb726bc0eab"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("b66ad4bf-20f0-4fbc-8d3b-ccc670ec8e20"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("ec099243-4c06-43ea-ade2-fc5305b0ad7c"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("087e0256-4e1f-4352-8de9-50bc6ef83bc6"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("2dc71dc5-745c-4165-8686-d1a27ac7d800"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("52323171-e60f-4a57-877c-eb08047648cc"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("66745964-313e-4cbe-9c9c-f513c4bc58b8"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("a8f3f0fe-e40f-4a33-a365-a3351bb50db9"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("cd9b0746-98d1-4dac-a2e6-b27f287e752d"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("ce0ef028-2bf9-4e41-9263-7edfefacd874"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("cf0b978b-bdef-4243-b984-65a3f09eaf55"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("d2ea00d6-149a-441b-82d8-51cf2c8d52be"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("fc700844-d0dc-479e-92ee-0dde90eaf962"));

            migrationBuilder.DeleteData(
                table: "precios",
                keyColumn: "Id",
                keyValue: new Guid("e742b3c4-0e54-4f81-9929-c3dd3a8dfbff"));

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NombreCompleto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Carrera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "bca41688-5562-42ce-93d4-2b3c926d998a", null, "CLIENT", "CLIENT" },
                    { "f329e790-18c7-4bb3-ac38-ff99ef1ef65c", null, "ADMIN", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "cursos",
                columns: new[] { "Id", "Descripcion", "FechaPublicacion", "Titulo" },
                values: new object[,]
                {
                    { new Guid("0ff4e256-7b34-4955-9276-5a674f00a195"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new DateTime(2024, 4, 27, 22, 21, 53, 659, DateTimeKind.Utc).AddTicks(4129), "Practical Granite Chicken" },
                    { new Guid("5d304c0d-316f-474b-9e7a-4293ddaf2185"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new DateTime(2024, 4, 27, 22, 21, 53, 659, DateTimeKind.Utc).AddTicks(4093), "Small Concrete Gloves" },
                    { new Guid("60d7704c-b557-408e-9d7f-4d539951743b"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new DateTime(2024, 4, 27, 22, 21, 53, 659, DateTimeKind.Utc).AddTicks(4146), "Awesome Metal Table" },
                    { new Guid("8202c941-ad02-4603-93e6-5a05646cc0f3"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new DateTime(2024, 4, 27, 22, 21, 53, 659, DateTimeKind.Utc).AddTicks(4109), "Handmade Rubber Chair" },
                    { new Guid("8ce73704-49e1-4ed0-bad5-d6ca506f156a"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new DateTime(2024, 4, 27, 22, 21, 53, 659, DateTimeKind.Utc).AddTicks(4164), "Incredible Wooden Cheese" },
                    { new Guid("a7f5e2c5-62d1-40af-985d-9211d4e7da61"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new DateTime(2024, 4, 27, 22, 21, 53, 659, DateTimeKind.Utc).AddTicks(4066), "Rustic Granite Car" },
                    { new Guid("e09dc59b-ec35-4d06-a895-9f3740a0c3c3"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new DateTime(2024, 4, 27, 22, 21, 53, 659, DateTimeKind.Utc).AddTicks(4040), "Handmade Frozen Bike" },
                    { new Guid("f74fcc58-f98d-45e4-85d4-ea9c24d8c3a0"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new DateTime(2024, 4, 27, 22, 21, 53, 659, DateTimeKind.Utc).AddTicks(4180), "Unbranded Wooden Chair" },
                    { new Guid("ffe34f44-1e1a-48bc-b122-f050e7a54f20"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new DateTime(2024, 4, 27, 22, 21, 53, 659, DateTimeKind.Utc).AddTicks(4200), "Practical Rubber Computer" }
                });

            migrationBuilder.InsertData(
                table: "instructores",
                columns: new[] { "Id", "Apellidos", "Grado", "Nombre" },
                values: new object[,]
                {
                    { new Guid("16bcbf8d-f3f3-45a7-90ce-600fbddf2978"), "O'Hara", "Chief Web Orchestrator", "Lauryn" },
                    { new Guid("368f4136-08b9-4893-b1e4-79f911da7415"), "Vandervort", "Future Identity Architect", "Queenie" },
                    { new Guid("3c5c98c1-a2cf-4621-a4fa-98f00975c0d5"), "Kulas", "Senior Response Officer", "Ron" },
                    { new Guid("44dac8a1-b469-4d97-9033-d3dca137a5e9"), "Vandervort", "Legacy Data Manager", "Leda" },
                    { new Guid("462d9748-9a92-4150-9835-5315b43cf274"), "Maggio", "Corporate Markets Director", "Nyasia" },
                    { new Guid("50392920-1f15-46da-a546-8d6697fe6d77"), "Roberts", "Regional Usability Assistant", "Bulah" },
                    { new Guid("53463b71-d084-4b97-8e06-d7718b487982"), "Grant", "Dynamic Response Designer", "Candelario" },
                    { new Guid("ad61f0a9-d51a-4d26-b235-9857e0b5a40b"), "Rice", "Future Configuration Administrator", "Brenna" },
                    { new Guid("c0844c95-48f6-4e7f-b5d7-443db29e2564"), "Bruen", "Dynamic Markets Facilitator", "Amiya" },
                    { new Guid("dedc9892-1b90-4299-8be6-6ac742bbafd6"), "Schultz", "District Usability Designer", "Mathias" }
                });

            migrationBuilder.InsertData(
                table: "precios",
                columns: new[] { "Id", "Nombre", "PrecioActual", "PrecioPromocion" },
                values: new object[] { new Guid("a8cc8b79-16f3-44a6-be84-86e52b777abc"), "Precio Regular", 10.0m, 8.0m });

            migrationBuilder.InsertData(
                table: "AspNetRoleClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "RoleId" },
                values: new object[,]
                {
                    { 1, "POLICIES", "CURSO_READ", "f329e790-18c7-4bb3-ac38-ff99ef1ef65c" },
                    { 2, "POLICIES", "CURSO_UPDATE", "f329e790-18c7-4bb3-ac38-ff99ef1ef65c" },
                    { 3, "POLICIES", "CURSO_WRITE", "f329e790-18c7-4bb3-ac38-ff99ef1ef65c" },
                    { 4, "POLICIES", "CURSO_DELETE", "f329e790-18c7-4bb3-ac38-ff99ef1ef65c" },
                    { 5, "POLICIES", "INSTRUCTOR_CREATE", "f329e790-18c7-4bb3-ac38-ff99ef1ef65c" },
                    { 6, "POLICIES", "INSTRUCTOR_READ", "f329e790-18c7-4bb3-ac38-ff99ef1ef65c" },
                    { 7, "POLICIES", "INSTRUCTOR_UPDATE", "f329e790-18c7-4bb3-ac38-ff99ef1ef65c" },
                    { 8, "POLICIES", "COMENTARIO_READ", "f329e790-18c7-4bb3-ac38-ff99ef1ef65c" },
                    { 9, "POLICIES", "COMENTARIO_DELETE", "f329e790-18c7-4bb3-ac38-ff99ef1ef65c" },
                    { 10, "POLICIES", "COMENTARIO_CREATE", "f329e790-18c7-4bb3-ac38-ff99ef1ef65c" },
                    { 11, "POLICIES", "CURSO_READ", "bca41688-5562-42ce-93d4-2b3c926d998a" },
                    { 12, "POLICIES", "INSTRUCTOR_READ", "bca41688-5562-42ce-93d4-2b3c926d998a" },
                    { 13, "POLICIES", "COMENTARIO_READ", "bca41688-5562-42ce-93d4-2b3c926d998a" },
                    { 14, "POLICIES", "COMENTARIO_CREATE", "bca41688-5562-42ce-93d4-2b3c926d998a" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("0ff4e256-7b34-4955-9276-5a674f00a195"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("5d304c0d-316f-474b-9e7a-4293ddaf2185"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("60d7704c-b557-408e-9d7f-4d539951743b"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("8202c941-ad02-4603-93e6-5a05646cc0f3"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("8ce73704-49e1-4ed0-bad5-d6ca506f156a"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("a7f5e2c5-62d1-40af-985d-9211d4e7da61"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("e09dc59b-ec35-4d06-a895-9f3740a0c3c3"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("f74fcc58-f98d-45e4-85d4-ea9c24d8c3a0"));

            migrationBuilder.DeleteData(
                table: "cursos",
                keyColumn: "Id",
                keyValue: new Guid("ffe34f44-1e1a-48bc-b122-f050e7a54f20"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("16bcbf8d-f3f3-45a7-90ce-600fbddf2978"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("368f4136-08b9-4893-b1e4-79f911da7415"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("3c5c98c1-a2cf-4621-a4fa-98f00975c0d5"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("44dac8a1-b469-4d97-9033-d3dca137a5e9"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("462d9748-9a92-4150-9835-5315b43cf274"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("50392920-1f15-46da-a546-8d6697fe6d77"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("53463b71-d084-4b97-8e06-d7718b487982"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("ad61f0a9-d51a-4d26-b235-9857e0b5a40b"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("c0844c95-48f6-4e7f-b5d7-443db29e2564"));

            migrationBuilder.DeleteData(
                table: "instructores",
                keyColumn: "Id",
                keyValue: new Guid("dedc9892-1b90-4299-8be6-6ac742bbafd6"));

            migrationBuilder.DeleteData(
                table: "precios",
                keyColumn: "Id",
                keyValue: new Guid("a8cc8b79-16f3-44a6-be84-86e52b777abc"));

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
        }
    }
}
