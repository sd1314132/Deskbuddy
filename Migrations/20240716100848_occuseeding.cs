using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Deskbuddy.Migrations
{
    /// <inheritdoc />
    public partial class occuseeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "89dc29d8-7c6d-47b0-b333-6a2b6b9cb9fe", "39a6951d-c1c1-4995-879b-dbd2a7ea8dd7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bc49a7d0-b815-4891-826f-1fd0268cdbdb", "3e384117-0c04-4132-93b1-7259c18eebd0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dc2ccb90-6e7b-4ae5-9dfa-4c04e90644ff", "43b0fd79-d51c-4ff2-a911-61b741096e2f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8e36b2f6-c795-4444-b98b-dc25d21b73fa", "f16a5841-6572-47c7-b607-6f8791f648e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89dc29d8-7c6d-47b0-b333-6a2b6b9cb9fe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e36b2f6-c795-4444-b98b-dc25d21b73fa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc49a7d0-b815-4891-826f-1fd0268cdbdb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc2ccb90-6e7b-4ae5-9dfa-4c04e90644ff");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39a6951d-c1c1-4995-879b-dbd2a7ea8dd7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3e384117-0c04-4132-93b1-7259c18eebd0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43b0fd79-d51c-4ff2-a911-61b741096e2f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f16a5841-6572-47c7-b607-6f8791f648e4");

            migrationBuilder.AddColumn<int>(
                name: "RoomId",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                column: "Name",
                value: "Anton Bauer");

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
                column: "Name",
                value: "Heinz Meier");

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
                column: "Name",
                value: "Friedrich Weber");

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
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Clara Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "Ingrid Meier");

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
                column: "Name",
                value: "Heinz Weber");

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
                column: "Name",
                value: "Greta Bauer");

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
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Heinz Richter" });

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
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Greta Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Johann Bauer" });

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
                column: "Name",
                value: "Eva Richter");

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
                column: "Name",
                value: "Anton Schmidt");

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
                column: "Name",
                value: "Anton Koch");

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
                column: "Name",
                value: "Greta Bauer");

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
                column: "Name",
                value: "Friedrich Wagner");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Greta Becker" });

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
                column: "Name",
                value: "Eva Müller");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Clara Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Friedrich Schmidt" });

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
                column: "Name",
                value: "Dieter Bauer");

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
                column: "Name",
                value: "Johann Bauer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 77,
                column: "Name",
                value: "Clara Müller");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Bernd Wagner" });

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
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Eva Meier" });

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
                column: "Name",
                value: "Ingrid Weber");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 86,
                column: "Name",
                value: "Johann Müller");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 87,
                column: "Name",
                value: "Heinz Meier");

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
                column: "Name",
                value: "Eva Wagner");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Clara Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Friedrich Wagner" });

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
                column: "Name",
                value: "Heinz Koch");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Ingrid Meier" });

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
                column: "Name",
                value: "Ingrid Wagner");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Bernd Schmidt" });

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
                column: "Name",
                value: "Johann Schmidt");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Bernd Bauer" });

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
                column: "Name",
                value: "Friedrich Bauer");

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
                column: "Name",
                value: "Clara Bauer");

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
                column: "Name",
                value: "Friedrich Bauer");

            migrationBuilder.InsertData(
                table: "Occupancies",
                columns: new[] { "Id", "Date", "EmployeeId", "Features", "RoomId", "WorkplaceId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 16, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1270), null, 0, 1, null },
                    { 2, new DateTime(2024, 7, 17, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1329), null, 0, 2, null },
                    { 3, new DateTime(2024, 7, 18, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1345), null, 0, 3, null },
                    { 4, new DateTime(2024, 7, 19, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1360), null, 0, 4, null },
                    { 5, new DateTime(2024, 7, 20, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1375), null, 0, 5, null },
                    { 6, new DateTime(2024, 7, 21, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1394), null, 0, 6, null },
                    { 7, new DateTime(2024, 7, 22, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1410), null, 0, 7, null },
                    { 8, new DateTime(2024, 7, 23, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1425), null, 0, 8, null },
                    { 9, new DateTime(2024, 7, 24, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1461), null, 0, 9, null },
                    { 10, new DateTime(2024, 7, 25, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1476), null, 0, 10, null },
                    { 11, new DateTime(2024, 7, 26, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1493), null, 0, 11, null },
                    { 12, new DateTime(2024, 7, 27, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1508), null, 0, 12, null },
                    { 13, new DateTime(2024, 7, 28, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1522), null, 0, 13, null },
                    { 14, new DateTime(2024, 7, 29, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1538), null, 0, 14, null },
                    { 15, new DateTime(2024, 7, 30, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1552), null, 0, 15, null },
                    { 16, new DateTime(2024, 7, 31, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1573), null, 0, 16, null },
                    { 17, new DateTime(2024, 8, 1, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1589), null, 0, 17, null },
                    { 18, new DateTime(2024, 8, 2, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1605), null, 0, 18, null },
                    { 19, new DateTime(2024, 8, 3, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1620), null, 0, 19, null },
                    { 20, new DateTime(2024, 8, 4, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1634), null, 0, 20, null },
                    { 21, new DateTime(2024, 8, 5, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1649), null, 0, 21, null },
                    { 22, new DateTime(2024, 8, 6, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1663), null, 0, 22, null },
                    { 23, new DateTime(2024, 8, 7, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1678), null, 0, 23, null },
                    { 24, new DateTime(2024, 8, 8, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1693), null, 0, 24, null },
                    { 25, new DateTime(2024, 8, 9, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1708), null, 0, 25, null },
                    { 26, new DateTime(2024, 8, 10, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1724), null, 0, 26, null },
                    { 27, new DateTime(2024, 8, 11, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1738), null, 0, 27, null },
                    { 28, new DateTime(2024, 8, 12, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1752), null, 0, 28, null },
                    { 29, new DateTime(2024, 8, 13, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1767), null, 0, 29, null },
                    { 30, new DateTime(2024, 8, 14, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1784), null, 0, 30, null },
                    { 31, new DateTime(2024, 8, 15, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1817), null, 0, 31, null },
                    { 32, new DateTime(2024, 8, 16, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1833), null, 0, 32, null },
                    { 33, new DateTime(2024, 8, 17, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1849), null, 0, 33, null },
                    { 34, new DateTime(2024, 8, 18, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1865), null, 0, 34, null },
                    { 35, new DateTime(2024, 8, 19, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1900), null, 0, 35, null },
                    { 36, new DateTime(2024, 8, 20, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1916), null, 0, 36, null },
                    { 37, new DateTime(2024, 8, 21, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1932), null, 0, 37, null },
                    { 38, new DateTime(2024, 8, 22, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1947), null, 0, 38, null },
                    { 39, new DateTime(2024, 8, 23, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1962), null, 0, 39, null },
                    { 40, new DateTime(2024, 8, 24, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1977), null, 0, 40, null },
                    { 41, new DateTime(2024, 8, 25, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(1992), null, 0, 41, null },
                    { 42, new DateTime(2024, 8, 26, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2007), null, 0, 42, null },
                    { 43, new DateTime(2024, 8, 27, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2022), null, 0, 43, null },
                    { 44, new DateTime(2024, 8, 28, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2036), null, 0, 44, null },
                    { 45, new DateTime(2024, 8, 29, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2050), null, 0, 45, null },
                    { 46, new DateTime(2024, 8, 30, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2065), null, 0, 46, null },
                    { 47, new DateTime(2024, 8, 31, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2079), null, 0, 47, null },
                    { 48, new DateTime(2024, 9, 1, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2094), null, 0, 48, null },
                    { 49, new DateTime(2024, 9, 2, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2108), null, 0, 49, null },
                    { 50, new DateTime(2024, 9, 3, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2123), null, 0, 50, null },
                    { 51, new DateTime(2024, 9, 4, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2137), null, 0, 51, null },
                    { 52, new DateTime(2024, 9, 5, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2153), null, 0, 52, null },
                    { 53, new DateTime(2024, 9, 6, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2167), null, 0, 53, null },
                    { 54, new DateTime(2024, 9, 7, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2183), null, 0, 54, null },
                    { 55, new DateTime(2024, 9, 8, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2198), null, 0, 55, null },
                    { 56, new DateTime(2024, 9, 9, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2213), null, 0, 56, null },
                    { 57, new DateTime(2024, 9, 10, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2229), null, 0, 57, null },
                    { 58, new DateTime(2024, 9, 11, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2243), null, 0, 58, null },
                    { 59, new DateTime(2024, 9, 12, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2257), null, 0, 59, null },
                    { 60, new DateTime(2024, 9, 13, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2271), null, 0, 60, null },
                    { 61, new DateTime(2024, 9, 14, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2286), null, 0, 61, null },
                    { 62, new DateTime(2024, 9, 15, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2300), null, 0, 62, null },
                    { 63, new DateTime(2024, 9, 16, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2337), null, 0, 63, null },
                    { 64, new DateTime(2024, 9, 17, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2353), null, 0, 64, null },
                    { 65, new DateTime(2024, 9, 18, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2367), null, 0, 65, null },
                    { 66, new DateTime(2024, 9, 19, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2382), null, 0, 66, null },
                    { 67, new DateTime(2024, 9, 20, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2398), null, 0, 67, null },
                    { 68, new DateTime(2024, 9, 21, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2412), null, 0, 68, null },
                    { 69, new DateTime(2024, 9, 22, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2428), null, 0, 69, null },
                    { 70, new DateTime(2024, 9, 23, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2442), null, 0, 70, null },
                    { 71, new DateTime(2024, 9, 24, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2456), null, 0, 71, null },
                    { 72, new DateTime(2024, 9, 25, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2472), null, 0, 72, null },
                    { 73, new DateTime(2024, 9, 26, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2487), null, 0, 73, null },
                    { 74, new DateTime(2024, 9, 27, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2503), null, 0, 74, null },
                    { 75, new DateTime(2024, 9, 28, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2519), null, 0, 75, null },
                    { 76, new DateTime(2024, 9, 29, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2534), null, 0, 76, null },
                    { 77, new DateTime(2024, 9, 30, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2549), null, 0, 77, null },
                    { 78, new DateTime(2024, 10, 1, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2563), null, 0, 78, null },
                    { 79, new DateTime(2024, 10, 2, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2577), null, 0, 79, null },
                    { 80, new DateTime(2024, 10, 3, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2593), null, 0, 80, null },
                    { 81, new DateTime(2024, 10, 4, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2607), null, 0, 81, null },
                    { 82, new DateTime(2024, 10, 5, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2623), null, 0, 82, null },
                    { 83, new DateTime(2024, 10, 6, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2637), null, 0, 83, null },
                    { 84, new DateTime(2024, 10, 7, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2652), null, 0, 84, null },
                    { 85, new DateTime(2024, 10, 8, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2667), null, 0, 85, null },
                    { 86, new DateTime(2024, 10, 9, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2681), null, 0, 86, null },
                    { 87, new DateTime(2024, 10, 10, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2697), null, 0, 87, null },
                    { 88, new DateTime(2024, 10, 11, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2734), null, 0, 88, null },
                    { 89, new DateTime(2024, 10, 12, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2749), null, 0, 89, null },
                    { 90, new DateTime(2024, 10, 13, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2764), null, 0, 90, null },
                    { 91, new DateTime(2024, 10, 14, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2778), null, 0, 91, null },
                    { 92, new DateTime(2024, 10, 15, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2794), null, 0, 92, null },
                    { 93, new DateTime(2024, 10, 16, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2807), null, 0, 93, null },
                    { 94, new DateTime(2024, 10, 17, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2822), null, 0, 94, null },
                    { 95, new DateTime(2024, 10, 18, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2839), null, 0, 95, null },
                    { 96, new DateTime(2024, 10, 19, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2854), null, 0, 96, null },
                    { 97, new DateTime(2024, 10, 20, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2869), null, 0, 97, null },
                    { 98, new DateTime(2024, 10, 21, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2884), null, 0, 98, null },
                    { 99, new DateTime(2024, 10, 22, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2899), null, 0, 99, null },
                    { 100, new DateTime(2024, 10, 23, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2914), null, 0, 100, null },
                    { 101, new DateTime(2024, 10, 24, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2928), null, 0, 101, null },
                    { 102, new DateTime(2024, 10, 25, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2943), null, 0, 102, null },
                    { 103, new DateTime(2024, 10, 26, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2959), null, 0, 103, null },
                    { 104, new DateTime(2024, 10, 27, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2974), null, 0, 104, null },
                    { 105, new DateTime(2024, 10, 28, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(2989), null, 0, 105, null },
                    { 106, new DateTime(2024, 10, 29, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3003), null, 0, 106, null },
                    { 107, new DateTime(2024, 10, 30, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3017), null, 0, 107, null },
                    { 108, new DateTime(2024, 10, 31, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3032), null, 0, 108, null },
                    { 109, new DateTime(2024, 11, 1, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3046), null, 0, 109, null },
                    { 110, new DateTime(2024, 11, 2, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3060), null, 0, 110, null },
                    { 111, new DateTime(2024, 11, 3, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3076), null, 0, 111, null },
                    { 112, new DateTime(2024, 11, 4, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3091), null, 0, 112, null },
                    { 113, new DateTime(2024, 11, 5, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3105), null, 0, 113, null },
                    { 114, new DateTime(2024, 11, 6, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3119), null, 0, 114, null },
                    { 115, new DateTime(2024, 11, 7, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3134), null, 0, 115, null },
                    { 116, new DateTime(2024, 11, 8, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3163), null, 0, 116, null },
                    { 117, new DateTime(2024, 11, 9, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3178), null, 0, 117, null },
                    { 118, new DateTime(2024, 11, 10, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3193), null, 0, 118, null },
                    { 119, new DateTime(2024, 11, 11, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3209), null, 0, 119, null },
                    { 120, new DateTime(2024, 11, 12, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3224), null, 0, 120, null },
                    { 121, new DateTime(2024, 11, 13, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3239), null, 0, 121, null },
                    { 122, new DateTime(2024, 11, 14, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3253), null, 0, 122, null },
                    { 123, new DateTime(2024, 11, 15, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3268), null, 0, 123, null },
                    { 124, new DateTime(2024, 11, 16, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3282), null, 0, 124, null },
                    { 125, new DateTime(2024, 11, 17, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3297), null, 0, 125, null },
                    { 126, new DateTime(2024, 11, 18, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3312), null, 0, 126, null },
                    { 127, new DateTime(2024, 11, 19, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3328), null, 0, 127, null },
                    { 128, new DateTime(2024, 11, 20, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3342), null, 0, 128, null },
                    { 129, new DateTime(2024, 11, 21, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3357), null, 0, 129, null },
                    { 130, new DateTime(2024, 11, 22, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3371), null, 0, 130, null },
                    { 131, new DateTime(2024, 11, 23, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3386), null, 0, 131, null },
                    { 132, new DateTime(2024, 11, 24, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3401), null, 0, 132, null },
                    { 133, new DateTime(2024, 11, 25, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3415), null, 0, 133, null },
                    { 134, new DateTime(2024, 11, 26, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3430), null, 0, 134, null },
                    { 135, new DateTime(2024, 11, 27, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3446), null, 0, 135, null },
                    { 136, new DateTime(2024, 11, 28, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3461), null, 0, 136, null },
                    { 137, new DateTime(2024, 11, 29, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3505), null, 0, 137, null },
                    { 138, new DateTime(2024, 11, 30, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3520), null, 0, 138, null },
                    { 139, new DateTime(2024, 12, 1, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3535), null, 0, 139, null },
                    { 140, new DateTime(2024, 12, 2, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3549), null, 0, 140, null },
                    { 141, new DateTime(2024, 12, 3, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3564), null, 0, 141, null },
                    { 142, new DateTime(2024, 12, 4, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3578), null, 0, 142, null },
                    { 143, new DateTime(2024, 12, 5, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3593), null, 0, 143, null },
                    { 144, new DateTime(2024, 12, 6, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3609), null, 0, 144, null },
                    { 145, new DateTime(2024, 12, 7, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3624), null, 0, 145, null },
                    { 146, new DateTime(2024, 12, 8, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3638), null, 0, 146, null },
                    { 147, new DateTime(2024, 12, 9, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3653), null, 0, 147, null },
                    { 148, new DateTime(2024, 12, 10, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3668), null, 0, 148, null },
                    { 149, new DateTime(2024, 12, 11, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3683), null, 0, 149, null },
                    { 150, new DateTime(2024, 12, 12, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3699), null, 0, 150, null },
                    { 151, new DateTime(2024, 12, 13, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3714), null, 0, 151, null },
                    { 152, new DateTime(2024, 12, 14, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3729), null, 0, 152, null },
                    { 153, new DateTime(2024, 12, 15, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3744), null, 0, 153, null },
                    { 154, new DateTime(2024, 12, 16, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3760), null, 0, 154, null },
                    { 155, new DateTime(2024, 12, 17, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3774), null, 0, 155, null },
                    { 156, new DateTime(2024, 12, 18, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3790), null, 0, 156, null },
                    { 157, new DateTime(2024, 12, 19, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3805), null, 0, 157, null },
                    { 158, new DateTime(2024, 12, 20, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3820), null, 0, 158, null },
                    { 159, new DateTime(2024, 12, 21, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3834), null, 0, 159, null },
                    { 160, new DateTime(2024, 12, 22, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3849), null, 0, 160, null },
                    { 161, new DateTime(2024, 12, 23, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3864), null, 0, 161, null },
                    { 162, new DateTime(2024, 12, 24, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3878), null, 0, 162, null },
                    { 163, new DateTime(2024, 12, 25, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3893), null, 0, 163, null },
                    { 164, new DateTime(2024, 12, 26, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3908), null, 0, 164, null },
                    { 165, new DateTime(2024, 12, 27, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3950), null, 0, 165, null },
                    { 166, new DateTime(2024, 12, 28, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3967), null, 0, 166, null },
                    { 167, new DateTime(2024, 12, 29, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3981), null, 0, 167, null },
                    { 168, new DateTime(2024, 12, 30, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(3997), null, 0, 168, null },
                    { 169, new DateTime(2024, 12, 31, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4012), null, 0, 169, null },
                    { 170, new DateTime(2025, 1, 1, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4026), null, 0, 170, null },
                    { 171, new DateTime(2025, 1, 2, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4040), null, 0, 171, null },
                    { 172, new DateTime(2025, 1, 3, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4055), null, 0, 172, null },
                    { 173, new DateTime(2025, 1, 4, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4071), null, 0, 173, null },
                    { 174, new DateTime(2025, 1, 5, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4086), null, 0, 174, null },
                    { 175, new DateTime(2025, 1, 6, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4102), null, 0, 175, null },
                    { 176, new DateTime(2025, 1, 7, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4117), null, 0, 176, null },
                    { 177, new DateTime(2025, 1, 8, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4132), null, 0, 177, null },
                    { 178, new DateTime(2025, 1, 9, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4147), null, 0, 178, null },
                    { 179, new DateTime(2025, 1, 10, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4162), null, 0, 179, null },
                    { 180, new DateTime(2025, 1, 11, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4178), null, 0, 180, null },
                    { 181, new DateTime(2025, 1, 12, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4192), null, 0, 181, null },
                    { 182, new DateTime(2025, 1, 13, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4207), null, 0, 182, null },
                    { 183, new DateTime(2025, 1, 14, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4222), null, 0, 183, null },
                    { 184, new DateTime(2025, 1, 15, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4236), null, 0, 184, null },
                    { 185, new DateTime(2025, 1, 16, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4251), null, 0, 185, null },
                    { 186, new DateTime(2025, 1, 17, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4266), null, 0, 186, null },
                    { 187, new DateTime(2025, 1, 18, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4281), null, 0, 187, null },
                    { 188, new DateTime(2025, 1, 19, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4297), null, 0, 188, null },
                    { 189, new DateTime(2025, 1, 20, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4311), null, 0, 189, null },
                    { 190, new DateTime(2025, 1, 21, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4327), null, 0, 190, null },
                    { 191, new DateTime(2025, 1, 22, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4342), null, 0, 191, null },
                    { 192, new DateTime(2025, 1, 23, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4357), null, 0, 192, null },
                    { 193, new DateTime(2025, 1, 24, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4373), null, 0, 193, null },
                    { 194, new DateTime(2025, 1, 25, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4413), null, 0, 194, null },
                    { 195, new DateTime(2025, 1, 26, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4429), null, 0, 195, null },
                    { 196, new DateTime(2025, 1, 27, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4444), null, 0, 196, null },
                    { 197, new DateTime(2025, 1, 28, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4459), null, 0, 197, null },
                    { 198, new DateTime(2025, 1, 29, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4475), null, 0, 198, null },
                    { 199, new DateTime(2025, 1, 30, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4489), null, 0, 199, null },
                    { 200, new DateTime(2025, 1, 31, 12, 8, 47, 607, DateTimeKind.Local).AddTicks(4504), null, 0, 200, null }
                });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 13,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 15,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 16,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 17,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 18,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 19,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 20,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 21,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 22,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 23,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 24,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 25,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 26,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 27,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 28,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 29,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 30,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 31,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 32,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 33,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 34,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 35,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 36,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 37,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 38,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 39,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 40,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 41,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 42,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 43,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 44,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 45,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 46,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 47,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 48,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 49,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 50,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 51,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 52,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 53,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 54,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 55,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 56,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 57,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 58,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 59,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 60,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 61,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 62,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 63,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 64,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 65,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 66,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 67,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 68,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 69,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 70,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 71,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 72,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 73,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 74,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 75,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 76,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 77,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 78,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 79,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 80,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 81,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 82,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 83,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 84,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 85,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 86,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 87,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 88,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 89,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 90,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 91,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 92,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 93,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 94,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 95,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 96,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 97,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 98,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 99,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 100,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 101,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 102,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 103,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 104,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 105,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 106,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 107,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 108,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 109,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 110,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 111,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 112,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 113,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 114,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 115,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 116,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 117,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 118,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 119,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 120,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 121,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 122,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 123,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 124,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 125,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 126,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 127,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 128,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 129,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 130,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 131,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 132,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 133,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 134,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 135,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 136,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 137,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 138,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 139,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 140,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 141,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 142,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 143,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 144,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 145,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 146,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 147,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 148,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 149,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 150,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 151,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 152,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 153,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 154,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 155,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 156,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 157,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 158,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 159,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 160,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 161,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 162,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 163,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 164,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 165,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 166,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 167,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 168,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 169,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 170,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 171,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 172,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 173,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 174,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 175,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 176,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 177,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 178,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 179,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 180,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 181,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 182,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 183,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 184,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 185,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 186,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 187,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 188,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 189,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 190,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 191,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 192,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 193,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 194,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 195,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 196,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 197,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 198,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 199,
                column: "RoomId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 200,
                column: "RoomId",
                value: 0);

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
                keyValue: 4,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Ruheraum" });

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
                column: "Description",
                value: "Beamer");

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Schlafraum" });

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
                column: "SpecialProperties",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Schlafraum" });

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
                column: "SpecialProperties",
                value: "Partyraum");

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
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 24,
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 25,
                column: "SpecialProperties",
                value: "Schlafraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 26,
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 27,
                column: "SpecialProperties",
                value: "Partyraum");

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
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 34,
                column: "SpecialProperties",
                value: "Ruheraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", " " });

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Partyraum" });

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
                column: "SpecialProperties",
                value: "Schlafraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Schlafraum" });

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
                column: "SpecialProperties",
                value: " ");

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Partyraum" });

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 51,
                column: "SpecialProperties",
                value: " ");

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", " " });

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Ruheraum" });

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Schlafraum" });

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Ruheraum" });

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Partyraum" });

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
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 65,
                column: "SpecialProperties",
                value: "Ruheraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Partyraum" });

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
                column: "Description",
                value: "Stühle");

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
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 73,
                column: "Description",
                value: "Schwarzlicht");

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
                column: "Description",
                value: "Bühne");

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Schlafraum" });

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
                column: "SpecialProperties",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 84,
                column: "Description",
                value: "Bühne");

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
                values: new object[] { "Stühle", "Schlafraum" });

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", " " });

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
                column: "SpecialProperties",
                value: "Partyraum");

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Partyraum" });

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 100,
                column: "SpecialProperties",
                value: "Schlafraum");

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 104,
                column: "SpecialProperties",
                value: "Partyraum");

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 108,
                column: "SpecialProperties",
                value: "Partyraum");

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
                column: "SpecialProperties",
                value: "Ruheraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 111,
                column: "Description",
                value: "Tische");

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
                column: "SpecialProperties",
                value: "Ruheraum");

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Partyraum" });

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
                values: new object[] { "Tische", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Schlafraum" });

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
                column: "SpecialProperties",
                value: "Partyraum");

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
                column: "SpecialProperties",
                value: "Schlafraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 128,
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 130,
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 131,
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 132,
                column: "SpecialProperties",
                value: "Ruheraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Ruheraum" });

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
                column: "SpecialProperties",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 140,
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 141,
                column: "SpecialProperties",
                value: "Schlafraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 143,
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 144,
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Partyraum" });

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", " " });

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
                column: "Description",
                value: "Bühne");

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
                column: "Description",
                value: "Bühne");

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Schlafraum" });

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
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 159,
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 160,
                column: "Description",
                value: "Beamer");

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 165,
                column: "SpecialProperties",
                value: "Partyraum");

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", " " });

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
                column: "SpecialProperties",
                value: "Ruheraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 173,
                column: "Description",
                value: "Bühne");

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
                column: "SpecialProperties",
                value: " ");

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Partyraum" });

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
                column: "SpecialProperties",
                value: "Ruheraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 182,
                column: "Description",
                value: "Beamer");

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
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 187,
                column: "SpecialProperties",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Partyraum" });

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Schlafraum" });

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Ruheraum" });

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
                values: new object[] { "Bühne", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 197,
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 198,
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 200,
                column: "Description",
                value: "Schwarzlicht");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Occupancies",
                keyColumn: "Id",
                keyValue: 200);

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

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "Rooms");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "89dc29d8-7c6d-47b0-b333-6a2b6b9cb9fe", null, "Administrator", "ADMINISTRATOR" },
                    { "8e36b2f6-c795-4444-b98b-dc25d21b73fa", null, "Abteilungsleiter", "ABTEILUNGSLEITER" },
                    { "bc49a7d0-b815-4891-826f-1fd0268cdbdb", null, "Mitarbeiter", "MITARBEITER" },
                    { "dc2ccb90-6e7b-4ae5-9dfa-4c04e90644ff", null, "Sekretariat", "SEKRETARIAT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "39a6951d-c1c1-4995-879b-dbd2a7ea8dd7", 0, "ed687699-dcd2-40c5-96a2-499271a27cd5", null, false, false, null, null, "ADMIN@ABC.COM", "AQAAAAIAAYagAAAAEKY8jEfa0xE4mq+TT1HA+ZJYHdgxkD3VWQwdzgq2vvHawExHsewhyI0LgCOjvOpxWQ==", null, false, "80faaf8e-4157-488d-b8ad-95bda6b71970", false, "admin@abc.com" },
                    { "3e384117-0c04-4132-93b1-7259c18eebd0", 0, "0d2d3902-291e-4682-b206-d10377655da7", null, false, false, null, null, "MITARBEITER@ABC.COM", "AQAAAAIAAYagAAAAEAOXXGl61WBqvfR/fx9cfgBBSo/wjk8EfjC7kao42qKyWgh6h9tYYdk8v9YS4beLfA==", null, false, "c26037b5-1b85-4198-9c9f-4956f9157e9f", false, "mitarbeiter@abc.com" },
                    { "43b0fd79-d51c-4ff2-a911-61b741096e2f", 0, "21cdb555-daeb-4aad-a364-2a64da3e4db2", null, false, false, null, null, "SEKRETARIAT@ABC.COM", "AQAAAAIAAYagAAAAENBB85oWRrkS99yWYiEe7kT130udhmH/kv/TvTURMPc7lbkov9beMudsVk2EaEQSPg==", null, false, "b0274c52-e795-461d-8110-a9cb5b602488", false, "sekretariat@abc.com" },
                    { "f16a5841-6572-47c7-b607-6f8791f648e4", 0, "fd9fde8a-8a95-410d-8b53-89b477af43df", null, false, false, null, null, "ABTEILUNGSLEITER@ABC.COM", "AQAAAAIAAYagAAAAEKOMNKlyCHKQ+23OtcA2YZuaXUYgKgbWxuixyotk7fYcYvvSw4BzVzHWb8uYUyLZuQ==", null, false, "672d2460-3e39-4ef6-ba10-430bd5e0c197", false, "abteilungsleiter@abc.com" }
                });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Greta Koch");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Dieter Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Friedrich Becker");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Eva Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Anton Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Greta Koch");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Ingrid Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Anton Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Dieter Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Johann Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "Clara Meier");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Bernd Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Friedrich Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Ingrid Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Johann Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Clara Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Eva Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Ingrid Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Eva Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Heinz Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21,
                column: "Name",
                value: "Bernd Meier");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Greta Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Johann Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Friedrich Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Friedrich Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Johann Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Eva Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Heinz Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Eva Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Greta Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Ingrid Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 32,
                column: "Name",
                value: "Anton Müller");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Eva Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Johann Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Johann Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Eva Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Johann Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Greta Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 39,
                column: "Name",
                value: "Johann Richter");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Dieter Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Johann Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 42,
                column: "Name",
                value: "Eva Becker");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Eva Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 44,
                column: "Name",
                value: "Clara Bauer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Greta Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Dieter Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Heinz Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Anton Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Greta Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 50,
                column: "Name",
                value: "Ingrid Weber");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 51,
                column: "Name",
                value: "Eva Weber");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Eva Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 53,
                column: "Name",
                value: "Greta Wagner");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Eva Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Friedrich Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Bernd Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 57,
                column: "Name",
                value: "Heinz Becker");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 58,
                column: "Name",
                value: "Greta Meier");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 59,
                column: "Name",
                value: "Heinz Bauer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Ingrid Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Greta Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Ingrid Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Friedrich Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Bernd Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Bernd Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Greta Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Friedrich Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Heinz Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Ingrid Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 70,
                column: "Name",
                value: "Heinz Bauer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Dieter Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Johann Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Greta Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Friedrich Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Ingrid Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 76,
                column: "Name",
                value: "Greta Weber");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 77,
                column: "Name",
                value: "Ingrid Weber");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Eva Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Ingrid Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Bernd Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Johann Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Heinz Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Anton Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Anton Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 85,
                column: "Name",
                value: "Friedrich Fischer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 86,
                column: "Name",
                value: "Bernd Müller");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 87,
                column: "Name",
                value: "Anton Richter");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Anton Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 89,
                column: "Name",
                value: "Ingrid Fischer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Johann Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Bernd Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Friedrich Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Anton Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Bernd Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Eva Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Heinz Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Johann Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 98,
                column: "Name",
                value: "Friedrich Fischer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Greta Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Friedrich Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Clara Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Johann Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Friedrich Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 104,
                column: "Name",
                value: "Heinz Bauer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Anton Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Eva Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 107,
                column: "Name",
                value: "Bernd Meier");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Friedrich Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Clara Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Dieter Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Clara Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Dieter Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 113,
                column: "Name",
                value: "Bernd Fischer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Heinz Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Johann Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 116,
                column: "Name",
                value: "Heinz Wagner");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Bernd Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Ingrid Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Johann Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 120,
                column: "Name",
                value: "Greta Bauer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Friedrich Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Anton Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 123,
                column: "Name",
                value: "Clara Wagner");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", " " });

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
                values: new object[] { "Bühne", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Schlafraum" });

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
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", " " });

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 13,
                column: "SpecialProperties",
                value: "Schlafraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 18,
                column: "Description",
                value: "Tische");

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
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 23,
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 24,
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 25,
                column: "SpecialProperties",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 26,
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 27,
                column: "SpecialProperties",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Ruheraum" });

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
                values: new object[] { "Stühle", "Partyraum" });

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
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 34,
                column: "SpecialProperties",
                value: "Schlafraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 38,
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", " " });

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
                column: "SpecialProperties",
                value: "Ruheraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 44,
                column: "SpecialProperties",
                value: "Partyraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 51,
                column: "SpecialProperties",
                value: "Schlafraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 53,
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Partyraum" });

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
                values: new object[] { "Beamer", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 64,
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 65,
                column: "SpecialProperties",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Partyraum" });

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
                values: new object[] { "Stühle", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 72,
                column: "Description",
                value: "Bühne");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 73,
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 74,
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 77,
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 83,
                column: "SpecialProperties",
                value: "Partyraum");

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
                values: new object[] { "Beamer", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", " " });

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 91,
                column: "SpecialProperties",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 92,
                column: "SpecialProperties",
                value: " ");

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
                values: new object[] { "Bühne", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 100,
                column: "SpecialProperties",
                value: "Partyraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 104,
                column: "SpecialProperties",
                value: "Schlafraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 108,
                column: "SpecialProperties",
                value: "Schlafraum");

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
                column: "SpecialProperties",
                value: "Partyraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 111,
                column: "Description",
                value: "Bühne");

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
                column: "SpecialProperties",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Schlafraum" });

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
                values: new object[] { "Schwarzlicht", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Ruheraum" });

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
                values: new object[] { "Schwarzlicht", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 124,
                column: "SpecialProperties",
                value: "Ruheraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 127,
                column: "SpecialProperties",
                value: "Partyraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 128,
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 130,
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 131,
                column: "Description",
                value: "Bühne");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 132,
                column: "SpecialProperties",
                value: "Partyraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Ruheraum" });

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
                column: "Description",
                value: "Tische");

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
                values: new object[] { "Schwarzlicht", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 143,
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 144,
                column: "Description",
                value: "Bühne");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Partyraum" });

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 152,
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 153,
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 154,
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Schlafraum" });

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
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 160,
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 165,
                column: "SpecialProperties",
                value: "Schlafraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 171,
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 172,
                column: "SpecialProperties",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 173,
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 174,
                column: "SpecialProperties",
                value: "Partyraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 175,
                column: "SpecialProperties",
                value: "Ruheraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 181,
                column: "SpecialProperties",
                value: "Partyraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 182,
                column: "Description",
                value: "Tische");

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
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 187,
                column: "SpecialProperties",
                value: "Ruheraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Schlafraum" });

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", " " });

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", " " });

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
                values: new object[] { "Tische", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 197,
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 198,
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 200,
                column: "Description",
                value: "Stühle");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "89dc29d8-7c6d-47b0-b333-6a2b6b9cb9fe", "39a6951d-c1c1-4995-879b-dbd2a7ea8dd7" },
                    { "bc49a7d0-b815-4891-826f-1fd0268cdbdb", "3e384117-0c04-4132-93b1-7259c18eebd0" },
                    { "dc2ccb90-6e7b-4ae5-9dfa-4c04e90644ff", "43b0fd79-d51c-4ff2-a911-61b741096e2f" },
                    { "8e36b2f6-c795-4444-b98b-dc25d21b73fa", "f16a5841-6572-47c7-b607-6f8791f648e4" }
                });
        }
    }
}
