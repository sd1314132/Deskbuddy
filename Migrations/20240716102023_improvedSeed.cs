using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Deskbuddy.Migrations
{
    /// <inheritdoc />
    public partial class improvedSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2eb5ddd6-06fa-4186-9e46-9752d854e746", "af62aa6c-a54e-45e3-9d88-faaf4518bce2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f9ee02bd-1acb-496d-a285-076c738ea8da", "c737f764-f867-4938-ad2b-83abececf65b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d1b04b44-5cb8-42c1-910f-9846e6917e5d", "d18a6353-b4cd-499c-a6d5-081161548252" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b782dc5c-7de8-431d-a72e-eadd1e47fc25", "d27f2c17-7bbc-4cfd-85d1-e1c1fb32fe53" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2eb5ddd6-06fa-4186-9e46-9752d854e746");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b782dc5c-7de8-431d-a72e-eadd1e47fc25");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d1b04b44-5cb8-42c1-910f-9846e6917e5d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f9ee02bd-1acb-496d-a285-076c738ea8da");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af62aa6c-a54e-45e3-9d88-faaf4518bce2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c737f764-f867-4938-ad2b-83abececf65b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d18a6353-b4cd-499c-a6d5-081161548252");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d27f2c17-7bbc-4cfd-85d1-e1c1fb32fe53");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0dc929f6-4acc-4095-b1b5-8957697f1c33", null, "Mitarbeiter", "MITARBEITER" },
                    { "1d4dce4a-0e5d-4c9e-bf73-c94813a673ba", null, "Sekretariat", "SEKRETARIAT" },
                    { "654b31f7-86b3-4605-94fe-74c758d656fd", null, "Abteilungsleiter", "ABTEILUNGSLEITER" },
                    { "ceb80718-691d-429a-b640-60060f7c8dfc", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "78887849-325d-4acc-9a4d-999b038dac1e", 0, "d96be017-a688-420f-97a1-971d9ed98f44", null, false, false, null, null, "SEKRETARIAT@ABC.COM", "AQAAAAIAAYagAAAAEDXFOT0GE8eTM/H/h5O88DcifP5fQF/Y90heu3l/rwx7EaXMR2sKVssbUSqucOa7nQ==", null, false, "519d68b6-d08a-4422-94c1-c178eb4a3283", false, "sekretariat@abc.com" },
                    { "80c35141-7452-4ed3-a9e6-32fb28adcb24", 0, "46b3accc-5353-4558-b550-7feb0cecd242", null, false, false, null, null, "MITARBEITER@ABC.COM", "AQAAAAIAAYagAAAAEBW8beE9eVbMASLGqv6YlWaUUTmf5PGt+87CzpDA6kmycGN02XODSHDI33RU/i2dyw==", null, false, "e067c455-6371-4928-9bda-2f424b24c385", false, "mitarbeiter@abc.com" },
                    { "a258df9b-45ed-4284-922a-57b61a503a97", 0, "114ab6e2-103e-4a53-862b-470ce097df6a", null, false, false, null, null, "ABTEILUNGSLEITER@ABC.COM", "AQAAAAIAAYagAAAAEII5eaoBwtau9CSaDg6L3QcWt0bVOyVN5qinHIypItle7JqcvG0QcSXOd2Pu3L2LsQ==", null, false, "a1dc2bd2-6558-4aae-8480-942062c10479", false, "abteilungsleiter@abc.com" },
                    { "b12aadfe-0582-4243-9742-838299c0ca3c", 0, "37429150-b0e2-406c-94a6-d7c6de9a0eec", null, false, false, null, null, "ADMIN@ABC.COM", "AQAAAAIAAYagAAAAEN9y8FYFbUq910PgMymYbncYFkEymdoKm5rsA0mn3lX3X6a2i5tl5MUMuWbnovuz6A==", null, false, "8bd1106a-b2b5-4a3d-bf2d-9013f423984a", false, "admin@abc.com" }
                });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Eva Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Heinz Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Anton Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Ingrid Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Greta Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Dieter Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Friedrich Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Friedrich Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Dieter Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Johann Weber");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Clara Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Greta Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Anton Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Heinz Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Greta Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Dieter Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Heinz Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Dieter Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Friedrich Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Clara Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Ingrid Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Greta Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Bernd Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Dieter Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Heinz Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Bernd Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Ingrid Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Bernd Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Anton Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Anton Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Eva Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Dieter Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Clara Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 34,
                column: "DepartmentId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Johann Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 36,
                column: "Name",
                value: "Dieter Wagner");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 37,
                column: "Name",
                value: "Dieter Richter");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Anton Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Ingrid Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Clara Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Friedrich Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Clara Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Dieter Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Clara Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Greta Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Anton Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Anton Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Johann Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Ingrid Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 50,
                column: "Name",
                value: "Johann Müller");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Eva Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Friedrich Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Bernd Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 54,
                column: "Name",
                value: "Friedrich Richter");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Johann Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Johann Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 57,
                column: "Name",
                value: "Ingrid Schmidt");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 58,
                column: "Name",
                value: "Johann Koch");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Johann Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 60,
                column: "Name",
                value: "Greta Koch");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 61,
                column: "Name",
                value: "Eva Schmidt");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Bernd Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Friedrich Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Anton Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Friedrich Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Greta Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Eva Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Eva Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Eva Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Eva Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Johann Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Friedrich Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Bernd Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Heinz Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Bernd Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Heinz Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Bernd Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 78,
                column: "Name",
                value: "Bernd Becker");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Johann Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Bernd Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 81,
                column: "Name",
                value: "Ingrid Meier");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Johann Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Ingrid Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Ingrid Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Friedrich Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Dieter Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Heinz Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Dieter Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Ingrid Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 90,
                column: "Name",
                value: "Ingrid Bauer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 91,
                column: "Name",
                value: "Johann Richter");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Anton Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Anton Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Bernd Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Greta Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Greta Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Eva Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 98,
                column: "Name",
                value: "Friedrich Wagner");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Anton Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Clara Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Bernd Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Anton Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Eva Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Heinz Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 105,
                column: "Name",
                value: "Anton Schmidt");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Greta Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Johann Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 108,
                column: "Name",
                value: "Ingrid Müller");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Anton Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Johann Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Anton Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Greta Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Friedrich Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 114,
                column: "Name",
                value: "Heinz Fischer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Heinz Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Anton Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Greta Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Clara Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Eva Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Eva Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Friedrich Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Friedrich Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Bernd Meier" });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2024, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2024, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2024, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2024, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2024, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2024, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2024, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2024, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 21,
                column: "Date",
                value: new DateTime(2024, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 22,
                column: "Date",
                value: new DateTime(2024, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 23,
                column: "Date",
                value: new DateTime(2024, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 24,
                column: "Date",
                value: new DateTime(2024, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 25,
                column: "Date",
                value: new DateTime(2024, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 26,
                column: "Date",
                value: new DateTime(2024, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 27,
                column: "Date",
                value: new DateTime(2024, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 28,
                column: "Date",
                value: new DateTime(2024, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 29,
                column: "Date",
                value: new DateTime(2024, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 30,
                column: "Date",
                value: new DateTime(2024, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 31,
                column: "Date",
                value: new DateTime(2024, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 32,
                column: "Date",
                value: new DateTime(2024, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 33,
                column: "Date",
                value: new DateTime(2024, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 34,
                column: "Date",
                value: new DateTime(2024, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 35,
                column: "Date",
                value: new DateTime(2024, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 36,
                column: "Date",
                value: new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 37,
                column: "Date",
                value: new DateTime(2024, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 38,
                column: "Date",
                value: new DateTime(2024, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 39,
                column: "Date",
                value: new DateTime(2024, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 40,
                column: "Date",
                value: new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 41,
                column: "Date",
                value: new DateTime(2024, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 42,
                column: "Date",
                value: new DateTime(2024, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 43,
                column: "Date",
                value: new DateTime(2024, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 44,
                column: "Date",
                value: new DateTime(2024, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 45,
                column: "Date",
                value: new DateTime(2024, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 46,
                column: "Date",
                value: new DateTime(2024, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 47,
                column: "Date",
                value: new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 48,
                column: "Date",
                value: new DateTime(2024, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 49,
                column: "Date",
                value: new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 50,
                column: "Date",
                value: new DateTime(2024, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 51,
                column: "Date",
                value: new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 52,
                column: "Date",
                value: new DateTime(2024, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 53,
                column: "Date",
                value: new DateTime(2024, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 54,
                column: "Date",
                value: new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 55,
                column: "Date",
                value: new DateTime(2024, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 56,
                column: "Date",
                value: new DateTime(2024, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 57,
                column: "Date",
                value: new DateTime(2024, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 58,
                column: "Date",
                value: new DateTime(2024, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 59,
                column: "Date",
                value: new DateTime(2024, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 60,
                column: "Date",
                value: new DateTime(2024, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 61,
                column: "Date",
                value: new DateTime(2024, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 62,
                column: "Date",
                value: new DateTime(2024, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 63,
                column: "Date",
                value: new DateTime(2024, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 64,
                column: "Date",
                value: new DateTime(2024, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 65,
                column: "Date",
                value: new DateTime(2024, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 66,
                column: "Date",
                value: new DateTime(2024, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 67,
                column: "Date",
                value: new DateTime(2024, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 68,
                column: "Date",
                value: new DateTime(2024, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 69,
                column: "Date",
                value: new DateTime(2024, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 70,
                column: "Date",
                value: new DateTime(2024, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 71,
                column: "Date",
                value: new DateTime(2024, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 72,
                column: "Date",
                value: new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 73,
                column: "Date",
                value: new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 74,
                column: "Date",
                value: new DateTime(2024, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 75,
                column: "Date",
                value: new DateTime(2024, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 76,
                column: "Date",
                value: new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 77,
                column: "Date",
                value: new DateTime(2024, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 78,
                column: "Date",
                value: new DateTime(2024, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 79,
                column: "Date",
                value: new DateTime(2024, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 80,
                column: "Date",
                value: new DateTime(2024, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 81,
                column: "Date",
                value: new DateTime(2024, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 82,
                column: "Date",
                value: new DateTime(2024, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 83,
                column: "Date",
                value: new DateTime(2024, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 84,
                column: "Date",
                value: new DateTime(2024, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 85,
                column: "Date",
                value: new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 86,
                column: "Date",
                value: new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 87,
                column: "Date",
                value: new DateTime(2024, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 88,
                column: "Date",
                value: new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 89,
                column: "Date",
                value: new DateTime(2024, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 90,
                column: "Date",
                value: new DateTime(2024, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 91,
                column: "Date",
                value: new DateTime(2024, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 92,
                column: "Date",
                value: new DateTime(2024, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 93,
                column: "Date",
                value: new DateTime(2024, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 94,
                column: "Date",
                value: new DateTime(2024, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 95,
                column: "Date",
                value: new DateTime(2024, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 96,
                column: "Date",
                value: new DateTime(2024, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 97,
                column: "Date",
                value: new DateTime(2024, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 98,
                column: "Date",
                value: new DateTime(2024, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 99,
                column: "Date",
                value: new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 100,
                column: "Date",
                value: new DateTime(2024, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 101,
                column: "Date",
                value: new DateTime(2024, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 102,
                column: "Date",
                value: new DateTime(2024, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 103,
                column: "Date",
                value: new DateTime(2024, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 104,
                column: "Date",
                value: new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 105,
                column: "Date",
                value: new DateTime(2024, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 106,
                column: "Date",
                value: new DateTime(2024, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 107,
                column: "Date",
                value: new DateTime(2024, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 108,
                column: "Date",
                value: new DateTime(2024, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 109,
                column: "Date",
                value: new DateTime(2024, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 110,
                column: "Date",
                value: new DateTime(2024, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 111,
                column: "Date",
                value: new DateTime(2024, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 112,
                column: "Date",
                value: new DateTime(2024, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 113,
                column: "Date",
                value: new DateTime(2024, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 114,
                column: "Date",
                value: new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 115,
                column: "Date",
                value: new DateTime(2024, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 116,
                column: "Date",
                value: new DateTime(2024, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 117,
                column: "Date",
                value: new DateTime(2024, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 118,
                column: "Date",
                value: new DateTime(2024, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 119,
                column: "Date",
                value: new DateTime(2024, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 120,
                column: "Date",
                value: new DateTime(2024, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 121,
                column: "Date",
                value: new DateTime(2024, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 122,
                column: "Date",
                value: new DateTime(2024, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 123,
                column: "Date",
                value: new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 124,
                column: "Date",
                value: new DateTime(2024, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 125,
                column: "Date",
                value: new DateTime(2024, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 126,
                column: "Date",
                value: new DateTime(2024, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 127,
                column: "Date",
                value: new DateTime(2024, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 128,
                column: "Date",
                value: new DateTime(2024, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 129,
                column: "Date",
                value: new DateTime(2024, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 130,
                column: "Date",
                value: new DateTime(2024, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 131,
                column: "Date",
                value: new DateTime(2024, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 132,
                column: "Date",
                value: new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 133,
                column: "Date",
                value: new DateTime(2024, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 134,
                column: "Date",
                value: new DateTime(2024, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 135,
                column: "Date",
                value: new DateTime(2024, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 136,
                column: "Date",
                value: new DateTime(2024, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 137,
                column: "Date",
                value: new DateTime(2024, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 138,
                column: "Date",
                value: new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 139,
                column: "Date",
                value: new DateTime(2024, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 140,
                column: "Date",
                value: new DateTime(2024, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 141,
                column: "Date",
                value: new DateTime(2024, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 142,
                column: "Date",
                value: new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 143,
                column: "Date",
                value: new DateTime(2024, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 144,
                column: "Date",
                value: new DateTime(2024, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 145,
                column: "Date",
                value: new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 146,
                column: "Date",
                value: new DateTime(2024, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 147,
                column: "Date",
                value: new DateTime(2024, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 148,
                column: "Date",
                value: new DateTime(2024, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 149,
                column: "Date",
                value: new DateTime(2024, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 150,
                column: "Date",
                value: new DateTime(2024, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 151,
                column: "Date",
                value: new DateTime(2024, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 152,
                column: "Date",
                value: new DateTime(2024, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 153,
                column: "Date",
                value: new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 154,
                column: "Date",
                value: new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 155,
                column: "Date",
                value: new DateTime(2024, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 156,
                column: "Date",
                value: new DateTime(2024, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 157,
                column: "Date",
                value: new DateTime(2024, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 158,
                column: "Date",
                value: new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 159,
                column: "Date",
                value: new DateTime(2024, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 160,
                column: "Date",
                value: new DateTime(2024, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 161,
                column: "Date",
                value: new DateTime(2024, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 162,
                column: "Date",
                value: new DateTime(2024, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 163,
                column: "Date",
                value: new DateTime(2024, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 164,
                column: "Date",
                value: new DateTime(2024, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 165,
                column: "Date",
                value: new DateTime(2024, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 166,
                column: "Date",
                value: new DateTime(2024, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 167,
                column: "Date",
                value: new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 168,
                column: "Date",
                value: new DateTime(2024, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 169,
                column: "Date",
                value: new DateTime(2024, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 170,
                column: "Date",
                value: new DateTime(2024, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 171,
                column: "Date",
                value: new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 172,
                column: "Date",
                value: new DateTime(2024, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 173,
                column: "Date",
                value: new DateTime(2024, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 174,
                column: "Date",
                value: new DateTime(2024, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 175,
                column: "Date",
                value: new DateTime(2024, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 176,
                column: "Date",
                value: new DateTime(2024, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 177,
                column: "Date",
                value: new DateTime(2024, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 178,
                column: "Date",
                value: new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 179,
                column: "Date",
                value: new DateTime(2024, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 180,
                column: "Date",
                value: new DateTime(2024, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 181,
                column: "Date",
                value: new DateTime(2024, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 182,
                column: "Date",
                value: new DateTime(2024, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 183,
                column: "Date",
                value: new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 184,
                column: "Date",
                value: new DateTime(2024, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 185,
                column: "Date",
                value: new DateTime(2024, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 186,
                column: "Date",
                value: new DateTime(2024, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 187,
                column: "Date",
                value: new DateTime(2024, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 188,
                column: "Date",
                value: new DateTime(2024, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 189,
                column: "Date",
                value: new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 190,
                column: "Date",
                value: new DateTime(2024, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 191,
                column: "Date",
                value: new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 192,
                column: "Date",
                value: new DateTime(2024, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 193,
                column: "Date",
                value: new DateTime(2024, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 194,
                column: "Date",
                value: new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 195,
                column: "Date",
                value: new DateTime(2024, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 196,
                column: "Date",
                value: new DateTime(2024, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 197,
                column: "Date",
                value: new DateTime(2024, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 198,
                column: "Date",
                value: new DateTime(2024, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 199,
                column: "Date",
                value: new DateTime(2024, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 200,
                column: "Date",
                value: new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "R001");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "R002");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "R003");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "R004");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "R005");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "R006");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "R007");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "R008");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "R009");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "R010");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "R011");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12,
                column: "Name",
                value: "R012");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 13,
                column: "Name",
                value: "R013");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14,
                column: "Name",
                value: "R014");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 15,
                column: "Name",
                value: "R015");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 16,
                column: "Name",
                value: "R016");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 17,
                column: "Name",
                value: "R017");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 18,
                column: "Name",
                value: "R018");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 19,
                column: "Name",
                value: "R019");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 20,
                column: "Name",
                value: "R020");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 21,
                column: "Name",
                value: "R021");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 22,
                column: "Name",
                value: "R022");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 23,
                column: "Name",
                value: "R023");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 24,
                column: "Name",
                value: "R024");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 25,
                column: "Name",
                value: "R025");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 26,
                column: "Name",
                value: "R026");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 27,
                column: "Name",
                value: "R027");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 28,
                column: "Name",
                value: "R028");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 29,
                column: "Name",
                value: "R029");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 30,
                column: "Name",
                value: "R030");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 31,
                column: "Name",
                value: "R031");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 32,
                column: "Name",
                value: "R032");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 33,
                column: "Name",
                value: "R033");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 34,
                column: "Name",
                value: "R034");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 35,
                column: "Name",
                value: "R035");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 36,
                column: "Name",
                value: "R036");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 37,
                column: "Name",
                value: "R037");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 38,
                column: "Name",
                value: "R038");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 39,
                column: "Name",
                value: "R039");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 40,
                column: "Name",
                value: "R040");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 41,
                column: "Name",
                value: "R041");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 42,
                column: "Name",
                value: "R042");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 43,
                column: "Name",
                value: "R043");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 44,
                column: "Name",
                value: "R044");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 45,
                column: "Name",
                value: "R045");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 46,
                column: "Name",
                value: "R046");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 47,
                column: "Name",
                value: "R047");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 48,
                column: "Name",
                value: "R048");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 49,
                column: "Name",
                value: "R049");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 50,
                column: "Name",
                value: "R050");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 51,
                column: "Name",
                value: "R051");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 52,
                column: "Name",
                value: "R052");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 53,
                column: "Name",
                value: "R053");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 54,
                column: "Name",
                value: "R054");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 55,
                column: "Name",
                value: "R055");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 56,
                column: "Name",
                value: "R056");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 57,
                column: "Name",
                value: "R057");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 58,
                column: "Name",
                value: "R058");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 59,
                column: "Name",
                value: "R059");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 60,
                column: "Name",
                value: "R060");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 61,
                column: "Name",
                value: "R061");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 62,
                column: "Name",
                value: "R062");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 63,
                column: "Name",
                value: "R063");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 64,
                column: "Name",
                value: "R064");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 65,
                column: "Name",
                value: "R065");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 66,
                column: "Name",
                value: "R066");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 67,
                column: "Name",
                value: "R067");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 68,
                column: "Name",
                value: "R068");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 69,
                column: "Name",
                value: "R069");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 70,
                column: "Name",
                value: "R070");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 71,
                column: "Name",
                value: "R071");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 72,
                column: "Name",
                value: "R072");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 73,
                column: "Name",
                value: "R073");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 74,
                column: "Name",
                value: "R074");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 75,
                column: "Name",
                value: "R075");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 76,
                column: "Name",
                value: "R076");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 77,
                column: "Name",
                value: "R077");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 78,
                column: "Name",
                value: "R078");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 79,
                column: "Name",
                value: "R079");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 80,
                column: "Name",
                value: "R080");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 81,
                column: "Name",
                value: "R081");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 82,
                column: "Name",
                value: "R082");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 83,
                column: "Name",
                value: "R083");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 84,
                column: "Name",
                value: "R084");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 85,
                column: "Name",
                value: "R085");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 86,
                column: "Name",
                value: "R086");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 87,
                column: "Name",
                value: "R087");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 88,
                column: "Name",
                value: "R088");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 89,
                column: "Name",
                value: "R089");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 90,
                column: "Name",
                value: "R090");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 91,
                column: "Name",
                value: "R091");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 92,
                column: "Name",
                value: "R092");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 93,
                column: "Name",
                value: "R093");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 94,
                column: "Name",
                value: "R094");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 95,
                column: "Name",
                value: "R095");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 96,
                column: "Name",
                value: "R096");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 97,
                column: "Name",
                value: "R097");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 98,
                column: "Name",
                value: "R098");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 99,
                column: "Name",
                value: "R099");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 100,
                column: "Name",
                value: "R100");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 101,
                column: "Name",
                value: "R101");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 102,
                column: "Name",
                value: "R102");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 103,
                column: "Name",
                value: "R103");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 104,
                column: "Name",
                value: "R104");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 105,
                column: "Name",
                value: "R105");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 106,
                column: "Name",
                value: "R106");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 107,
                column: "Name",
                value: "R107");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 108,
                column: "Name",
                value: "R108");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 109,
                column: "Name",
                value: "R109");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 110,
                column: "Name",
                value: "R110");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 111,
                column: "Name",
                value: "R111");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 112,
                column: "Name",
                value: "R112");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 113,
                column: "Name",
                value: "R113");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 114,
                column: "Name",
                value: "R114");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 115,
                column: "Name",
                value: "R115");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 116,
                column: "Name",
                value: "R116");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 117,
                column: "Name",
                value: "R117");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 118,
                column: "Name",
                value: "R118");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 119,
                column: "Name",
                value: "R119");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 120,
                column: "Name",
                value: "R120");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 121,
                column: "Name",
                value: "R121");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 122,
                column: "Name",
                value: "R122");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 123,
                column: "Name",
                value: "R123");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 124,
                column: "Name",
                value: "R124");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 125,
                column: "Name",
                value: "R125");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 126,
                column: "Name",
                value: "R126");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 127,
                column: "Name",
                value: "R127");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 128,
                column: "Name",
                value: "R128");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 129,
                column: "Name",
                value: "R129");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 130,
                column: "Name",
                value: "R130");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 131,
                column: "Name",
                value: "R131");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 132,
                column: "Name",
                value: "R132");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 133,
                column: "Name",
                value: "R133");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 134,
                column: "Name",
                value: "R134");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 135,
                column: "Name",
                value: "R135");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 136,
                column: "Name",
                value: "R136");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 137,
                column: "Name",
                value: "R137");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 138,
                column: "Name",
                value: "R138");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 139,
                column: "Name",
                value: "R139");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 140,
                column: "Name",
                value: "R140");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 141,
                column: "Name",
                value: "R141");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 142,
                column: "Name",
                value: "R142");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 143,
                column: "Name",
                value: "R143");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 144,
                column: "Name",
                value: "R144");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 145,
                column: "Name",
                value: "R145");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 146,
                column: "Name",
                value: "R146");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 147,
                column: "Name",
                value: "R147");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 148,
                column: "Name",
                value: "R148");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 149,
                column: "Name",
                value: "R149");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 150,
                column: "Name",
                value: "R150");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 151,
                column: "Name",
                value: "R151");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 152,
                column: "Name",
                value: "R152");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 153,
                column: "Name",
                value: "R153");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 154,
                column: "Name",
                value: "R154");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 155,
                column: "Name",
                value: "R155");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 156,
                column: "Name",
                value: "R156");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 157,
                column: "Name",
                value: "R157");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 158,
                column: "Name",
                value: "R158");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 159,
                column: "Name",
                value: "R159");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 160,
                column: "Name",
                value: "R160");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 161,
                column: "Name",
                value: "R161");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 162,
                column: "Name",
                value: "R162");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 163,
                column: "Name",
                value: "R163");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 164,
                column: "Name",
                value: "R164");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 165,
                column: "Name",
                value: "R165");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 166,
                column: "Name",
                value: "R166");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 167,
                column: "Name",
                value: "R167");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 168,
                column: "Name",
                value: "R168");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 169,
                column: "Name",
                value: "R169");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 170,
                column: "Name",
                value: "R170");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 171,
                column: "Name",
                value: "R171");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 172,
                column: "Name",
                value: "R172");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 173,
                column: "Name",
                value: "R173");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 174,
                column: "Name",
                value: "R174");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 175,
                column: "Name",
                value: "R175");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 176,
                column: "Name",
                value: "R176");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 177,
                column: "Name",
                value: "R177");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 178,
                column: "Name",
                value: "R178");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 179,
                column: "Name",
                value: "R179");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 180,
                column: "Name",
                value: "R180");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 181,
                column: "Name",
                value: "R181");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 182,
                column: "Name",
                value: "R182");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 183,
                column: "Name",
                value: "R183");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 184,
                column: "Name",
                value: "R184");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 185,
                column: "Name",
                value: "R185");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 186,
                column: "Name",
                value: "R186");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 187,
                column: "Name",
                value: "R187");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 188,
                column: "Name",
                value: "R188");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 189,
                column: "Name",
                value: "R189");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 190,
                column: "Name",
                value: "R190");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 191,
                column: "Name",
                value: "R191");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 192,
                column: "Name",
                value: "R192");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 193,
                column: "Name",
                value: "R193");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 194,
                column: "Name",
                value: "R194");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 195,
                column: "Name",
                value: "R195");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 196,
                column: "Name",
                value: "R196");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 197,
                column: "Name",
                value: "R197");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 198,
                column: "Name",
                value: "R198");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 199,
                column: "Name",
                value: "R199");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 200,
                column: "Name",
                value: "R200");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 2,
                column: "SpecialProperties",
                value: "Ruheraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 8,
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 13,
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 15,
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 16,
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 18,
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 20,
                column: "SpecialProperties",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 34,
                column: "Description",
                value: "Bühne");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 35,
                column: "SpecialProperties",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 36,
                column: "SpecialProperties",
                value: "Schlafraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 37,
                column: "Description",
                value: "Bühne");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 38,
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 39,
                column: "SpecialProperties",
                value: "Ruheraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 40,
                column: "SpecialProperties",
                value: "Schlafraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 42,
                column: "SpecialProperties",
                value: "Ruheraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 45,
                column: "SpecialProperties",
                value: "Schlafraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 48,
                column: "SpecialProperties",
                value: "Ruheraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 50,
                column: "Description",
                value: "Bühne");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 51,
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 53,
                column: "Description",
                value: "Bühne");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 54,
                column: "SpecialProperties",
                value: "Ruheraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 56,
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 58,
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 60,
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 62,
                column: "Description",
                value: "Bühne");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 66,
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 67,
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 68,
                column: "SpecialProperties",
                value: "Ruheraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 72,
                column: "SpecialProperties",
                value: "Partyraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 73,
                column: "SpecialProperties",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 74,
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 77,
                column: "SpecialProperties",
                value: "Partyraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 80,
                column: "SpecialProperties",
                value: "Partyraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 84,
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 86,
                column: "Description",
                value: "Bühne");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 89,
                column: "SpecialProperties",
                value: "Ruheraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 92,
                column: "SpecialProperties",
                value: "Schlafraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 93,
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 95,
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 99,
                column: "SpecialProperties",
                value: "Schlafraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 103,
                column: "Description",
                value: "Bühne");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 106,
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 110,
                column: "Description",
                value: "Bühne");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 112,
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 116,
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 117,
                column: "SpecialProperties",
                value: "Partyraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 118,
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 121,
                column: "SpecialProperties",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 122,
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 129,
                column: "SpecialProperties",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 133,
                column: "Description",
                value: "Bühne");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 134,
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 139,
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 140,
                column: "SpecialProperties",
                value: "Schlafraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 142,
                column: "SpecialProperties",
                value: "Schlafraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 143,
                column: "SpecialProperties",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 150,
                column: "SpecialProperties",
                value: "Schlafraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 154,
                column: "SpecialProperties",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 156,
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 164,
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 170,
                column: "SpecialProperties",
                value: "Ruheraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 171,
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 174,
                column: "Description",
                value: "Bühne");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 179,
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 182,
                column: "Description",
                value: "Bühne");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 184,
                column: "Description",
                value: "Bühne");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 185,
                column: "SpecialProperties",
                value: "Partyraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 186,
                column: "SpecialProperties",
                value: "Ruheraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 187,
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 188,
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 189,
                column: "SpecialProperties",
                value: "Schlafraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 191,
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 193,
                column: "SpecialProperties",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 194,
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 198,
                column: "SpecialProperties",
                value: "Ruheraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 199,
                column: "SpecialProperties",
                value: "Partyraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", " " });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1d4dce4a-0e5d-4c9e-bf73-c94813a673ba", "78887849-325d-4acc-9a4d-999b038dac1e" },
                    { "0dc929f6-4acc-4095-b1b5-8957697f1c33", "80c35141-7452-4ed3-a9e6-32fb28adcb24" },
                    { "654b31f7-86b3-4605-94fe-74c758d656fd", "a258df9b-45ed-4284-922a-57b61a503a97" },
                    { "ceb80718-691d-429a-b640-60060f7c8dfc", "b12aadfe-0582-4243-9742-838299c0ca3c" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1d4dce4a-0e5d-4c9e-bf73-c94813a673ba", "78887849-325d-4acc-9a4d-999b038dac1e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0dc929f6-4acc-4095-b1b5-8957697f1c33", "80c35141-7452-4ed3-a9e6-32fb28adcb24" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "654b31f7-86b3-4605-94fe-74c758d656fd", "a258df9b-45ed-4284-922a-57b61a503a97" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ceb80718-691d-429a-b640-60060f7c8dfc", "b12aadfe-0582-4243-9742-838299c0ca3c" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0dc929f6-4acc-4095-b1b5-8957697f1c33");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d4dce4a-0e5d-4c9e-bf73-c94813a673ba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "654b31f7-86b3-4605-94fe-74c758d656fd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ceb80718-691d-429a-b640-60060f7c8dfc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78887849-325d-4acc-9a4d-999b038dac1e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "80c35141-7452-4ed3-a9e6-32fb28adcb24");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a258df9b-45ed-4284-922a-57b61a503a97");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b12aadfe-0582-4243-9742-838299c0ca3c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2eb5ddd6-06fa-4186-9e46-9752d854e746", null, "Abteilungsleiter", "ABTEILUNGSLEITER" },
                    { "b782dc5c-7de8-431d-a72e-eadd1e47fc25", null, "Administrator", "ADMINISTRATOR" },
                    { "d1b04b44-5cb8-42c1-910f-9846e6917e5d", null, "Mitarbeiter", "MITARBEITER" },
                    { "f9ee02bd-1acb-496d-a285-076c738ea8da", null, "Sekretariat", "SEKRETARIAT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "af62aa6c-a54e-45e3-9d88-faaf4518bce2", 0, "32a762ab-e05a-40b4-a50d-9277907b32e3", null, false, false, null, null, "ABTEILUNGSLEITER@ABC.COM", "AQAAAAIAAYagAAAAEKa1WhtFv+BIYO/KE0eVFeZlWBvIaac8Sez6t5NhSM0TLSQ2+3jyv8vDDxgGVOtNXA==", null, false, "2ee30a3d-b1b4-45b8-ac22-0738f588fd60", false, "abteilungsleiter@abc.com" },
                    { "c737f764-f867-4938-ad2b-83abececf65b", 0, "8f853a81-fbd3-43ea-a846-b06b8e94e0bb", null, false, false, null, null, "SEKRETARIAT@ABC.COM", "AQAAAAIAAYagAAAAECMvtGTDp0HaP2z9e6zSRWCeo3n5685CGVPtwhX280ncQCR6zAX7XAqmYTgj0gLAjg==", null, false, "ff07d887-ba6f-496d-b6ec-febbeae8b8a9", false, "sekretariat@abc.com" },
                    { "d18a6353-b4cd-499c-a6d5-081161548252", 0, "02b0fea8-fc26-4ee5-98d7-8b925a6de0af", null, false, false, null, null, "MITARBEITER@ABC.COM", "AQAAAAIAAYagAAAAEOg33jHJolaHN2n+lvobzbMhTvLxR8rmmo43z8HjwkhmuoUXG/AqUtBVbje0lIPLQw==", null, false, "77e0b348-68c1-452f-bf80-42d71e2dfb5c", false, "mitarbeiter@abc.com" },
                    { "d27f2c17-7bbc-4cfd-85d1-e1c1fb32fe53", 0, "9ac9bc39-a6a3-4699-a987-892512f4b99d", null, false, false, null, null, "ADMIN@ABC.COM", "AQAAAAIAAYagAAAAEOsSKYG09VXfH9offxHSP0CuVBcfmgRilbVjAJbblXrkUI/aA44IrPtZZxDc06giUQ==", null, false, "c2d69736-ec20-4437-a35b-c9a7e84573ba", false, "admin@abc.com" }
                });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Anton Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Friedrich Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Heinz Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Ingrid Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Friedrich Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Friedrich Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Heinz Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Anton Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Johann Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Clara Müller");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Ingrid Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Friedrich Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Heinz Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Greta Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Johann Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Heinz Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Clara Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Friedrich Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Anton Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Johann Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Heinz Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Anton Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Ingrid Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Clara Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Ingrid Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Greta Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Johann Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Bernd Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Anton Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Greta Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Heinz Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Greta Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Anton Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 34,
                column: "DepartmentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Dieter Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 36,
                column: "Name",
                value: "Greta Bauer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 37,
                column: "Name",
                value: "Johann Bauer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Anton Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Eva Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Dieter Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Anton Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Anton Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Eva Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Anton Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Johann Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Dieter Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Johann Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Heinz Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Dieter Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 50,
                column: "Name",
                value: "Johann Weber");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Greta Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Ingrid Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Friedrich Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 54,
                column: "Name",
                value: "Greta Becker");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Greta Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Anton Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 57,
                column: "Name",
                value: "Heinz Weber");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 58,
                column: "Name",
                value: "Clara Meier");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Eva Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 60,
                column: "Name",
                value: "Clara Becker");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 61,
                column: "Name",
                value: "Friedrich Schmidt");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Dieter Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Johann Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Anton Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Dieter Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Ingrid Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Anton Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Friedrich Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Clara Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Dieter Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Bernd Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Friedrich Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Ingrid Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Johann Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Ingrid Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Johann Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Clara Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 78,
                column: "Name",
                value: "Bernd Wagner");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Greta Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Bernd Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 81,
                column: "Name",
                value: "Eva Meier");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Friedrich Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Eva Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Heinz Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Ingrid Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Johann Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Heinz Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Friedrich Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Eva Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 90,
                column: "Name",
                value: "Clara Weber");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 91,
                column: "Name",
                value: "Friedrich Wagner");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Greta Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Ingrid Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Greta Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Heinz Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Friedrich Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Heinz Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 98,
                column: "Name",
                value: "Clara Schmidt");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Anton Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Clara Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Eva Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Dieter Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Bernd Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Heinz Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 105,
                column: "Name",
                value: "Ingrid Meier");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Clara Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Ingrid Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 108,
                column: "Name",
                value: "Bernd Schmidt");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Eva Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Bernd Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Clara Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Ingrid Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Johann Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 114,
                column: "Name",
                value: "Bernd Bauer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Dieter Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Friedrich Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Eva Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Eva Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Clara Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Clara Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Clara Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Ingrid Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Friedrich Bauer" });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 7, 16, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 7, 17, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1329));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 7, 18, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1345));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 7, 19, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1360));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 7, 20, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1375));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 7, 21, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1394));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 7, 22, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 7, 23, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1425));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 7, 24, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1461));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2024, 7, 25, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1476));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2024, 7, 26, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1493));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2024, 7, 27, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1508));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2024, 7, 28, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1522));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2024, 7, 29, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1538));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2024, 7, 30, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1552));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2024, 7, 31, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1573));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2024, 8, 1, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1589));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2024, 8, 2, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1605));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2024, 8, 3, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1620));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2024, 8, 4, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1634));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 21,
                column: "Date",
                value: new DateTime(2024, 8, 5, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1649));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 22,
                column: "Date",
                value: new DateTime(2024, 8, 6, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1663));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 23,
                column: "Date",
                value: new DateTime(2024, 8, 7, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1678));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 24,
                column: "Date",
                value: new DateTime(2024, 8, 8, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1693));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 25,
                column: "Date",
                value: new DateTime(2024, 8, 9, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1708));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 26,
                column: "Date",
                value: new DateTime(2024, 8, 10, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1724));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 27,
                column: "Date",
                value: new DateTime(2024, 8, 11, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1738));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 28,
                column: "Date",
                value: new DateTime(2024, 8, 12, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1752));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 29,
                column: "Date",
                value: new DateTime(2024, 8, 13, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1767));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 30,
                column: "Date",
                value: new DateTime(2024, 8, 14, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1784));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 31,
                column: "Date",
                value: new DateTime(2024, 8, 15, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1817));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 32,
                column: "Date",
                value: new DateTime(2024, 8, 16, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1833));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 33,
                column: "Date",
                value: new DateTime(2024, 8, 17, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1849));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 34,
                column: "Date",
                value: new DateTime(2024, 8, 18, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1865));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 35,
                column: "Date",
                value: new DateTime(2024, 8, 19, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1900));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 36,
                column: "Date",
                value: new DateTime(2024, 8, 20, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1916));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 37,
                column: "Date",
                value: new DateTime(2024, 8, 21, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1932));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 38,
                column: "Date",
                value: new DateTime(2024, 8, 22, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1947));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 39,
                column: "Date",
                value: new DateTime(2024, 8, 23, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1962));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 40,
                column: "Date",
                value: new DateTime(2024, 8, 24, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1977));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 41,
                column: "Date",
                value: new DateTime(2024, 8, 25, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1992));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 42,
                column: "Date",
                value: new DateTime(2024, 8, 26, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2007));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 43,
                column: "Date",
                value: new DateTime(2024, 8, 27, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2022));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 44,
                column: "Date",
                value: new DateTime(2024, 8, 28, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2036));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 45,
                column: "Date",
                value: new DateTime(2024, 8, 29, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 46,
                column: "Date",
                value: new DateTime(2024, 8, 30, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2065));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 47,
                column: "Date",
                value: new DateTime(2024, 8, 31, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2079));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 48,
                column: "Date",
                value: new DateTime(2024, 9, 1, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2094));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 49,
                column: "Date",
                value: new DateTime(2024, 9, 2, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2108));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 50,
                column: "Date",
                value: new DateTime(2024, 9, 3, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 51,
                column: "Date",
                value: new DateTime(2024, 9, 4, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2137));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 52,
                column: "Date",
                value: new DateTime(2024, 9, 5, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2153));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 53,
                column: "Date",
                value: new DateTime(2024, 9, 6, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2167));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 54,
                column: "Date",
                value: new DateTime(2024, 9, 7, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2183));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 55,
                column: "Date",
                value: new DateTime(2024, 9, 8, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2198));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 56,
                column: "Date",
                value: new DateTime(2024, 9, 9, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2213));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 57,
                column: "Date",
                value: new DateTime(2024, 9, 10, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2229));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 58,
                column: "Date",
                value: new DateTime(2024, 9, 11, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2243));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 59,
                column: "Date",
                value: new DateTime(2024, 9, 12, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2257));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 60,
                column: "Date",
                value: new DateTime(2024, 9, 13, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2271));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 61,
                column: "Date",
                value: new DateTime(2024, 9, 14, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2286));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 62,
                column: "Date",
                value: new DateTime(2024, 9, 15, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2300));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 63,
                column: "Date",
                value: new DateTime(2024, 9, 16, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2337));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 64,
                column: "Date",
                value: new DateTime(2024, 9, 17, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2353));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 65,
                column: "Date",
                value: new DateTime(2024, 9, 18, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2367));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 66,
                column: "Date",
                value: new DateTime(2024, 9, 19, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2382));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 67,
                column: "Date",
                value: new DateTime(2024, 9, 20, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2398));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 68,
                column: "Date",
                value: new DateTime(2024, 9, 21, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2412));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 69,
                column: "Date",
                value: new DateTime(2024, 9, 22, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2428));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 70,
                column: "Date",
                value: new DateTime(2024, 9, 23, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2442));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 71,
                column: "Date",
                value: new DateTime(2024, 9, 24, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2456));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 72,
                column: "Date",
                value: new DateTime(2024, 9, 25, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2472));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 73,
                column: "Date",
                value: new DateTime(2024, 9, 26, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2487));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 74,
                column: "Date",
                value: new DateTime(2024, 9, 27, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2503));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 75,
                column: "Date",
                value: new DateTime(2024, 9, 28, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2519));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 76,
                column: "Date",
                value: new DateTime(2024, 9, 29, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2534));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 77,
                column: "Date",
                value: new DateTime(2024, 9, 30, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2549));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 78,
                column: "Date",
                value: new DateTime(2024, 10, 1, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2563));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 79,
                column: "Date",
                value: new DateTime(2024, 10, 2, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2577));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 80,
                column: "Date",
                value: new DateTime(2024, 10, 3, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2593));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 81,
                column: "Date",
                value: new DateTime(2024, 10, 4, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2607));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 82,
                column: "Date",
                value: new DateTime(2024, 10, 5, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2623));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 83,
                column: "Date",
                value: new DateTime(2024, 10, 6, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2637));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 84,
                column: "Date",
                value: new DateTime(2024, 10, 7, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2652));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 85,
                column: "Date",
                value: new DateTime(2024, 10, 8, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2667));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 86,
                column: "Date",
                value: new DateTime(2024, 10, 9, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2681));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 87,
                column: "Date",
                value: new DateTime(2024, 10, 10, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2697));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 88,
                column: "Date",
                value: new DateTime(2024, 10, 11, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2734));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 89,
                column: "Date",
                value: new DateTime(2024, 10, 12, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2749));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 90,
                column: "Date",
                value: new DateTime(2024, 10, 13, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2764));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 91,
                column: "Date",
                value: new DateTime(2024, 10, 14, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 92,
                column: "Date",
                value: new DateTime(2024, 10, 15, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2794));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 93,
                column: "Date",
                value: new DateTime(2024, 10, 16, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2807));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 94,
                column: "Date",
                value: new DateTime(2024, 10, 17, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2822));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 95,
                column: "Date",
                value: new DateTime(2024, 10, 18, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2839));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 96,
                column: "Date",
                value: new DateTime(2024, 10, 19, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2854));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 97,
                column: "Date",
                value: new DateTime(2024, 10, 20, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2869));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 98,
                column: "Date",
                value: new DateTime(2024, 10, 21, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2884));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 99,
                column: "Date",
                value: new DateTime(2024, 10, 22, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2899));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 100,
                column: "Date",
                value: new DateTime(2024, 10, 23, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2914));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 101,
                column: "Date",
                value: new DateTime(2024, 10, 24, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2928));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 102,
                column: "Date",
                value: new DateTime(2024, 10, 25, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2943));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 103,
                column: "Date",
                value: new DateTime(2024, 10, 26, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2959));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 104,
                column: "Date",
                value: new DateTime(2024, 10, 27, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2974));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 105,
                column: "Date",
                value: new DateTime(2024, 10, 28, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2989));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 106,
                column: "Date",
                value: new DateTime(2024, 10, 29, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3003));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 107,
                column: "Date",
                value: new DateTime(2024, 10, 30, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3017));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 108,
                column: "Date",
                value: new DateTime(2024, 10, 31, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3032));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 109,
                column: "Date",
                value: new DateTime(2024, 11, 1, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3046));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 110,
                column: "Date",
                value: new DateTime(2024, 11, 2, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3060));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 111,
                column: "Date",
                value: new DateTime(2024, 11, 3, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3076));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 112,
                column: "Date",
                value: new DateTime(2024, 11, 4, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3091));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 113,
                column: "Date",
                value: new DateTime(2024, 11, 5, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3105));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 114,
                column: "Date",
                value: new DateTime(2024, 11, 6, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3119));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 115,
                column: "Date",
                value: new DateTime(2024, 11, 7, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3134));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 116,
                column: "Date",
                value: new DateTime(2024, 11, 8, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3163));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 117,
                column: "Date",
                value: new DateTime(2024, 11, 9, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3178));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 118,
                column: "Date",
                value: new DateTime(2024, 11, 10, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3193));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 119,
                column: "Date",
                value: new DateTime(2024, 11, 11, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3209));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 120,
                column: "Date",
                value: new DateTime(2024, 11, 12, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3224));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 121,
                column: "Date",
                value: new DateTime(2024, 11, 13, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3239));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 122,
                column: "Date",
                value: new DateTime(2024, 11, 14, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3253));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 123,
                column: "Date",
                value: new DateTime(2024, 11, 15, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3268));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 124,
                column: "Date",
                value: new DateTime(2024, 11, 16, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3282));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 125,
                column: "Date",
                value: new DateTime(2024, 11, 17, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3297));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 126,
                column: "Date",
                value: new DateTime(2024, 11, 18, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3312));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 127,
                column: "Date",
                value: new DateTime(2024, 11, 19, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3328));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 128,
                column: "Date",
                value: new DateTime(2024, 11, 20, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3342));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 129,
                column: "Date",
                value: new DateTime(2024, 11, 21, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3357));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 130,
                column: "Date",
                value: new DateTime(2024, 11, 22, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3371));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 131,
                column: "Date",
                value: new DateTime(2024, 11, 23, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3386));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 132,
                column: "Date",
                value: new DateTime(2024, 11, 24, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3401));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 133,
                column: "Date",
                value: new DateTime(2024, 11, 25, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3415));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 134,
                column: "Date",
                value: new DateTime(2024, 11, 26, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3430));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 135,
                column: "Date",
                value: new DateTime(2024, 11, 27, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3446));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 136,
                column: "Date",
                value: new DateTime(2024, 11, 28, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3461));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 137,
                column: "Date",
                value: new DateTime(2024, 11, 29, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3505));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 138,
                column: "Date",
                value: new DateTime(2024, 11, 30, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3520));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 139,
                column: "Date",
                value: new DateTime(2024, 12, 1, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3535));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 140,
                column: "Date",
                value: new DateTime(2024, 12, 2, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3549));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 141,
                column: "Date",
                value: new DateTime(2024, 12, 3, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3564));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 142,
                column: "Date",
                value: new DateTime(2024, 12, 4, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3578));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 143,
                column: "Date",
                value: new DateTime(2024, 12, 5, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3593));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 144,
                column: "Date",
                value: new DateTime(2024, 12, 6, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3609));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 145,
                column: "Date",
                value: new DateTime(2024, 12, 7, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3624));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 146,
                column: "Date",
                value: new DateTime(2024, 12, 8, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3638));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 147,
                column: "Date",
                value: new DateTime(2024, 12, 9, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3653));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 148,
                column: "Date",
                value: new DateTime(2024, 12, 10, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3668));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 149,
                column: "Date",
                value: new DateTime(2024, 12, 11, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3683));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 150,
                column: "Date",
                value: new DateTime(2024, 12, 12, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3699));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 151,
                column: "Date",
                value: new DateTime(2024, 12, 13, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3714));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 152,
                column: "Date",
                value: new DateTime(2024, 12, 14, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3729));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 153,
                column: "Date",
                value: new DateTime(2024, 12, 15, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3744));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 154,
                column: "Date",
                value: new DateTime(2024, 12, 16, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3760));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 155,
                column: "Date",
                value: new DateTime(2024, 12, 17, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3774));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 156,
                column: "Date",
                value: new DateTime(2024, 12, 18, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 157,
                column: "Date",
                value: new DateTime(2024, 12, 19, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3805));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 158,
                column: "Date",
                value: new DateTime(2024, 12, 20, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 159,
                column: "Date",
                value: new DateTime(2024, 12, 21, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3834));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 160,
                column: "Date",
                value: new DateTime(2024, 12, 22, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3849));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 161,
                column: "Date",
                value: new DateTime(2024, 12, 23, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3864));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 162,
                column: "Date",
                value: new DateTime(2024, 12, 24, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3878));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 163,
                column: "Date",
                value: new DateTime(2024, 12, 25, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3893));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 164,
                column: "Date",
                value: new DateTime(2024, 12, 26, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3908));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 165,
                column: "Date",
                value: new DateTime(2024, 12, 27, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 166,
                column: "Date",
                value: new DateTime(2024, 12, 28, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3967));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 167,
                column: "Date",
                value: new DateTime(2024, 12, 29, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3981));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 168,
                column: "Date",
                value: new DateTime(2024, 12, 30, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3997));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 169,
                column: "Date",
                value: new DateTime(2024, 12, 31, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4012));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 170,
                column: "Date",
                value: new DateTime(2025, 1, 1, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4026));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 171,
                column: "Date",
                value: new DateTime(2025, 1, 2, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 172,
                column: "Date",
                value: new DateTime(2025, 1, 3, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4055));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 173,
                column: "Date",
                value: new DateTime(2025, 1, 4, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 174,
                column: "Date",
                value: new DateTime(2025, 1, 5, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4086));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 175,
                column: "Date",
                value: new DateTime(2025, 1, 6, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4102));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 176,
                column: "Date",
                value: new DateTime(2025, 1, 7, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4117));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 177,
                column: "Date",
                value: new DateTime(2025, 1, 8, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4132));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 178,
                column: "Date",
                value: new DateTime(2025, 1, 9, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4147));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 179,
                column: "Date",
                value: new DateTime(2025, 1, 10, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4162));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 180,
                column: "Date",
                value: new DateTime(2025, 1, 11, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4178));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 181,
                column: "Date",
                value: new DateTime(2025, 1, 12, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4192));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 182,
                column: "Date",
                value: new DateTime(2025, 1, 13, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4207));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 183,
                column: "Date",
                value: new DateTime(2025, 1, 14, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4222));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 184,
                column: "Date",
                value: new DateTime(2025, 1, 15, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4236));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 185,
                column: "Date",
                value: new DateTime(2025, 1, 16, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4251));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 186,
                column: "Date",
                value: new DateTime(2025, 1, 17, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4266));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 187,
                column: "Date",
                value: new DateTime(2025, 1, 18, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4281));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 188,
                column: "Date",
                value: new DateTime(2025, 1, 19, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4297));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 189,
                column: "Date",
                value: new DateTime(2025, 1, 20, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4311));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 190,
                column: "Date",
                value: new DateTime(2025, 1, 21, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4327));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 191,
                column: "Date",
                value: new DateTime(2025, 1, 22, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4342));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 192,
                column: "Date",
                value: new DateTime(2025, 1, 23, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4357));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 193,
                column: "Date",
                value: new DateTime(2025, 1, 24, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4373));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 194,
                column: "Date",
                value: new DateTime(2025, 1, 25, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4413));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 195,
                column: "Date",
                value: new DateTime(2025, 1, 26, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4429));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 196,
                column: "Date",
                value: new DateTime(2025, 1, 27, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4444));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 197,
                column: "Date",
                value: new DateTime(2025, 1, 28, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4459));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 198,
                column: "Date",
                value: new DateTime(2025, 1, 29, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4475));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 199,
                column: "Date",
                value: new DateTime(2025, 1, 30, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4489));

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 200,
                column: "Date",
                value: new DateTime(2025, 1, 31, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "R0001");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "R0011");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "R0021");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "R0031");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "R0041");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "R0051");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "R0061");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "R0071");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "R0081");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "R0091");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "R00101");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12,
                column: "Name",
                value: "R00111");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 13,
                column: "Name",
                value: "R00121");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14,
                column: "Name",
                value: "R00131");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 15,
                column: "Name",
                value: "R00141");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 16,
                column: "Name",
                value: "R00151");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 17,
                column: "Name",
                value: "R00161");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 18,
                column: "Name",
                value: "R00171");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 19,
                column: "Name",
                value: "R00181");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 20,
                column: "Name",
                value: "R00191");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 21,
                column: "Name",
                value: "R00201");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 22,
                column: "Name",
                value: "R00211");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 23,
                column: "Name",
                value: "R00221");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 24,
                column: "Name",
                value: "R00231");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 25,
                column: "Name",
                value: "R00241");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 26,
                column: "Name",
                value: "R00251");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 27,
                column: "Name",
                value: "R00261");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 28,
                column: "Name",
                value: "R00271");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 29,
                column: "Name",
                value: "R00281");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 30,
                column: "Name",
                value: "R00291");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 31,
                column: "Name",
                value: "R00301");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 32,
                column: "Name",
                value: "R00311");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 33,
                column: "Name",
                value: "R00321");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 34,
                column: "Name",
                value: "R00331");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 35,
                column: "Name",
                value: "R00341");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 36,
                column: "Name",
                value: "R00351");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 37,
                column: "Name",
                value: "R00361");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 38,
                column: "Name",
                value: "R00371");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 39,
                column: "Name",
                value: "R00381");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 40,
                column: "Name",
                value: "R00391");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 41,
                column: "Name",
                value: "R00401");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 42,
                column: "Name",
                value: "R00411");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 43,
                column: "Name",
                value: "R00421");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 44,
                column: "Name",
                value: "R00431");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 45,
                column: "Name",
                value: "R00441");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 46,
                column: "Name",
                value: "R00451");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 47,
                column: "Name",
                value: "R00461");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 48,
                column: "Name",
                value: "R00471");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 49,
                column: "Name",
                value: "R00481");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 50,
                column: "Name",
                value: "R00491");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 51,
                column: "Name",
                value: "R00501");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 52,
                column: "Name",
                value: "R00511");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 53,
                column: "Name",
                value: "R00521");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 54,
                column: "Name",
                value: "R00531");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 55,
                column: "Name",
                value: "R00541");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 56,
                column: "Name",
                value: "R00551");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 57,
                column: "Name",
                value: "R00561");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 58,
                column: "Name",
                value: "R00571");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 59,
                column: "Name",
                value: "R00581");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 60,
                column: "Name",
                value: "R00591");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 61,
                column: "Name",
                value: "R00601");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 62,
                column: "Name",
                value: "R00611");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 63,
                column: "Name",
                value: "R00621");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 64,
                column: "Name",
                value: "R00631");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 65,
                column: "Name",
                value: "R00641");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 66,
                column: "Name",
                value: "R00651");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 67,
                column: "Name",
                value: "R00661");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 68,
                column: "Name",
                value: "R00671");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 69,
                column: "Name",
                value: "R00681");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 70,
                column: "Name",
                value: "R00691");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 71,
                column: "Name",
                value: "R00701");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 72,
                column: "Name",
                value: "R00711");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 73,
                column: "Name",
                value: "R00721");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 74,
                column: "Name",
                value: "R00731");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 75,
                column: "Name",
                value: "R00741");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 76,
                column: "Name",
                value: "R00751");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 77,
                column: "Name",
                value: "R00761");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 78,
                column: "Name",
                value: "R00771");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 79,
                column: "Name",
                value: "R00781");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 80,
                column: "Name",
                value: "R00791");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 81,
                column: "Name",
                value: "R00801");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 82,
                column: "Name",
                value: "R00811");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 83,
                column: "Name",
                value: "R00821");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 84,
                column: "Name",
                value: "R00831");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 85,
                column: "Name",
                value: "R00841");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 86,
                column: "Name",
                value: "R00851");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 87,
                column: "Name",
                value: "R00861");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 88,
                column: "Name",
                value: "R00871");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 89,
                column: "Name",
                value: "R00881");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 90,
                column: "Name",
                value: "R00891");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 91,
                column: "Name",
                value: "R00901");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 92,
                column: "Name",
                value: "R00911");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 93,
                column: "Name",
                value: "R00921");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 94,
                column: "Name",
                value: "R00931");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 95,
                column: "Name",
                value: "R00941");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 96,
                column: "Name",
                value: "R00951");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 97,
                column: "Name",
                value: "R00961");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 98,
                column: "Name",
                value: "R00971");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 99,
                column: "Name",
                value: "R00981");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 100,
                column: "Name",
                value: "R00991");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 101,
                column: "Name",
                value: "R001001");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 102,
                column: "Name",
                value: "R001011");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 103,
                column: "Name",
                value: "R001021");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 104,
                column: "Name",
                value: "R001031");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 105,
                column: "Name",
                value: "R001041");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 106,
                column: "Name",
                value: "R001051");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 107,
                column: "Name",
                value: "R001061");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 108,
                column: "Name",
                value: "R001071");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 109,
                column: "Name",
                value: "R001081");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 110,
                column: "Name",
                value: "R001091");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 111,
                column: "Name",
                value: "R001101");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 112,
                column: "Name",
                value: "R001111");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 113,
                column: "Name",
                value: "R001121");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 114,
                column: "Name",
                value: "R001131");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 115,
                column: "Name",
                value: "R001141");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 116,
                column: "Name",
                value: "R001151");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 117,
                column: "Name",
                value: "R001161");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 118,
                column: "Name",
                value: "R001171");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 119,
                column: "Name",
                value: "R001181");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 120,
                column: "Name",
                value: "R001191");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 121,
                column: "Name",
                value: "R001201");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 122,
                column: "Name",
                value: "R001211");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 123,
                column: "Name",
                value: "R001221");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 124,
                column: "Name",
                value: "R001231");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 125,
                column: "Name",
                value: "R001241");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 126,
                column: "Name",
                value: "R001251");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 127,
                column: "Name",
                value: "R001261");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 128,
                column: "Name",
                value: "R001271");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 129,
                column: "Name",
                value: "R001281");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 130,
                column: "Name",
                value: "R001291");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 131,
                column: "Name",
                value: "R001301");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 132,
                column: "Name",
                value: "R001311");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 133,
                column: "Name",
                value: "R001321");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 134,
                column: "Name",
                value: "R001331");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 135,
                column: "Name",
                value: "R001341");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 136,
                column: "Name",
                value: "R001351");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 137,
                column: "Name",
                value: "R001361");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 138,
                column: "Name",
                value: "R001371");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 139,
                column: "Name",
                value: "R001381");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 140,
                column: "Name",
                value: "R001391");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 141,
                column: "Name",
                value: "R001401");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 142,
                column: "Name",
                value: "R001411");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 143,
                column: "Name",
                value: "R001421");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 144,
                column: "Name",
                value: "R001431");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 145,
                column: "Name",
                value: "R001441");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 146,
                column: "Name",
                value: "R001451");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 147,
                column: "Name",
                value: "R001461");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 148,
                column: "Name",
                value: "R001471");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 149,
                column: "Name",
                value: "R001481");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 150,
                column: "Name",
                value: "R001491");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 151,
                column: "Name",
                value: "R001501");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 152,
                column: "Name",
                value: "R001511");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 153,
                column: "Name",
                value: "R001521");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 154,
                column: "Name",
                value: "R001531");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 155,
                column: "Name",
                value: "R001541");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 156,
                column: "Name",
                value: "R001551");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 157,
                column: "Name",
                value: "R001561");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 158,
                column: "Name",
                value: "R001571");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 159,
                column: "Name",
                value: "R001581");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 160,
                column: "Name",
                value: "R001591");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 161,
                column: "Name",
                value: "R001601");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 162,
                column: "Name",
                value: "R001611");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 163,
                column: "Name",
                value: "R001621");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 164,
                column: "Name",
                value: "R001631");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 165,
                column: "Name",
                value: "R001641");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 166,
                column: "Name",
                value: "R001651");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 167,
                column: "Name",
                value: "R001661");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 168,
                column: "Name",
                value: "R001671");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 169,
                column: "Name",
                value: "R001681");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 170,
                column: "Name",
                value: "R001691");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 171,
                column: "Name",
                value: "R001701");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 172,
                column: "Name",
                value: "R001711");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 173,
                column: "Name",
                value: "R001721");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 174,
                column: "Name",
                value: "R001731");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 175,
                column: "Name",
                value: "R001741");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 176,
                column: "Name",
                value: "R001751");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 177,
                column: "Name",
                value: "R001761");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 178,
                column: "Name",
                value: "R001771");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 179,
                column: "Name",
                value: "R001781");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 180,
                column: "Name",
                value: "R001791");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 181,
                column: "Name",
                value: "R001801");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 182,
                column: "Name",
                value: "R001811");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 183,
                column: "Name",
                value: "R001821");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 184,
                column: "Name",
                value: "R001831");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 185,
                column: "Name",
                value: "R001841");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 186,
                column: "Name",
                value: "R001851");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 187,
                column: "Name",
                value: "R001861");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 188,
                column: "Name",
                value: "R001871");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 189,
                column: "Name",
                value: "R001881");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 190,
                column: "Name",
                value: "R001891");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 191,
                column: "Name",
                value: "R001901");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 192,
                column: "Name",
                value: "R001911");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 193,
                column: "Name",
                value: "R001921");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 194,
                column: "Name",
                value: "R001931");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 195,
                column: "Name",
                value: "R001941");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 196,
                column: "Name",
                value: "R001951");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 197,
                column: "Name",
                value: "R001961");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 198,
                column: "Name",
                value: "R001971");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 199,
                column: "Name",
                value: "R001981");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 200,
                column: "Name",
                value: "R001991");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 2,
                column: "SpecialProperties",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 8,
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 13,
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 15,
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 16,
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 18,
                column: "Description",
                value: "Bühne");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 20,
                column: "SpecialProperties",
                value: "Ruheraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 34,
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 35,
                column: "SpecialProperties",
                value: "Ruheraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 36,
                column: "SpecialProperties",
                value: "Partyraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 37,
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 38,
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 39,
                column: "SpecialProperties",
                value: "Partyraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 40,
                column: "SpecialProperties",
                value: "Ruheraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 42,
                column: "SpecialProperties",
                value: "Schlafraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 45,
                column: "SpecialProperties",
                value: "Ruheraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 48,
                column: "SpecialProperties",
                value: "Partyraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 50,
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 51,
                column: "Description",
                value: "Bühne");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 53,
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 54,
                column: "SpecialProperties",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 56,
                column: "Description",
                value: "Bühne");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 58,
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 60,
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 62,
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 66,
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 67,
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 68,
                column: "SpecialProperties",
                value: "Partyraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 72,
                column: "SpecialProperties",
                value: "Ruheraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 73,
                column: "SpecialProperties",
                value: "Partyraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 74,
                column: "Description",
                value: "Bühne");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 77,
                column: "SpecialProperties",
                value: "Ruheraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 80,
                column: "SpecialProperties",
                value: "Schlafraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 84,
                column: "Description",
                value: "Bühne");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 86,
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 89,
                column: "SpecialProperties",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 92,
                column: "SpecialProperties",
                value: "Partyraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 93,
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 95,
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 99,
                column: "SpecialProperties",
                value: "Partyraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 103,
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 106,
                column: "Description",
                value: "Bühne");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 110,
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 112,
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 116,
                column: "Description",
                value: "Bühne");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 117,
                column: "SpecialProperties",
                value: "Ruheraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 118,
                column: "Description",
                value: "Bühne");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 121,
                column: "SpecialProperties",
                value: "Partyraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 122,
                column: "Description",
                value: "Bühne");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 129,
                column: "SpecialProperties",
                value: "Partyraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 133,
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 134,
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 139,
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 140,
                column: "SpecialProperties",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 142,
                column: "SpecialProperties",
                value: "Partyraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 143,
                column: "SpecialProperties",
                value: "Partyraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 150,
                column: "SpecialProperties",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 154,
                column: "SpecialProperties",
                value: "Partyraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 156,
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 164,
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 170,
                column: "SpecialProperties",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 171,
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 174,
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 179,
                column: "Description",
                value: "Bühne");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 182,
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 184,
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 185,
                column: "SpecialProperties",
                value: "Schlafraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 186,
                column: "SpecialProperties",
                value: "Schlafraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 187,
                column: "Description",
                value: "Bühne");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 188,
                column: "Description",
                value: "Bühne");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 189,
                column: "SpecialProperties",
                value: "Partyraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 191,
                column: "Description",
                value: "Bühne");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 193,
                column: "SpecialProperties",
                value: "Partyraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 194,
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 198,
                column: "SpecialProperties",
                value: "Partyraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 199,
                column: "SpecialProperties",
                value: "Schlafraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Schlafraum" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2eb5ddd6-06fa-4186-9e46-9752d854e746", "af62aa6c-a54e-45e3-9d88-faaf4518bce2" },
                    { "f9ee02bd-1acb-496d-a285-076c738ea8da", "c737f764-f867-4938-ad2b-83abececf65b" },
                    { "d1b04b44-5cb8-42c1-910f-9846e6917e5d", "d18a6353-b4cd-499c-a6d5-081161548252" },
                    { "b782dc5c-7de8-431d-a72e-eadd1e47fc25", "d27f2c17-7bbc-4cfd-85d1-e1c1fb32fe53" }
                });
        }
    }
}
