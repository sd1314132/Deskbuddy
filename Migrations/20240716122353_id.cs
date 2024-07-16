using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Deskbuddy.Migrations
{
    /// <inheritdoc />
    public partial class id : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Occupancies",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "18faa109-8e54-4a4f-aac4-13f2e34c61ea", null, "Abteilungsleiter", "ABTEILUNGSLEITER" },
                    { "499c83d6-acbe-4aa2-834d-1544f9b12797", null, "Sekretariat", "SEKRETARIAT" },
                    { "8629dc7e-23fb-426c-ba2a-ff69794f5f2d", null, "Mitarbeiter", "MITARBEITER" },
                    { "cbb4674f-e927-4695-a4e4-a7224867b3d2", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "82cd437d-a87f-40c4-a317-ce2317d4113a", 0, "d8b95ff7-e37e-45e1-8e0f-207d7fe1e860", null, false, false, null, null, "MITARBEITER@ABC.COM", "AQAAAAIAAYagAAAAEMPYUb7g4rNb3lLKloc1HWSzMhMfG0lGkL5h9k4wKVuxz4t8c9njiW5KNCU0NS9tbA==", null, false, "24963ddc-e407-4684-b701-ee6b1e44d6c6", false, "mitarbeiter@abc.com" },
                    { "8e8941e2-4301-4179-8796-941d90c2a0f1", 0, "ae21a2f1-d9a0-42db-b09f-89c7c6ce75d9", null, false, false, null, null, "ADMIN@ABC.COM", "AQAAAAIAAYagAAAAEMCv3i/XSzG4BxxaFUdph/cqjw4tMLKx75Tuuagz9lJ6q/upbQ9fjBuaCeF2gra79Q==", null, false, "1c30237e-b726-47e7-8b2b-451c5150893a", false, "admin@abc.com" },
                    { "e8a2b7d2-46ac-4da5-80af-48e76e0cf955", 0, "e77e6daa-9170-4f58-8025-4d424d54c324", null, false, false, null, null, "ABTEILUNGSLEITER@ABC.COM", "AQAAAAIAAYagAAAAEI+nl2gvzlOokJtbF+RDIdn7Wad+QAfcfVuzWMzDROuhSUtleRAI2xkDXvs41e7X5w==", null, false, "9232a77a-9328-40f5-a310-d9e137e5bf6a", false, "abteilungsleiter@abc.com" },
                    { "f2198c63-a1ef-42b4-afe8-d6f908694d8e", 0, "412cd6dc-9a16-4930-96c9-4416c1eacea9", null, false, false, null, null, "SEKRETARIAT@ABC.COM", "AQAAAAIAAYagAAAAEPd96o+7M6gp6T2jb226M202io/y4pR5zaMDj1W/QqoTUxsPqqka92mBhZ4ofKi7Nw==", null, false, "f6ed4d92-9325-45f9-a1f4-013b89717567", false, "sekretariat@abc.com" }
                });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Clara Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Dieter Fischer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Dieter Wagner");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Dieter Schmidt");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Heinz Fischer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Dieter Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Anton Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Eva Schmidt");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Dieter Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Bernd Bauer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Bernd Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Johann Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Greta Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Dieter Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Clara Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16,
                column: "Name",
                value: "Bernd Weber");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Clara Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18,
                column: "Name",
                value: "Greta Richter");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Dieter Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Anton Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21,
                column: "Name",
                value: "Johann Meier");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Heinz Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23,
                column: "Name",
                value: "Dieter Meier");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Eva Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Clara Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Bernd Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 27,
                column: "Name",
                value: "Johann Richter");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Friedrich Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Clara Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Eva Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Eva Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Anton Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Greta Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 34,
                column: "DepartmentId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Ingrid Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Heinz Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Anton Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Greta Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Friedrich Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 40,
                column: "Name",
                value: "Friedrich Schmidt");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Ingrid Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Anton Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 43,
                column: "Name",
                value: "Anton Bauer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Dieter Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Ingrid Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Eva Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Bernd Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Clara Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Johann Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Bernd Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Greta Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Ingrid Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 53,
                column: "Name",
                value: "Dieter Meier");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Clara Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Clara Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Anton Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Heinz Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Clara Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Johann Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Heinz Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 61,
                column: "Name",
                value: "Johann Koch");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Heinz Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Dieter Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Bernd Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Friedrich Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Heinz Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 67,
                column: "Name",
                value: "Bernd Schmidt");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Greta Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Greta Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 70,
                column: "Name",
                value: "Greta Schmidt");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 71,
                column: "Name",
                value: "Clara Koch");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Eva Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Ingrid Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 74,
                column: "Name",
                value: "Johann Becker");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Clara Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Heinz Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Clara Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Bernd Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Dieter Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Friedrich Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 81,
                column: "Name",
                value: "Heinz Schmidt");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Clara Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 83,
                column: "Name",
                value: "Heinz Meier");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 84,
                column: "Name",
                value: "Greta Richter");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Ingrid Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Eva Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 87,
                column: "Name",
                value: "Bernd Bauer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Ingrid Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 89,
                column: "Name",
                value: "Ingrid Becker");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Greta Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Heinz Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Dieter Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Friedrich Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Eva Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Clara Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Ingrid Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Friedrich Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 98,
                column: "Name",
                value: "Heinz Koch");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 99,
                column: "Name",
                value: "Heinz Becker");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Dieter Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 101,
                column: "Name",
                value: "Clara Koch");

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
                values: new object[] { 4, "Ingrid Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 104,
                column: "Name",
                value: "Greta Fischer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Dieter Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Bernd Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Bernd Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Heinz Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Heinz Müller" });

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
                values: new object[] { 1, "Heinz Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Dieter Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 113,
                column: "Name",
                value: "Heinz Müller");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Ingrid Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Dieter Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 116,
                column: "Name",
                value: "Ingrid Becker");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Greta Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Clara Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Friedrich Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Johann Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Ingrid Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Greta Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Johann Fischer" });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 20,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 41,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 47,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 52,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 59,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 62,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 64,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 84,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 105,
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Date", "UserId" },
                values: new object[] { new DateTime(2024, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Bühne");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 7,
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 8,
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 9,
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 12,
                column: "SpecialProperties",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 14,
                column: "SpecialProperties",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 19,
                column: "SpecialProperties",
                value: " ");

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
                values: new object[] { "Schwarzlicht", "Ruheraum" });

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
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 26,
                column: "SpecialProperties",
                value: "Ruheraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Partyraum" });

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
                values: new object[] { "Bühne", "Partyraum" });

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
                values: new object[] { "Beamer", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 35,
                column: "Description",
                value: "Bühne");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Ruheraum" });

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
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 43,
                column: "SpecialProperties",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 44,
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 47,
                column: "SpecialProperties",
                value: "Partyraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 48,
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 49,
                column: "Description",
                value: "Tische");

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 55,
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 56,
                column: "Description",
                value: "Tische");

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
                values: new object[] { "Stühle", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Partyraum" });

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
                values: new object[] { "Stühle", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Ruheraum" });

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
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 70,
                column: "Description",
                value: "Tische");

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
                column: "Description",
                value: "Beamer");

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 78,
                column: "SpecialProperties",
                value: "Schlafraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 82,
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 87,
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Schlafraum" });

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 94,
                column: "Description",
                value: "Beamer");

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
                values: new object[] { "Tische", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 98,
                column: "SpecialProperties",
                value: "Partyraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 99,
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 102,
                column: "Description",
                value: "Bühne");

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
                values: new object[] { "Bühne", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 106,
                column: "SpecialProperties",
                value: "Partyraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", " " });

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
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 112,
                column: "SpecialProperties",
                value: "Partyraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 113,
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 115,
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 117,
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Ruheraum" });

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
                column: "SpecialProperties",
                value: "Ruheraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 125,
                column: "SpecialProperties",
                value: " ");

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
                values: new object[] { "Tische", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 131,
                column: "SpecialProperties",
                value: "Partyraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 135,
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 136,
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 138,
                column: "SpecialProperties",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 139,
                column: "SpecialProperties",
                value: "Partyraum");

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
                values: new object[] { "Bühne", "Ruheraum" });

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
                column: "SpecialProperties",
                value: "Schlafraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 147,
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 148,
                column: "SpecialProperties",
                value: "Ruheraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 149,
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Schlafraum" });

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
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 154,
                column: "SpecialProperties",
                value: "Ruheraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 155,
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Ruheraum" });

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 159,
                column: "Description",
                value: "Bühne");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 160,
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 166,
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 167,
                column: "Description",
                value: "Bühne");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 168,
                column: "SpecialProperties",
                value: "Partyraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 170,
                column: "SpecialProperties",
                value: "Schlafraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 171,
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 172,
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 174,
                column: "SpecialProperties",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 180,
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 181,
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 184,
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 185,
                column: "SpecialProperties",
                value: "Ruheraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 186,
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 190,
                column: "SpecialProperties",
                value: "Partyraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 191,
                column: "SpecialProperties",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 192,
                column: "SpecialProperties",
                value: "Partyraum");

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 199,
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Schlafraum" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "8629dc7e-23fb-426c-ba2a-ff69794f5f2d", "82cd437d-a87f-40c4-a317-ce2317d4113a" },
                    { "cbb4674f-e927-4695-a4e4-a7224867b3d2", "8e8941e2-4301-4179-8796-941d90c2a0f1" },
                    { "18faa109-8e54-4a4f-aac4-13f2e34c61ea", "e8a2b7d2-46ac-4da5-80af-48e76e0cf955" },
                    { "499c83d6-acbe-4aa2-834d-1544f9b12797", "f2198c63-a1ef-42b4-afe8-d6f908694d8e" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Occupancies_UserId",
                table: "Occupancies",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Occupancies_AspNetUsers_UserId",
                table: "Occupancies",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Occupancies_AspNetUsers_UserId",
                table: "Occupancies");

            migrationBuilder.DropIndex(
                name: "IX_Occupancies_UserId",
                table: "Occupancies");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8629dc7e-23fb-426c-ba2a-ff69794f5f2d", "82cd437d-a87f-40c4-a317-ce2317d4113a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cbb4674f-e927-4695-a4e4-a7224867b3d2", "8e8941e2-4301-4179-8796-941d90c2a0f1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "18faa109-8e54-4a4f-aac4-13f2e34c61ea", "e8a2b7d2-46ac-4da5-80af-48e76e0cf955" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "499c83d6-acbe-4aa2-834d-1544f9b12797", "f2198c63-a1ef-42b4-afe8-d6f908694d8e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "18faa109-8e54-4a4f-aac4-13f2e34c61ea");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "499c83d6-acbe-4aa2-834d-1544f9b12797");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8629dc7e-23fb-426c-ba2a-ff69794f5f2d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbb4674f-e927-4695-a4e4-a7224867b3d2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82cd437d-a87f-40c4-a317-ce2317d4113a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e8941e2-4301-4179-8796-941d90c2a0f1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e8a2b7d2-46ac-4da5-80af-48e76e0cf955");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2198c63-a1ef-42b4-afe8-d6f908694d8e");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Occupancies");

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
                column: "Name",
                value: "Heinz Meier");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Anton Richter");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Ingrid Koch");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Greta Meier");

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
                column: "Name",
                value: "Friedrich Müller");

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
                column: "Name",
                value: "Dieter Bauer");

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
                column: "Name",
                value: "Dieter Koch");

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
                column: "Name",
                value: "Ingrid Weber");

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
                column: "Name",
                value: "Bernd Becker");

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
                column: "Name",
                value: "Ingrid Meier");

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
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Dieter Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Dieter Richter" });

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
                column: "Name",
                value: "Clara Koch");

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
                column: "Name",
                value: "Dieter Becker");

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
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Johann Müller" });

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
                column: "Name",
                value: "Bernd Weber");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Friedrich Richter" });

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
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Ingrid Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Johann Koch" });

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
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Greta Koch" });

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
                column: "Name",
                value: "Eva Koch");

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
                column: "Name",
                value: "Eva Fischer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 71,
                column: "Name",
                value: "Johann Schmidt");

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
                column: "Name",
                value: "Heinz Meier");

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
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Bernd Becker" });

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
                column: "Name",
                value: "Ingrid Bauer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 84,
                column: "Name",
                value: "Ingrid Weber");

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
                column: "Name",
                value: "Heinz Weber");

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
                column: "Name",
                value: "Ingrid Bauer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Ingrid Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Johann Richter" });

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
                column: "Name",
                value: "Anton Becker");

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
                column: "Name",
                value: "Bernd Fischer");

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
                column: "Name",
                value: "Heinz Schmidt");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Anton Schmidt" });

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
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Ingrid Müller" });

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
                column: "Name",
                value: "Friedrich Richter");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Heinz Fischer" });

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
                column: "Name",
                value: "Anton Meier");

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
                keyValue: 63,
                column: "Date",
                value: new DateTime(2024, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Schlafraum" });

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
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Ruheraum" });

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
                column: "Description",
                value: "Bühne");

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
                column: "Description",
                value: "Schwarzlicht");

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
                column: "SpecialProperties",
                value: "Ruheraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 14,
                column: "SpecialProperties",
                value: "Schlafraum");

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 19,
                column: "SpecialProperties",
                value: "Schlafraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 20,
                column: "Description",
                value: "Stühle");

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
                column: "Description",
                value: "Beamer");

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
                column: "SpecialProperties",
                value: "Schlafraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Partyraum" });

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
                column: "Description",
                value: "Schwarzlicht");

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Ruheraum" });

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
                values: new object[] { "Beamer", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Schlafraum" });

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
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 43,
                column: "SpecialProperties",
                value: "Schlafraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 44,
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Schlafraum" });

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
                column: "SpecialProperties",
                value: "Schlafraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 48,
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 49,
                column: "Description",
                value: "Bühne");

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 55,
                column: "Description",
                value: "Bühne");

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
                value: "Bühne");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Schlafraum" });

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 61,
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Partyraum" });

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Schlafraum" });

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Ruheraum" });

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
                column: "Description",
                value: "Bühne");

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
                column: "Description",
                value: "Schwarzlicht");

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", " " });

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 78,
                column: "SpecialProperties",
                value: "Ruheraum");

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Partyraum" });

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
                column: "Description",
                value: "Schwarzlicht");

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 87,
                column: "Description",
                value: "Stühle");

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Ruheraum" });

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 94,
                column: "Description",
                value: "Stühle");

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
                column: "SpecialProperties",
                value: "Schlafraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 99,
                column: "Description",
                value: "Bühne");

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
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Schlafraum" });

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
                column: "SpecialProperties",
                value: "Schlafraum");

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
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 110,
                column: "Description",
                value: "Bühne");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 112,
                column: "SpecialProperties",
                value: "Ruheraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 113,
                column: "Description",
                value: "Schwarzlicht");

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
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 117,
                column: "Description",
                value: "Bühne");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 119,
                column: "SpecialProperties",
                value: "Schlafraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 120,
                column: "SpecialProperties",
                value: "Schlafraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Schlafraum" });

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
                column: "SpecialProperties",
                value: "Schlafraum");

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", " " });

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
                column: "SpecialProperties",
                value: "Ruheraum");

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 135,
                column: "Description",
                value: "Bühne");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 136,
                column: "Description",
                value: "Schwarzlicht");

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
                column: "SpecialProperties",
                value: "Schlafraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 139,
                column: "SpecialProperties",
                value: " ");

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Schlafraum" });

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
                keyValue: 146,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 147,
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 148,
                column: "SpecialProperties",
                value: "Partyraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 149,
                column: "Description",
                value: "Beamer");

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
                column: "Description",
                value: "Stühle");

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
                column: "Description",
                value: "Bühne");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 157,
                column: "SpecialProperties",
                value: "Partyraum");

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
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 160,
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", " " });

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Partyraum" });

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
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 168,
                column: "SpecialProperties",
                value: " ");

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
                column: "Description",
                value: "Bühne");

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
                column: "SpecialProperties",
                value: "Ruheraum");

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 180,
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 181,
                column: "Description",
                value: "Bühne");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Partyraum" });

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
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 190,
                column: "SpecialProperties",
                value: "Ruheraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 191,
                column: "SpecialProperties",
                value: "Schlafraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 192,
                column: "SpecialProperties",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Ruheraum" });

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 199,
                column: "Description",
                value: "Bühne");

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
    }
}
