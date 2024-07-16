using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Deskbuddy.Migrations
{
    /// <inheritdoc />
    public partial class seedingRoom : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "696af5b0-898a-44da-85f4-fc1674f8df2a", "1f6695ef-d669-48b4-b194-bd92d17057e0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5b08c06c-8aab-422a-bbb5-898ad7f76ba6", "75b19fb1-7184-4a1e-bfaf-39d157353db2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "57c8a05d-6ca2-4fd0-b345-3ffc012aa679", "902f1326-2d22-411a-8c06-6732ad46aff4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c19c4014-c8be-43a0-ad73-f63c87050feb", "aa167027-4226-4341-bc45-fd9a0748f70a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "57c8a05d-6ca2-4fd0-b345-3ffc012aa679");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b08c06c-8aab-422a-bbb5-898ad7f76ba6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "696af5b0-898a-44da-85f4-fc1674f8df2a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c19c4014-c8be-43a0-ad73-f63c87050feb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f6695ef-d669-48b4-b194-bd92d17057e0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "75b19fb1-7184-4a1e-bfaf-39d157353db2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "902f1326-2d22-411a-8c06-6732ad46aff4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aa167027-4226-4341-bc45-fd9a0748f70a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7ac76fc0-c50d-4f77-8d96-df8da588d757", null, "Administrator", "ADMINISTRATOR" },
                    { "87cdce2b-dd19-4830-83e0-ac26a0997d03", null, "Abteilungsleiter", "ABTEILUNGSLEITER" },
                    { "ca57bdb0-b7ca-4f88-a3b2-9a3c0a08d5d8", null, "Mitarbeiter", "MITARBEITER" },
                    { "dd515b4d-ff02-43a4-8be8-52007bd85446", null, "Sekretariat", "SEKRETARIAT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0d8d0d49-b52e-4158-b4fd-1b282046c0b7", 0, "cdf6ce9d-0b46-4f1f-bece-628ec7bf825f", null, false, false, null, null, "ADMIN@ABC.COM", "AQAAAAIAAYagAAAAEH4e7Ee/LBtSIKS9T3sz2uiKBOdZF5xWmGaLNXusNdfnQ1K+LEHuYm8ZfFUUYR8FNg==", null, false, "8bbfeedf-da6b-42c4-8329-4c5b7f569feb", false, "admin@abc.com" },
                    { "2ed38f27-8671-4f8c-bdcc-5d95235d90f3", 0, "ca7f1f5e-a6d8-4188-962d-0e5e364be0f6", null, false, false, null, null, "SEKRETARIAT@ABC.COM", "AQAAAAIAAYagAAAAEPFf/aINQwfWZut3BQefH8F46QMs7cMcUCuhgJyunjaBvGWYxQUb5TldEqGm5nN2QQ==", null, false, "35a05ee6-93c9-446b-ba79-aeb475df2dee", false, "sekretariat@abc.com" },
                    { "3bf84860-8b94-4349-8b09-ccc4966bdf6a", 0, "8152840d-fe90-4d71-901b-e44717d009c6", null, false, false, null, null, "MITARBEITER@ABC.COM", "AQAAAAIAAYagAAAAEBHYTsNSKog/X0FTCT0Fr9rMxER9nyezNVnpd/ZE+aQBN09UOaQ4ulYp/4UmSdgPDw==", null, false, "52575cf6-b800-4268-864c-0b2f3d2b58cc", false, "mitarbeiter@abc.com" },
                    { "d88180fc-cd80-4087-a1f9-e1f8b5bded06", 0, "be307c9a-4afc-4081-afeb-df218e9475db", null, false, false, null, null, "ABTEILUNGSLEITER@ABC.COM", "AQAAAAIAAYagAAAAEB5asrkZOr55ylQ9Vwmab/bxta7vS5NAbOMZbeTON8AKIpdtGHhfiu3irDQj4hzknA==", null, false, "29cd5c2a-132e-40bf-b158-8017f917bced", false, "abteilungsleiter@abc.com" }
                });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Greta Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Bernd Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Anton Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Johann Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Heinz Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Johann Wagner");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Bernd Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Greta Schmidt");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Eva Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Anton Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Heinz Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Anton Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13,
                column: "Name",
                value: "Heinz Müller");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Greta Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Ingrid Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16,
                column: "Name",
                value: "Friedrich Becker");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17,
                column: "Name",
                value: "Eva Meier");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Heinz Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Greta Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Heinz Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Friedrich Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22,
                column: "Name",
                value: "Anton Wagner");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23,
                column: "Name",
                value: "Bernd Weber");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Friedrich Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Johann Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 26,
                column: "Name",
                value: "Friedrich Meier");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 27,
                column: "Name",
                value: "Bernd Weber");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 28,
                column: "Name",
                value: "Clara Weber");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 29,
                column: "Name",
                value: "Dieter Müller");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Friedrich Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Heinz Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Heinz Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Dieter Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 34,
                column: "Name",
                value: "Heinz Fischer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 35,
                column: "Name",
                value: "Eva Müller");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Bernd Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Friedrich Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Anton Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Johann Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Anton Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Dieter Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Johann Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 43,
                column: "Name",
                value: "Bernd Wagner");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Clara Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Friedrich Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Friedrich Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Eva Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Ingrid Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Eva Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Johann Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Heinz Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Friedrich Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Clara Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Dieter Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 55,
                column: "Name",
                value: "Eva Wagner");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Dieter Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Greta Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Greta Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Bernd Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Clara Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 61,
                column: "Name",
                value: "Clara Schmidt");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Johann Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Anton Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Eva Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Dieter Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Heinz Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Anton Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Dieter Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Heinz Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Ingrid Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Johann Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Eva Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Friedrich Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Friedrich Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 75,
                column: "Name",
                value: "Anton Fischer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Heinz Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 77,
                column: "Name",
                value: "Eva Müller");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 78,
                column: "Name",
                value: "Ingrid Weber");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 79,
                column: "DepartmentId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Eva Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 81,
                column: "DepartmentId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Eva Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 83,
                column: "Name",
                value: "Heinz Müller");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Eva Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Eva Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Heinz Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 87,
                column: "Name",
                value: "Friedrich Weber");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 88,
                column: "Name",
                value: "Dieter Meier");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 89,
                column: "Name",
                value: "Dieter Wagner");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Bernd Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Anton Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 92,
                column: "Name",
                value: "Dieter Weber");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Eva Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Greta Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Friedrich Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Eva Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Eva Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Friedrich Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Heinz Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Ingrid Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Heinz Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Ingrid Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Heinz Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Anton Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Clara Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 106,
                column: "Name",
                value: "Bernd Richter");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Eva Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Greta Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Ingrid Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Heinz Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Johann Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 112,
                column: "Name",
                value: "Ingrid Müller");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 113,
                column: "Name",
                value: "Eva Becker");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Ingrid Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Heinz Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Anton Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Dieter Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Clara Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Johann Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Heinz Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Greta Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Eva Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Eva Schmidt" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "R0001" },
                    { 2, "R0011" },
                    { 3, "R0021" },
                    { 4, "R0031" },
                    { 5, "R0041" },
                    { 6, "R0051" },
                    { 7, "R0061" },
                    { 8, "R0071" },
                    { 9, "R0081" },
                    { 10, "R0091" },
                    { 11, "R00101" },
                    { 12, "R00111" },
                    { 13, "R00121" },
                    { 14, "R00131" },
                    { 15, "R00141" },
                    { 16, "R00151" },
                    { 17, "R00161" },
                    { 18, "R00171" },
                    { 19, "R00181" },
                    { 20, "R00191" },
                    { 21, "R00201" },
                    { 22, "R00211" },
                    { 23, "R00221" },
                    { 24, "R00231" },
                    { 25, "R00241" },
                    { 26, "R00251" },
                    { 27, "R00261" },
                    { 28, "R00271" },
                    { 29, "R00281" },
                    { 30, "R00291" },
                    { 31, "R00301" },
                    { 32, "R00311" },
                    { 33, "R00321" },
                    { 34, "R00331" },
                    { 35, "R00341" },
                    { 36, "R00351" },
                    { 37, "R00361" },
                    { 38, "R00371" },
                    { 39, "R00381" },
                    { 40, "R00391" },
                    { 41, "R00401" },
                    { 42, "R00411" },
                    { 43, "R00421" },
                    { 44, "R00431" },
                    { 45, "R00441" },
                    { 46, "R00451" },
                    { 47, "R00461" },
                    { 48, "R00471" },
                    { 49, "R00481" },
                    { 50, "R00491" },
                    { 51, "R00501" },
                    { 52, "R00511" },
                    { 53, "R00521" },
                    { 54, "R00531" },
                    { 55, "R00541" },
                    { 56, "R00551" },
                    { 57, "R00561" },
                    { 58, "R00571" },
                    { 59, "R00581" },
                    { 60, "R00591" },
                    { 61, "R00601" },
                    { 62, "R00611" },
                    { 63, "R00621" },
                    { 64, "R00631" },
                    { 65, "R00641" },
                    { 66, "R00651" },
                    { 67, "R00661" },
                    { 68, "R00671" },
                    { 69, "R00681" },
                    { 70, "R00691" },
                    { 71, "R00701" },
                    { 72, "R00711" },
                    { 73, "R00721" },
                    { 74, "R00731" },
                    { 75, "R00741" },
                    { 76, "R00751" },
                    { 77, "R00761" },
                    { 78, "R00771" },
                    { 79, "R00781" },
                    { 80, "R00791" },
                    { 81, "R00801" },
                    { 82, "R00811" },
                    { 83, "R00821" },
                    { 84, "R00831" },
                    { 85, "R00841" },
                    { 86, "R00851" },
                    { 87, "R00861" },
                    { 88, "R00871" },
                    { 89, "R00881" },
                    { 90, "R00891" },
                    { 91, "R00901" },
                    { 92, "R00911" },
                    { 93, "R00921" },
                    { 94, "R00931" },
                    { 95, "R00941" },
                    { 96, "R00951" },
                    { 97, "R00961" },
                    { 98, "R00971" },
                    { 99, "R00981" },
                    { 100, "R00991" },
                    { 101, "R001001" },
                    { 102, "R001011" },
                    { 103, "R001021" },
                    { 104, "R001031" },
                    { 105, "R001041" },
                    { 106, "R001051" },
                    { 107, "R001061" },
                    { 108, "R001071" },
                    { 109, "R001081" },
                    { 110, "R001091" },
                    { 111, "R001101" },
                    { 112, "R001111" },
                    { 113, "R001121" },
                    { 114, "R001131" },
                    { 115, "R001141" },
                    { 116, "R001151" },
                    { 117, "R001161" },
                    { 118, "R001171" },
                    { 119, "R001181" },
                    { 120, "R001191" },
                    { 121, "R001201" },
                    { 122, "R001211" },
                    { 123, "R001221" },
                    { 124, "R001231" },
                    { 125, "R001241" },
                    { 126, "R001251" },
                    { 127, "R001261" },
                    { 128, "R001271" },
                    { 129, "R001281" },
                    { 130, "R001291" },
                    { 131, "R001301" },
                    { 132, "R001311" },
                    { 133, "R001321" },
                    { 134, "R001331" },
                    { 135, "R001341" },
                    { 136, "R001351" },
                    { 137, "R001361" },
                    { 138, "R001371" },
                    { 139, "R001381" },
                    { 140, "R001391" },
                    { 141, "R001401" },
                    { 142, "R001411" },
                    { 143, "R001421" },
                    { 144, "R001431" },
                    { 145, "R001441" },
                    { 146, "R001451" },
                    { 147, "R001461" },
                    { 148, "R001471" },
                    { 149, "R001481" },
                    { 150, "R001491" },
                    { 151, "R001501" },
                    { 152, "R001511" },
                    { 153, "R001521" },
                    { 154, "R001531" },
                    { 155, "R001541" },
                    { 156, "R001551" },
                    { 157, "R001561" },
                    { 158, "R001571" },
                    { 159, "R001581" },
                    { 160, "R001591" },
                    { 161, "R001601" },
                    { 162, "R001611" },
                    { 163, "R001621" },
                    { 164, "R001631" },
                    { 165, "R001641" },
                    { 166, "R001651" },
                    { 167, "R001661" },
                    { 168, "R001671" },
                    { 169, "R001681" },
                    { 170, "R001691" },
                    { 171, "R001701" },
                    { 172, "R001711" },
                    { 173, "R001721" },
                    { 174, "R001731" },
                    { 175, "R001741" },
                    { 176, "R001751" },
                    { 177, "R001761" },
                    { 178, "R001771" },
                    { 179, "R001781" },
                    { 180, "R001791" },
                    { 181, "R001801" },
                    { 182, "R001811" },
                    { 183, "R001821" },
                    { 184, "R001831" },
                    { 185, "R001841" },
                    { 186, "R001851" },
                    { 187, "R001861" },
                    { 188, "R001871" },
                    { 189, "R001881" },
                    { 190, "R001891" },
                    { 191, "R001901" },
                    { 192, "R001911" },
                    { 193, "R001921" },
                    { 194, "R001931" },
                    { 195, "R001941" },
                    { 196, "R001951" },
                    { 197, "R001961" },
                    { 198, "R001971" },
                    { 199, "R001981" },
                    { 200, "R001991" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "7ac76fc0-c50d-4f77-8d96-df8da588d757", "0d8d0d49-b52e-4158-b4fd-1b282046c0b7" },
                    { "dd515b4d-ff02-43a4-8be8-52007bd85446", "2ed38f27-8671-4f8c-bdcc-5d95235d90f3" },
                    { "ca57bdb0-b7ca-4f88-a3b2-9a3c0a08d5d8", "3bf84860-8b94-4349-8b09-ccc4966bdf6a" },
                    { "87cdce2b-dd19-4830-83e0-ac26a0997d03", "d88180fc-cd80-4087-a1f9-e1f8b5bded06" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7ac76fc0-c50d-4f77-8d96-df8da588d757", "0d8d0d49-b52e-4158-b4fd-1b282046c0b7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dd515b4d-ff02-43a4-8be8-52007bd85446", "2ed38f27-8671-4f8c-bdcc-5d95235d90f3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ca57bdb0-b7ca-4f88-a3b2-9a3c0a08d5d8", "3bf84860-8b94-4349-8b09-ccc4966bdf6a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "87cdce2b-dd19-4830-83e0-ac26a0997d03", "d88180fc-cd80-4087-a1f9-e1f8b5bded06" });

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7ac76fc0-c50d-4f77-8d96-df8da588d757");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "87cdce2b-dd19-4830-83e0-ac26a0997d03");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca57bdb0-b7ca-4f88-a3b2-9a3c0a08d5d8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dd515b4d-ff02-43a4-8be8-52007bd85446");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0d8d0d49-b52e-4158-b4fd-1b282046c0b7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ed38f27-8671-4f8c-bdcc-5d95235d90f3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3bf84860-8b94-4349-8b09-ccc4966bdf6a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d88180fc-cd80-4087-a1f9-e1f8b5bded06");

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

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Heinz Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Eva Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Greta Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Dieter Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Ingrid Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Bernd Meier");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Johann Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Eva Müller");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Clara Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Heinz Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Friedrich Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Greta Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13,
                column: "Name",
                value: "Anton Richter");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Greta Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Heinz Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16,
                column: "Name",
                value: "Dieter Müller");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17,
                column: "Name",
                value: "Eva Bauer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Dieter Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Dieter Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Ingrid Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Clara Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22,
                column: "Name",
                value: "Eva Schmidt");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23,
                column: "Name",
                value: "Dieter Weber");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Eva Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Heinz Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 26,
                column: "Name",
                value: "Clara Fischer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 27,
                column: "Name",
                value: "Dieter Richter");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 28,
                column: "Name",
                value: "Johann Fischer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 29,
                column: "Name",
                value: "Friedrich Weber");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Clara Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Clara Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Greta Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Ingrid Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 34,
                column: "Name",
                value: "Greta Schmidt");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 35,
                column: "Name",
                value: "Johann Schmidt");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Greta Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Dieter Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Bernd Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Johann Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Heinz Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Anton Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Greta Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 43,
                column: "Name",
                value: "Johann Meier");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Eva Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Dieter Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Bernd Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Bernd Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Heinz Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Friedrich Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Heinz Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Ingrid Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Dieter Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Bernd Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Ingrid Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 55,
                column: "Name",
                value: "Ingrid Bauer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Dieter Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Bernd Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Heinz Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Bernd Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Eva Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 61,
                column: "Name",
                value: "Anton Bauer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Bernd Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Eva Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Heinz Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Friedrich Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Heinz Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Clara Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Friedrich Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Johann Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Friedrich Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Bernd Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Heinz Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Bernd Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Dieter Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 75,
                column: "Name",
                value: "Clara Wagner");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Anton Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 77,
                column: "Name",
                value: "Heinz Meier");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 78,
                column: "Name",
                value: "Greta Weber");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 79,
                column: "DepartmentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Ingrid Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 81,
                column: "DepartmentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Dieter Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 83,
                column: "Name",
                value: "Johann Richter");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Heinz Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Heinz Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Dieter Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 87,
                column: "Name",
                value: "Friedrich Fischer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 88,
                column: "Name",
                value: "Eva Wagner");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 89,
                column: "Name",
                value: "Johann Fischer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Eva Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Ingrid Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 92,
                column: "Name",
                value: "Friedrich Weber");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Clara Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Johann Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Johann Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Friedrich Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Clara Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Anton Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Dieter Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Ingrid Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Ingrid Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Heinz Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Friedrich Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Dieter Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Friedrich Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 106,
                column: "Name",
                value: "Eva Meier");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Ingrid Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Bernd Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Johann Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Greta Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Dieter Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 112,
                column: "Name",
                value: "Bernd Bauer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 113,
                column: "Name",
                value: "Dieter Becker");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Anton Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Friedrich Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Greta Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Johann Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Ingrid Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Johann Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Greta Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Clara Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Heinz Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Dieter Richter" });

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
        }
    }
}
