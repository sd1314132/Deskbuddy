using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Deskbuddy.Migrations
{
    /// <inheritdoc />
    public partial class updatedate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7e8307dc-e669-4859-8e87-d15888910d90", "26f71ef1-8cbd-417e-b785-b8f0cf34b8b8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "40965706-573e-4a60-9eb5-743c2ee01003", "2c12e171-0bdb-43aa-b9b6-5ee9180da012" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7b41768a-a888-4e96-a80f-e593ae59d12f", "adc4badf-0d6f-4218-bcc9-45463abaec82" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0d96d5e3-bc37-42a6-90cb-3b96f861771b", "eeba10cd-78fc-4eff-a5cf-482e304eb9a5" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0d96d5e3-bc37-42a6-90cb-3b96f861771b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40965706-573e-4a60-9eb5-743c2ee01003");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b41768a-a888-4e96-a80f-e593ae59d12f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e8307dc-e669-4859-8e87-d15888910d90");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26f71ef1-8cbd-417e-b785-b8f0cf34b8b8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c12e171-0bdb-43aa-b9b6-5ee9180da012");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "adc4badf-0d6f-4218-bcc9-45463abaec82");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eeba10cd-78fc-4eff-a5cf-482e304eb9a5");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Occupancies",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2433d0da-e3de-4bee-afc6-5eb20d067266", null, "Administrator", "ADMINISTRATOR" },
                    { "26d64274-681e-4417-8794-bd7c24f31717", null, "Mitarbeiter", "MITARBEITER" },
                    { "762839ae-e99a-4857-ae71-abc7887dbeac", null, "Abteilungsleiter", "ABTEILUNGSLEITER" },
                    { "ff459a26-1a1a-4c0f-8f12-b45c504926b9", null, "Sekretariat", "SEKRETARIAT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1780613a-344c-4de4-8b62-01206d771f8b", 0, "f5ed2d5b-e956-4479-9b18-6d1210a87893", null, false, false, null, null, "ABTEILUNGSLEITER@ABC.COM", "AQAAAAIAAYagAAAAEDTznzeggh4V8RigQazBOu5ZS4UkJvxj7zrbAzrfilSGwn55JadNzEbrJUJP4Fi6HQ==", null, false, "735f21a3-2cd9-40f2-bfcc-a421ac3ba94c", false, "abteilungsleiter@abc.com" },
                    { "1f81a31f-28fd-4e75-80d7-6b8fe6db09bd", 0, "23477501-7ac3-4c99-a0d2-81fd05a2e830", null, false, false, null, null, "MITARBEITER@ABC.COM", "AQAAAAIAAYagAAAAEOnZDGvAl9tm7T4yNh+3g7tu16pZJdzX3sr9j43gzVlitOAqddNv5p/JQkW9MPq3kA==", null, false, "7c5377b6-383f-4d9f-b5e5-6532a25b7504", false, "mitarbeiter@abc.com" },
                    { "b5b44ed2-35b7-445c-9974-b9f6d0f0d9c3", 0, "f66cd6c2-38a5-4429-a690-644be8974926", null, false, false, null, null, "ADMIN@ABC.COM", "AQAAAAIAAYagAAAAEODS5xDECiqZELMC72uI16djpEzxcq7vgjKSIGYuX5KGDaEJhEPOBcYAyKumH34xKw==", null, false, "6019f1c4-1610-41ae-8b19-603844fae545", false, "admin@abc.com" },
                    { "b9739710-1a41-4b29-9eef-11edcfa4b285", 0, "5f53a3fa-f543-46fe-92ec-5aef7ebba5d3", null, false, false, null, null, "SEKRETARIAT@ABC.COM", "AQAAAAIAAYagAAAAEH5L11/Fg4MosC4VpNF8/+rebE30vijqzovhxKy14QYiiosfVivPcBXNiz9Avp/EBw==", null, false, "f8c7521f-1ce0-4c03-a0c0-3b5c496dbf53", false, "sekretariat@abc.com" }
                });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Bernd Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Clara Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Anton Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Greta Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Johann Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Bernd Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Dieter Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Anton Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Bernd Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Clara Weber");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Greta Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Johann Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Johann Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Ingrid Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Heinz Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Clara Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Bernd Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Bernd Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Greta Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Johann Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21,
                column: "Name",
                value: "Johann Bauer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Anton Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Friedrich Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Anton Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Ingrid Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Greta Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Ingrid Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Ingrid Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Johann Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Greta Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Johann Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Heinz Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Friedrich Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 34,
                column: "Name",
                value: "Friedrich Wagner");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 35,
                column: "Name",
                value: "Clara Richter");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Anton Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Clara Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Johann Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 39,
                column: "Name",
                value: "Johann Koch");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Heinz Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 41,
                column: "Name",
                value: "Clara Wagner");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Anton Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Eva Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Johann Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Johann Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Johann Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Dieter Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Greta Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 49,
                column: "Name",
                value: "Anton Wagner");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Anton Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Dieter Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Clara Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Heinz Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Greta Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Anton Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 56,
                column: "Name",
                value: "Ingrid Becker");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Johann Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Johann Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Ingrid Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Dieter Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Clara Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Ingrid Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Johann Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 64,
                column: "Name",
                value: "Heinz Schmidt");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Clara Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 66,
                column: "Name",
                value: "Dieter Schmidt");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Ingrid Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Friedrich Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Greta Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 70,
                column: "Name",
                value: "Bernd Bauer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Friedrich Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Dieter Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Ingrid Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Dieter Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Anton Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Heinz Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 77,
                column: "Name",
                value: "Bernd Weber");

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
                values: new object[] { 2, "Bernd Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 80,
                column: "Name",
                value: "Bernd Koch");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Johann Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Dieter Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Greta Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 84,
                column: "Name",
                value: "Friedrich Weber");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 85,
                column: "Name",
                value: "Ingrid Müller");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Ingrid Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Eva Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Ingrid Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Johann Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Anton Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 91,
                column: "Name",
                value: "Bernd Fischer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Anton Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Heinz Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 94,
                column: "Name",
                value: "Greta Richter");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Johann Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 96,
                column: "Name",
                value: "Clara Müller");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Greta Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Heinz Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 99,
                column: "Name",
                value: "Ingrid Wagner");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Greta Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Johann Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Dieter Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Greta Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Johann Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Bernd Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Anton Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Clara Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Clara Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 109,
                column: "Name",
                value: "Dieter Fischer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Ingrid Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 111,
                column: "Name",
                value: "Clara Becker");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Greta Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 113,
                column: "Name",
                value: "Dieter Koch");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Greta Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Heinz Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Heinz Becker" });

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
                values: new object[] { 4, "Heinz Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 119,
                column: "Name",
                value: "Heinz Bauer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Bernd Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 121,
                column: "Name",
                value: "Eva Becker");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Anton Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Johann Fischer" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 10,
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 16,
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 17,
                column: "SpecialProperties",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 18,
                column: "SpecialProperties",
                value: "Schlafraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 20,
                column: "Description",
                value: "Bühne");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 22,
                column: "Description",
                value: "Bühne");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Schlafraum" });

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
                values: new object[] { "Schwarzlicht", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 29,
                column: "Description",
                value: "Bühne");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 34,
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 35,
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 37,
                column: "SpecialProperties",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 39,
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 40,
                column: "SpecialProperties",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 41,
                column: "Description",
                value: "Stühle");

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
                values: new object[] { "Schwarzlicht", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 46,
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 48,
                column: "Description",
                value: "Bühne");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 49,
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 53,
                column: "SpecialProperties",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 54,
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 55,
                column: "SpecialProperties",
                value: " ");

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
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 61,
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 64,
                column: "SpecialProperties",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 67,
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 68,
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 69,
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 75,
                column: "Description",
                value: "Schwarzlicht");

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 79,
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 83,
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 84,
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 86,
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 88,
                column: "Description",
                value: "Stühle");

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
                values: new object[] { "Beamer", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 92,
                column: "SpecialProperties",
                value: "Ruheraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 93,
                column: "SpecialProperties",
                value: "Schlafraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 96,
                column: "Description",
                value: "Bühne");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 97,
                column: "SpecialProperties",
                value: "Partyraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 100,
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 102,
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 105,
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 109,
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 110,
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 113,
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 115,
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Partyraum" });

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
                column: "SpecialProperties",
                value: "Ruheraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 123,
                column: "SpecialProperties",
                value: "Schlafraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 124,
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 125,
                column: "Description",
                value: "Bühne");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 130,
                column: "SpecialProperties",
                value: "Partyraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 134,
                column: "SpecialProperties",
                value: "Schlafraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 135,
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 136,
                column: "SpecialProperties",
                value: "Partyraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 137,
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 139,
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 141,
                column: "SpecialProperties",
                value: "Ruheraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 144,
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 145,
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 150,
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 153,
                column: "SpecialProperties",
                value: "Schlafraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 154,
                column: "SpecialProperties",
                value: "Schlafraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 155,
                column: "Description",
                value: "Bühne");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 156,
                column: "SpecialProperties",
                value: "Ruheraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 157,
                column: "SpecialProperties",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 158,
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 162,
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 163,
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 165,
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 166,
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 170,
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 171,
                column: "SpecialProperties",
                value: "Ruheraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 173,
                column: "SpecialProperties",
                value: "Ruheraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 176,
                column: "SpecialProperties",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 177,
                column: "SpecialProperties",
                value: "Ruheraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 179,
                column: "SpecialProperties",
                value: "Ruheraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 181,
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 183,
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 186,
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 187,
                column: "SpecialProperties",
                value: "Schlafraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 188,
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Partyraum" });

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
                column: "SpecialProperties",
                value: "Schlafraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 194,
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 195,
                column: "SpecialProperties",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Ruheraum" });

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
                column: "SpecialProperties",
                value: "Ruheraum");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "762839ae-e99a-4857-ae71-abc7887dbeac", "1780613a-344c-4de4-8b62-01206d771f8b" },
                    { "26d64274-681e-4417-8794-bd7c24f31717", "1f81a31f-28fd-4e75-80d7-6b8fe6db09bd" },
                    { "2433d0da-e3de-4bee-afc6-5eb20d067266", "b5b44ed2-35b7-445c-9974-b9f6d0f0d9c3" },
                    { "ff459a26-1a1a-4c0f-8f12-b45c504926b9", "b9739710-1a41-4b29-9eef-11edcfa4b285" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "762839ae-e99a-4857-ae71-abc7887dbeac", "1780613a-344c-4de4-8b62-01206d771f8b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "26d64274-681e-4417-8794-bd7c24f31717", "1f81a31f-28fd-4e75-80d7-6b8fe6db09bd" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2433d0da-e3de-4bee-afc6-5eb20d067266", "b5b44ed2-35b7-445c-9974-b9f6d0f0d9c3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ff459a26-1a1a-4c0f-8f12-b45c504926b9", "b9739710-1a41-4b29-9eef-11edcfa4b285" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2433d0da-e3de-4bee-afc6-5eb20d067266");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "26d64274-681e-4417-8794-bd7c24f31717");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "762839ae-e99a-4857-ae71-abc7887dbeac");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff459a26-1a1a-4c0f-8f12-b45c504926b9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1780613a-344c-4de4-8b62-01206d771f8b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f81a31f-28fd-4e75-80d7-6b8fe6db09bd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b5b44ed2-35b7-445c-9974-b9f6d0f0d9c3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b9739710-1a41-4b29-9eef-11edcfa4b285");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "Date",
                table: "Occupancies",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0d96d5e3-bc37-42a6-90cb-3b96f861771b", null, "Administrator", "ADMINISTRATOR" },
                    { "40965706-573e-4a60-9eb5-743c2ee01003", null, "Sekretariat", "SEKRETARIAT" },
                    { "7b41768a-a888-4e96-a80f-e593ae59d12f", null, "Abteilungsleiter", "ABTEILUNGSLEITER" },
                    { "7e8307dc-e669-4859-8e87-d15888910d90", null, "Mitarbeiter", "MITARBEITER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "26f71ef1-8cbd-417e-b785-b8f0cf34b8b8", 0, "7705f226-089a-410f-b0ee-3ad3fdce7805", null, false, false, null, null, "MITARBEITER@ABC.COM", "AQAAAAIAAYagAAAAENfII3C1g+rqHbKZkU9zhgFHtFGFzLCrcbw3rw7iT41mgXZfZzXYZwzwbP5jkzhlJA==", null, false, "a024b14a-f123-4427-b7ec-b98e00120416", false, "mitarbeiter@abc.com" },
                    { "2c12e171-0bdb-43aa-b9b6-5ee9180da012", 0, "3b4d50de-eff3-4884-ba0b-a5408895630f", null, false, false, null, null, "SEKRETARIAT@ABC.COM", "AQAAAAIAAYagAAAAEDdo4boWqiSOr3qa3CVR5obxBKkEA1wBe4RKwyHgXs0wNpKaHq9CRY8Dw7aRiGV88Q==", null, false, "ba2c01c1-1532-427c-8663-483ec9b0a7c7", false, "sekretariat@abc.com" },
                    { "adc4badf-0d6f-4218-bcc9-45463abaec82", 0, "84e6a1b2-e6d2-4548-82d9-68877a7e76bb", null, false, false, null, null, "ABTEILUNGSLEITER@ABC.COM", "AQAAAAIAAYagAAAAEAie87jRPYLxjl/9AMaOf1pmrRhPy6Ux6qhMCbFyhTRAFEb4MFYy6g4C6h7fYti6rg==", null, false, "3ab4aebf-34a5-41b8-8370-73299ed1bf82", false, "abteilungsleiter@abc.com" },
                    { "eeba10cd-78fc-4eff-a5cf-482e304eb9a5", 0, "30a2699b-9ad9-4ec7-9dfc-781d99a8a436", null, false, false, null, null, "ADMIN@ABC.COM", "AQAAAAIAAYagAAAAEELXZYqCVVOsCu+aBDfK1PTtsPdLC2arTUbv9EPWfKG04DAkLdZU1PGUeOEGId2sIg==", null, false, "7b895bc1-f0e7-4f76-be86-25f14fd38c30", false, "admin@abc.com" }
                });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Ingrid Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Bernd Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Dieter Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Johann Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Dieter Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Ingrid Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Eva Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Clara Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Eva Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Anton Koch");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Dieter Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Friedrich Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Bernd Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Dieter Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Eva Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Ingrid Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Anton Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Johann Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Friedrich Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Friedrich Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21,
                column: "Name",
                value: "Eva Richter");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Dieter Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Ingrid Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Friedrich Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Dieter Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Johann Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Johann Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Johann Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Bernd Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Ingrid Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Heinz Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Johann Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Eva Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 34,
                column: "Name",
                value: "Johann Becker");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 35,
                column: "Name",
                value: "Heinz Meier");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Clara Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Heinz Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Greta Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 39,
                column: "Name",
                value: "Johann Meier");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Greta Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 41,
                column: "Name",
                value: "Bernd Koch");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Johann Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Bernd Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Bernd Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Anton Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Heinz Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Heinz Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Johann Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 49,
                column: "Name",
                value: "Johann Becker");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Bernd Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Heinz Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Heinz Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Heinz Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Eva Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Bernd Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 56,
                column: "Name",
                value: "Ingrid Bauer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Bernd Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Eva Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Clara Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Dieter Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Friedrich Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Johann Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Johann Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 64,
                column: "Name",
                value: "Bernd Koch");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Johann Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 66,
                column: "Name",
                value: "Greta Bauer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Dieter Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Friedrich Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Anton Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 70,
                column: "Name",
                value: "Greta Müller");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Heinz Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Eva Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Eva Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Dieter Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Clara Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Greta Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 77,
                column: "Name",
                value: "Ingrid Bauer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 78,
                column: "Name",
                value: "Eva Fischer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Ingrid Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 80,
                column: "Name",
                value: "Heinz Schmidt");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Bernd Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Anton Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Johann Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 84,
                column: "Name",
                value: "Bernd Richter");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 85,
                column: "Name",
                value: "Clara Müller");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Heinz Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Heinz Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Johann Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Greta Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Heinz Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 91,
                column: "Name",
                value: "Clara Becker");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Johann Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Greta Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 94,
                column: "Name",
                value: "Ingrid Meier");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Heinz Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 96,
                column: "Name",
                value: "Eva Meier");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Anton Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Dieter Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 99,
                column: "Name",
                value: "Ingrid Müller");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Bernd Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Eva Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Ingrid Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Greta Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Johann Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Anton Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Friedrich Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Johann Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Anton Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 109,
                column: "Name",
                value: "Anton Meier");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Eva Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 111,
                column: "Name",
                value: "Johann Wagner");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Johann Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 113,
                column: "Name",
                value: "Clara Wagner");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Friedrich Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Anton Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Friedrich Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Greta Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Bernd Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 119,
                column: "Name",
                value: "Bernd Fischer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Eva Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 121,
                column: "Name",
                value: "Greta Wagner");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Johann Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Friedrich Meier" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 10,
                column: "Description",
                value: "Tische");

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
                values: new object[] { "Bühne", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Partyraum" });

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
                column: "SpecialProperties",
                value: "Ruheraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 18,
                column: "SpecialProperties",
                value: "Partyraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 20,
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 22,
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Ruheraum" });

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
                values: new object[] { "Stühle", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 29,
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Schlafraum" });

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
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 37,
                column: "SpecialProperties",
                value: "Schlafraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 39,
                column: "Description",
                value: "Schwarzlicht");

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
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 46,
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 48,
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 49,
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 53,
                column: "SpecialProperties",
                value: "Ruheraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 54,
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 55,
                column: "SpecialProperties",
                value: "Ruheraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 56,
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 57,
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 61,
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 64,
                column: "SpecialProperties",
                value: "Schlafraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 67,
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 68,
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 69,
                column: "Description",
                value: "Bühne");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 75,
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 79,
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 83,
                column: "Description",
                value: "Bühne");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 84,
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Ruheraum" });

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
                values: new object[] { "Stühle", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 88,
                column: "Description",
                value: "Bühne");

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
                values: new object[] { "Tische", " " });

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
                column: "SpecialProperties",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 96,
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 97,
                column: "SpecialProperties",
                value: "Ruheraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 100,
                column: "Description",
                value: "Stühle");

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
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 105,
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 109,
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 110,
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 113,
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 115,
                column: "Description",
                value: "Bühne");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 118,
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 119,
                column: "SpecialProperties",
                value: "Partyraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 123,
                column: "SpecialProperties",
                value: "Partyraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 124,
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 125,
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 130,
                column: "SpecialProperties",
                value: "Schlafraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Partyraum" });

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 134,
                column: "SpecialProperties",
                value: "Partyraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 135,
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 136,
                column: "SpecialProperties",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 137,
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 139,
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 141,
                column: "SpecialProperties",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 144,
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 145,
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 150,
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 153,
                column: "SpecialProperties",
                value: " ");

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
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 156,
                column: "SpecialProperties",
                value: "Schlafraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 157,
                column: "SpecialProperties",
                value: "Schlafraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 158,
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 162,
                column: "Description",
                value: "Bühne");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 163,
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 165,
                column: "Description",
                value: "Bühne");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 166,
                column: "Description",
                value: "Schwarzlicht");

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
                values: new object[] { "Bühne", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 170,
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 171,
                column: "SpecialProperties",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 173,
                column: "SpecialProperties",
                value: "Schlafraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 176,
                column: "SpecialProperties",
                value: "Ruheraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 177,
                column: "SpecialProperties",
                value: "Schlafraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 179,
                column: "SpecialProperties",
                value: "Schlafraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 181,
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 183,
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 186,
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 187,
                column: "SpecialProperties",
                value: "Ruheraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 188,
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 191,
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 192,
                column: "SpecialProperties",
                value: "Ruheraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", " " });

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
                column: "SpecialProperties",
                value: "Ruheraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 199,
                column: "SpecialProperties",
                value: "Ruheraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 200,
                column: "SpecialProperties",
                value: "Schlafraum");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "7e8307dc-e669-4859-8e87-d15888910d90", "26f71ef1-8cbd-417e-b785-b8f0cf34b8b8" },
                    { "40965706-573e-4a60-9eb5-743c2ee01003", "2c12e171-0bdb-43aa-b9b6-5ee9180da012" },
                    { "7b41768a-a888-4e96-a80f-e593ae59d12f", "adc4badf-0d6f-4218-bcc9-45463abaec82" },
                    { "0d96d5e3-bc37-42a6-90cb-3b96f861771b", "eeba10cd-78fc-4eff-a5cf-482e304eb9a5" }
                });
        }
    }
}
