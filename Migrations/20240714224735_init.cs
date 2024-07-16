using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Deskbuddy.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Chief = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
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
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
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
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
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

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Workplaces",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpecialProperties = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workplaces", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Workplaces_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Occupancies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkplaceId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Occupancies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Occupancies_AspNetUsers_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Occupancies_Workplaces_WorkplaceId",
                        column: x => x.WorkplaceId,
                        principalTable: "Workplaces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "57c8a05d-6ca2-4fd0-b345-3ffc012aa679", null, "Abteilungsleiter", "ABTEILUNGSLEITER" },
                    { "5b08c06c-8aab-422a-bbb5-898ad7f76ba6", null, "Sekretariat", "SEKRETARIAT" },
                    { "696af5b0-898a-44da-85f4-fc1674f8df2a", null, "Mitarbeiter", "MITARBEITER" },
                    { "c19c4014-c8be-43a0-ad73-f63c87050feb", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1f6695ef-d669-48b4-b194-bd92d17057e0", 0, "0853fd04-b0f2-4a8a-8a90-21a745e12b95", null, false, false, null, null, "MITARBEITER@ABC.COM", "AQAAAAIAAYagAAAAEPN9OyopAGVGoGkzLWoPnJox64SQOGKR6CYay5coOMHubaZ6UQHGNk+W5iiKST/Q7Q==", null, false, "6773ea53-c040-4331-ac23-b31f4e058c4a", false, "mitarbeiter@abc.com" },
                    { "75b19fb1-7184-4a1e-bfaf-39d157353db2", 0, "d68a6a89-af57-49bc-be1f-3ece7ff223f1", null, false, false, null, null, "SEKRETARIAT@ABC.COM", "AQAAAAIAAYagAAAAEMyzqjs9+Vj20i8Qzd2DPYPRqM8pMx9wiLBlMoCeoxyap05aWIVGuvL6P6/1OBjNhA==", null, false, "5d7cb70c-a3ca-4220-8b4f-2eeee01fa800", false, "sekretariat@abc.com" },
                    { "902f1326-2d22-411a-8c06-6732ad46aff4", 0, "ca435d41-d414-483a-8d14-c86da4f1f33f", null, false, false, null, null, "ABTEILUNGSLEITER@ABC.COM", "AQAAAAIAAYagAAAAEN+EQMNwe/ghlOYVeZmNExS76hl1nJ6N7JcEINrafz4cDURFvS+dy84CHqkQ/XUhXA==", null, false, "e4fb2e88-b5fa-49eb-ab54-a880323d7ab4", false, "abteilungsleiter@abc.com" },
                    { "aa167027-4226-4341-bc45-fd9a0748f70a", 0, "f6f82f3d-5b20-4664-bc68-2355d58dc05e", null, false, false, null, null, "ADMIN@ABC.COM", "AQAAAAIAAYagAAAAEItOGYKl7XBRqKaRiqSd53YACHq1XUFvLLUoIdN6gcUbve2bTdczniSXV2m+Luyo2A==", null, false, "c737b869-03b4-4176-9f36-8d1534e9b2ce", false, "admin@abc.com" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Chief", "Name" },
                values: new object[,]
                {
                    { 1, "Anton Meier", "Finanzen" },
                    { 2, "Bernd Schmidt", "Einkauf" },
                    { 3, "Clara Fischer", "Verkauf" },
                    { 4, "Dieter Weber", "HR" },
                    { 5, "Eva Müller", "KundenSupport" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "696af5b0-898a-44da-85f4-fc1674f8df2a", "1f6695ef-d669-48b4-b194-bd92d17057e0" },
                    { "5b08c06c-8aab-422a-bbb5-898ad7f76ba6", "75b19fb1-7184-4a1e-bfaf-39d157353db2" },
                    { "57c8a05d-6ca2-4fd0-b345-3ffc012aa679", "902f1326-2d22-411a-8c06-6732ad46aff4" },
                    { "c19c4014-c8be-43a0-ad73-f63c87050feb", "aa167027-4226-4341-bc45-fd9a0748f70a" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DepartmentId", "Name" },
                values: new object[,]
                {
                    { 1, 4, "Heinz Schmidt" },
                    { 2, 1, "Eva Fischer" },
                    { 3, 5, "Greta Wagner" },
                    { 4, 2, "Dieter Weber" },
                    { 5, 2, "Ingrid Meier" },
                    { 6, 5, "Bernd Meier" },
                    { 7, 4, "Johann Becker" },
                    { 8, 1, "Eva Müller" },
                    { 9, 5, "Clara Weber" },
                    { 10, 4, "Heinz Koch" },
                    { 11, 1, "Friedrich Weber" },
                    { 12, 3, "Greta Richter" },
                    { 13, 3, "Anton Richter" },
                    { 14, 2, "Greta Meier" },
                    { 15, 5, "Heinz Schmidt" },
                    { 16, 4, "Dieter Müller" },
                    { 17, 1, "Eva Bauer" },
                    { 18, 2, "Dieter Weber" },
                    { 19, 3, "Dieter Fischer" },
                    { 20, 1, "Ingrid Richter" },
                    { 21, 1, "Clara Wagner" },
                    { 22, 3, "Eva Schmidt" },
                    { 23, 3, "Dieter Weber" },
                    { 24, 3, "Eva Fischer" },
                    { 25, 4, "Heinz Bauer" },
                    { 26, 4, "Clara Fischer" },
                    { 27, 3, "Dieter Richter" },
                    { 28, 2, "Johann Fischer" },
                    { 29, 1, "Friedrich Weber" },
                    { 30, 1, "Clara Bauer" },
                    { 31, 2, "Clara Meier" },
                    { 32, 1, "Greta Weber" },
                    { 33, 4, "Ingrid Schmidt" },
                    { 34, 3, "Greta Schmidt" },
                    { 35, 5, "Johann Schmidt" },
                    { 36, 4, "Greta Meier" },
                    { 37, 2, "Dieter Weber" },
                    { 38, 1, "Bernd Wagner" },
                    { 39, 2, "Johann Becker" },
                    { 40, 1, "Heinz Weber" },
                    { 41, 3, "Anton Becker" },
                    { 42, 2, "Greta Schmidt" },
                    { 43, 5, "Johann Meier" },
                    { 44, 5, "Eva Becker" },
                    { 45, 4, "Dieter Weber" },
                    { 46, 1, "Bernd Schmidt" },
                    { 47, 5, "Bernd Weber" },
                    { 48, 3, "Heinz Wagner" },
                    { 49, 2, "Friedrich Weber" },
                    { 50, 5, "Heinz Schmidt" },
                    { 51, 5, "Ingrid Koch" },
                    { 52, 2, "Dieter Koch" },
                    { 53, 5, "Bernd Weber" },
                    { 54, 4, "Ingrid Bauer" },
                    { 55, 2, "Ingrid Bauer" },
                    { 56, 1, "Dieter Becker" },
                    { 57, 1, "Bernd Wagner" },
                    { 58, 1, "Heinz Weber" },
                    { 59, 1, "Bernd Koch" },
                    { 60, 4, "Eva Becker" },
                    { 61, 3, "Anton Bauer" },
                    { 62, 5, "Bernd Schmidt" },
                    { 63, 1, "Eva Richter" },
                    { 64, 2, "Heinz Bauer" },
                    { 65, 5, "Friedrich Bauer" },
                    { 66, 2, "Heinz Schmidt" },
                    { 67, 4, "Clara Becker" },
                    { 68, 4, "Friedrich Koch" },
                    { 69, 2, "Johann Weber" },
                    { 70, 5, "Friedrich Schmidt" },
                    { 71, 3, "Bernd Müller" },
                    { 72, 3, "Heinz Müller" },
                    { 73, 1, "Bernd Wagner" },
                    { 74, 4, "Dieter Meier" },
                    { 75, 2, "Clara Wagner" },
                    { 76, 2, "Anton Bauer" },
                    { 77, 5, "Heinz Meier" },
                    { 78, 1, "Greta Weber" },
                    { 79, 1, "Greta Becker" },
                    { 80, 1, "Ingrid Bauer" },
                    { 81, 1, "Ingrid Schmidt" },
                    { 82, 3, "Dieter Richter" },
                    { 83, 4, "Johann Richter" },
                    { 84, 5, "Heinz Becker" },
                    { 85, 5, "Heinz Müller" },
                    { 86, 3, "Dieter Koch" },
                    { 87, 4, "Friedrich Fischer" },
                    { 88, 5, "Eva Wagner" },
                    { 89, 5, "Johann Fischer" },
                    { 90, 4, "Eva Müller" },
                    { 91, 3, "Ingrid Becker" },
                    { 92, 2, "Friedrich Weber" },
                    { 93, 4, "Clara Meier" },
                    { 94, 1, "Johann Becker" },
                    { 95, 3, "Johann Weber" },
                    { 96, 1, "Friedrich Fischer" },
                    { 97, 1, "Clara Koch" },
                    { 98, 3, "Anton Wagner" },
                    { 99, 3, "Dieter Schmidt" },
                    { 100, 3, "Ingrid Koch" },
                    { 101, 2, "Ingrid Richter" },
                    { 102, 5, "Heinz Fischer" },
                    { 103, 4, "Friedrich Schmidt" },
                    { 104, 3, "Dieter Becker" },
                    { 105, 3, "Friedrich Meier" },
                    { 106, 1, "Eva Meier" },
                    { 107, 4, "Ingrid Richter" },
                    { 108, 1, "Bernd Weber" },
                    { 109, 5, "Johann Meier" },
                    { 110, 2, "Greta Weber" },
                    { 111, 5, "Dieter Meier" },
                    { 112, 2, "Bernd Bauer" },
                    { 113, 3, "Dieter Becker" },
                    { 114, 3, "Anton Weber" },
                    { 115, 3, "Friedrich Fischer" },
                    { 116, 5, "Greta Bauer" },
                    { 117, 5, "Johann Koch" },
                    { 118, 5, "Ingrid Meier" },
                    { 119, 4, "Johann Wagner" },
                    { 120, 2, "Greta Müller" },
                    { 121, 3, "Clara Fischer" },
                    { 122, 2, "Heinz Koch" },
                    { 123, 4, "Dieter Richter" }
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

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Occupancies_EmployeeId",
                table: "Occupancies",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Occupancies_WorkplaceId",
                table: "Occupancies",
                column: "WorkplaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Workplaces_RoomId",
                table: "Workplaces",
                column: "RoomId");
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
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Occupancies");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Workplaces");

            migrationBuilder.DropTable(
                name: "Rooms");
        }
    }
}
