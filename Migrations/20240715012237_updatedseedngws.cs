using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Deskbuddy.Migrations
{
    /// <inheritdoc />
    public partial class updatedseedngws : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4a0e03c5-9476-4260-8471-ab57ee32d8cb", "19e91c87-186f-40c2-9694-34695c4bacb2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5b1a2e36-19ed-43e8-8b92-74d8bd606cee", "9f3be6d0-c21f-4772-8502-b64a1d7ff1bf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72a2e83a-2884-4355-b32d-56ae2d536601", "d36bad40-97cb-4f3a-a09d-4d71df570a97" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e31b9502-193d-4c44-a518-9b0b91989759", "d9bf8141-190e-4f30-9107-fedee3fe22ce" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a0e03c5-9476-4260-8471-ab57ee32d8cb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b1a2e36-19ed-43e8-8b92-74d8bd606cee");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "72a2e83a-2884-4355-b32d-56ae2d536601");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e31b9502-193d-4c44-a518-9b0b91989759");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19e91c87-186f-40c2-9694-34695c4bacb2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9f3be6d0-c21f-4772-8502-b64a1d7ff1bf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d36bad40-97cb-4f3a-a09d-4d71df570a97");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d9bf8141-190e-4f30-9107-fedee3fe22ce");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2a799a2d-1c4b-4d87-8727-1079c7e14ae0", null, "Administrator", "ADMINISTRATOR" },
                    { "6eda35b8-f223-47d6-a071-41a78ac82a85", null, "Sekretariat", "SEKRETARIAT" },
                    { "b033469e-f231-431d-9038-b01b9d7c8842", null, "Abteilungsleiter", "ABTEILUNGSLEITER" },
                    { "dd48bd37-a5ff-4fe7-bc0a-3aebb682f69f", null, "Mitarbeiter", "MITARBEITER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "359f1dc0-15b7-49ce-a66f-5f4b27243cb1", 0, "6855bc58-083c-4787-a35b-d9d63d2084c0", null, false, false, null, null, "SEKRETARIAT@ABC.COM", "AQAAAAIAAYagAAAAEFDA3ziNkzTzcFqm4BvFt39p5SciStDInU1kvpuTDTpU0tHrpIjfxNABre22GlwxPQ==", null, false, "0b12dd05-4fa9-4bf3-962e-9148c2bf5691", false, "sekretariat@abc.com" },
                    { "668c6359-4be4-43d8-9be3-76a2878092b4", 0, "7efcd397-af61-4cf3-973c-ccb8199f08a9", null, false, false, null, null, "ADMIN@ABC.COM", "AQAAAAIAAYagAAAAENcTjThb4q1Hj/m7lVOWa48UDEI+LVGFRli5yJ6fga9DEYTyi+tvSWQ81K7M6eef1A==", null, false, "6569d6a0-7be3-44c1-97e1-494f1afba938", false, "admin@abc.com" },
                    { "dad7f64c-d15d-467a-be3f-d0feb092c9b4", 0, "8a0f7830-29fd-4390-860f-2b725fec9074", null, false, false, null, null, "MITARBEITER@ABC.COM", "AQAAAAIAAYagAAAAEJBim4MbLXXN9qJ8qkXwZgKy2audRhMisK4LVD/EN8MksAIcg0Vzv0QQoLP55iEC6Q==", null, false, "1bee6471-7030-4b1f-8b35-f1f44c709acb", false, "mitarbeiter@abc.com" },
                    { "db81f63a-b4ef-4e34-b9a0-de7cc752d2b1", 0, "8415fcb5-f73c-4cb1-831f-d00ea0906102", null, false, false, null, null, "ABTEILUNGSLEITER@ABC.COM", "AQAAAAIAAYagAAAAELVa+Qa1uroOK45jsaGUj9XFUCJgZUYTVjYCj62DoODrgsCFx/bdx9OeIrPN1GY/fA==", null, false, "f73e5642-abeb-42ff-b2b4-ce24f129c89f", false, "abteilungsleiter@abc.com" }
                });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Eva Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Dieter Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Eva Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Johann Bauer" });

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
                values: new object[] { 1, "Dieter Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Eva Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Greta Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Dieter Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Clara Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "Anton Koch");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12,
                column: "Name",
                value: "Johann Weber");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13,
                column: "Name",
                value: "Heinz Meier");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Greta Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Greta Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Friedrich Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17,
                column: "Name",
                value: "Eva Richter");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Greta Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Johann Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Heinz Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Bernd Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22,
                column: "Name",
                value: "Clara Fischer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Dieter Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Ingrid Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 25,
                column: "Name",
                value: "Bernd Richter");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 26,
                column: "Name",
                value: "Greta Koch");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Friedrich Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 28,
                column: "Name",
                value: "Clara Becker");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 29,
                column: "Name",
                value: "Bernd Richter");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 30,
                column: "Name",
                value: "Friedrich Meier");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Heinz Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Dieter Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Johann Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 34,
                column: "Name",
                value: "Greta Weber");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Heinz Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Heinz Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Clara Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Eva Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Clara Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Dieter Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Anton Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Ingrid Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Dieter Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Clara Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Bernd Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 46,
                column: "Name",
                value: "Bernd Fischer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Dieter Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 48,
                column: "Name",
                value: "Heinz Müller");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Clara Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Clara Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Dieter Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 52,
                column: "Name",
                value: "Bernd Richter");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Ingrid Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Eva Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Anton Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Friedrich Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Greta Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Johann Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Ingrid Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Clara Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Heinz Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 62,
                column: "Name",
                value: "Heinz Fischer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Greta Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Johann Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Friedrich Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 66,
                column: "Name",
                value: "Johann Meier");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Johann Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Greta Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Greta Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Dieter Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Ingrid Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Friedrich Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Ingrid Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Friedrich Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Anton Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Greta Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 77,
                column: "Name",
                value: "Eva Fischer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 78,
                column: "Name",
                value: "Ingrid Koch");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Dieter Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Greta Schmidt" });

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
                column: "Name",
                value: "Eva Becker");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 83,
                column: "Name",
                value: "Heinz Weber");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 84,
                column: "Name",
                value: "Ingrid Wagner");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Bernd Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Greta Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Bernd Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Bernd Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 89,
                column: "Name",
                value: "Eva Becker");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Heinz Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Greta Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Ingrid Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Dieter Fischer" });

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
                values: new object[] { 3, "Clara Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Eva Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 97,
                column: "Name",
                value: "Eva Bauer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Heinz Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Ingrid Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Clara Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 101,
                column: "Name",
                value: "Johann Schmidt");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Clara Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Clara Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 104,
                column: "Name",
                value: "Dieter Meier");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Johann Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Greta Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Eva Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Anton Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Bernd Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Anton Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Eva Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Eva Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Greta Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Eva Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Friedrich Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 116,
                column: "Name",
                value: "Johann Meier");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Heinz Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Dieter Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 119,
                column: "Name",
                value: "Greta Koch");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 120,
                column: "Name",
                value: "Greta Fischer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Ingrid Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Bernd Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Anton Müller" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 1, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 2, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Tische", 3, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 4, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Schwarzlicht", 5 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Tische", 6 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 7, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Tische", 8, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 9, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Beamer", 10, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Beamer", 11, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Beamer", 12, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", 13, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Beamer", 14, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Tische", 15, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Stühle", 16, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", 17, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Stühle", 18, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", 19, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", 20, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 21, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Bühne", 22, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Beamer", 23, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 24,
                column: "RoomId",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Stühle", 25 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 26,
                column: "RoomId",
                value: 26);

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Stühle", 27, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Bühne", 28 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 29, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Bühne", 30, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Stühle", 31, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Tische", 32, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 33, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Bühne", 34 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Stühle", 35 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Schwarzlicht", 36 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Beamer", 37, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Tische", 38, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Stühle", 39, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 40, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", 41, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Stühle", 42, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Bühne", 43 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", 44, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Tische", 45, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 46, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Bühne", 47, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Beamer", 48, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 49, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Tische", 50, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Beamer", 51, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Tische", 52 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", 53, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 54,
                column: "RoomId",
                value: 54);

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 55, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Bühne", 56, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Stühle", 57, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Bühne", 58 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Beamer", 59 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Tische", 60 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Stühle", 61 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Tische", 62, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Beamer", 63, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Stühle", 64, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Beamer", 65 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", 66, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Beamer", 67, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Bühne", 68 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 69, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Tische", 70, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 71, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 72, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Beamer", 73, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Schwarzlicht", 74 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Beamer", 75 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 76, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Bühne", 77, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Tische", 78, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Stühle", 79, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Stühle", 80, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Tische", 81, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Stühle", 82, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Stühle", 83, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", 84, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", 85, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Tische", 86 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Bühne", 87, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 88, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Beamer", 89, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Tische", 90 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Beamer", 91, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Bühne", 92, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 93, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 94, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 95, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Tische", 96, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Tische", 97 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Beamer", 98, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 99, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Stühle", 100, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Bühne", 101, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Tische", 102, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Stühle", 103, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Stühle", 104 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Tische", 105, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", 106, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Tische", 107 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Stühle", 108, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Bühne", 109, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Stühle", 110, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", 111, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Stühle", 112, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Bühne", 113 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Tische", 114 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 115, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Tische", 116 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Bühne", 117, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Bühne", 118, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Tische", 119, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Stühle", 120, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Beamer", 121, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 122,
                column: "RoomId",
                value: 122);

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Schwarzlicht", 123 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Tische", 124, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Tische", 125, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", 126, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Stühle", 127, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Bühne", 128 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Stühle", 129, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 130, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Tische", 131, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Bühne", 132, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Tische", 133 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Schwarzlicht", 134 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Beamer", 135, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 136, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Tische", 137, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", 138, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", 139, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Stühle", 140, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Beamer", 141 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Beamer", 142, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 143,
                column: "RoomId",
                value: 143);

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 144, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Beamer", 145, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Bühne", 146, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Bühne", 147, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", 148, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Tische", 149, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 150, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Stühle", 151, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", 152, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Beamer", 153, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 154, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Tische", 155, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Stühle", 156, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Bühne", 157, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Beamer", 158, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Tische", 159, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 160, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Tische", 161, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 162,
                column: "RoomId",
                value: 162);

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Beamer", 163, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", 164, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Bühne", 165 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 166, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Beamer", 167, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Tische", 168 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Bühne", 169, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Stühle", 170, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Beamer", 171, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Bühne", 172, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Tische", 173, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Bühne", 174, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 175, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Tische", 176 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Tische", 177, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Schwarzlicht", 178 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Stühle", 179 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Stühle", 180, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Stühle", 181, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Beamer", 182, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", 183, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 184,
                column: "RoomId",
                value: 184);

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 185, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Beamer", 186, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 187,
                column: "RoomId",
                value: 187);

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Tische", 188, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 189, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Beamer", 190 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Beamer", 191, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Tische", 193 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Bühne", 194 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", 195, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", 196, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Beamer", 197 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 198, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Tische", 199, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Bühne", 200 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "6eda35b8-f223-47d6-a071-41a78ac82a85", "359f1dc0-15b7-49ce-a66f-5f4b27243cb1" },
                    { "2a799a2d-1c4b-4d87-8727-1079c7e14ae0", "668c6359-4be4-43d8-9be3-76a2878092b4" },
                    { "dd48bd37-a5ff-4fe7-bc0a-3aebb682f69f", "dad7f64c-d15d-467a-be3f-d0feb092c9b4" },
                    { "b033469e-f231-431d-9038-b01b9d7c8842", "db81f63a-b4ef-4e34-b9a0-de7cc752d2b1" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6eda35b8-f223-47d6-a071-41a78ac82a85", "359f1dc0-15b7-49ce-a66f-5f4b27243cb1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2a799a2d-1c4b-4d87-8727-1079c7e14ae0", "668c6359-4be4-43d8-9be3-76a2878092b4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dd48bd37-a5ff-4fe7-bc0a-3aebb682f69f", "dad7f64c-d15d-467a-be3f-d0feb092c9b4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b033469e-f231-431d-9038-b01b9d7c8842", "db81f63a-b4ef-4e34-b9a0-de7cc752d2b1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2a799a2d-1c4b-4d87-8727-1079c7e14ae0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6eda35b8-f223-47d6-a071-41a78ac82a85");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b033469e-f231-431d-9038-b01b9d7c8842");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dd48bd37-a5ff-4fe7-bc0a-3aebb682f69f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "359f1dc0-15b7-49ce-a66f-5f4b27243cb1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "668c6359-4be4-43d8-9be3-76a2878092b4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dad7f64c-d15d-467a-be3f-d0feb092c9b4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db81f63a-b4ef-4e34-b9a0-de7cc752d2b1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4a0e03c5-9476-4260-8471-ab57ee32d8cb", null, "Mitarbeiter", "MITARBEITER" },
                    { "5b1a2e36-19ed-43e8-8b92-74d8bd606cee", null, "Sekretariat", "SEKRETARIAT" },
                    { "72a2e83a-2884-4355-b32d-56ae2d536601", null, "Abteilungsleiter", "ABTEILUNGSLEITER" },
                    { "e31b9502-193d-4c44-a518-9b0b91989759", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "19e91c87-186f-40c2-9694-34695c4bacb2", 0, "9f92faec-fcbd-4730-9bf3-cec4ccacbdc9", null, false, false, null, null, "MITARBEITER@ABC.COM", "AQAAAAIAAYagAAAAEGtPmOIKSTWtF/pYLosWnRfYbQC0ypWIup1vpuvVY9HkwTnTjSnHcGDJmoZf7nHrzg==", null, false, "d5521e9c-4ab2-4b36-a6d9-97e331f42c2b", false, "mitarbeiter@abc.com" },
                    { "9f3be6d0-c21f-4772-8502-b64a1d7ff1bf", 0, "63ec2d0e-6206-4394-a4c0-6256a3983a3c", null, false, false, null, null, "SEKRETARIAT@ABC.COM", "AQAAAAIAAYagAAAAEDvPf4yLz5Lbth/W0rosMnrb1O1m8gzOyxSHzGUkDUNKbpgxvxTE1EUpJ/qC1tn/og==", null, false, "ebae883d-7cda-46c2-8c2a-b6d4f18dcafd", false, "sekretariat@abc.com" },
                    { "d36bad40-97cb-4f3a-a09d-4d71df570a97", 0, "2bf34a48-b6f8-4c61-aaaa-1bc29dda7cdc", null, false, false, null, null, "ABTEILUNGSLEITER@ABC.COM", "AQAAAAIAAYagAAAAELaUu5ktCKxadpWbFFhRSNGxirJ19pHAS34jFIk0x9ev8xddzeLq/7+kUWoxvcBKkQ==", null, false, "f05782f7-17bf-43d3-9843-0af63739916c", false, "abteilungsleiter@abc.com" },
                    { "d9bf8141-190e-4f30-9107-fedee3fe22ce", 0, "8e7abc98-dcdc-4169-a119-e5806f963785", null, false, false, null, null, "ADMIN@ABC.COM", "AQAAAAIAAYagAAAAEHNTLcI1KbCC2CviL0GeidhITfvjp7dY1YF+nzabFlCS2RtosaGOOzzn8qnzbaF1Kw==", null, false, "8834244a-5f6b-4c3d-bddc-2c6bc8fe6669", false, "admin@abc.com" }
                });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Bernd Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Eva Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Johann Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Clara Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Greta Bauer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Ingrid Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Heinz Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Heinz Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Greta Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Friedrich Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "Clara Wagner");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12,
                column: "Name",
                value: "Ingrid Weber");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13,
                column: "Name",
                value: "Clara Koch");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Dieter Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Ingrid Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Ingrid Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17,
                column: "Name",
                value: "Greta Becker");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Greta Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Greta Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Johann Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Clara Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22,
                column: "Name",
                value: "Clara Weber");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Eva Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Ingrid Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 25,
                column: "Name",
                value: "Anton Weber");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 26,
                column: "Name",
                value: "Bernd Schmidt");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Friedrich Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 28,
                column: "Name",
                value: "Dieter Wagner");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 29,
                column: "Name",
                value: "Friedrich Becker");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 30,
                column: "Name",
                value: "Eva Weber");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Dieter Becker" });

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
                values: new object[] { 1, "Heinz Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 34,
                column: "Name",
                value: "Heinz Weber");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Heinz Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Clara Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Johann Wagner" });

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
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Clara Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Anton Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Bernd Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Johann Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Bernd Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Friedrich Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Eva Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 46,
                column: "Name",
                value: "Dieter Koch");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Ingrid Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 48,
                column: "Name",
                value: "Johann Schmidt");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Heinz Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Heinz Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Friedrich Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 52,
                column: "Name",
                value: "Eva Müller");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Anton Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Johann Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Ingrid Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Clara Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Friedrich Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Clara Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Clara Wagner" });

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
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Friedrich Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 62,
                column: "Name",
                value: "Dieter Fischer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Dieter Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Dieter Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Dieter Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 66,
                column: "Name",
                value: "Ingrid Schmidt");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Ingrid Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Johann Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Clara Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Clara Müller" });

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
                values: new object[] { 1, "Bernd Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Dieter Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Eva Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Eva Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Ingrid Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 77,
                column: "Name",
                value: "Johann Weber");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 78,
                column: "Name",
                value: "Eva Richter");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Clara Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Dieter Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Greta Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 82,
                column: "Name",
                value: "Bernd Müller");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 83,
                column: "Name",
                value: "Friedrich Fischer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 84,
                column: "Name",
                value: "Clara Schmidt");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Friedrich Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Eva Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Anton Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Anton Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 89,
                column: "Name",
                value: "Johann Meier");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Clara Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Clara Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Clara Schmidt" });

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
                values: new object[] { 4, "Dieter Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Eva Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Clara Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 97,
                column: "Name",
                value: "Clara Richter");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Johann Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Ingrid Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Anton Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 101,
                column: "Name",
                value: "Bernd Weber");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Ingrid Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Friedrich Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 104,
                column: "Name",
                value: "Ingrid Meier");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Bernd Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Clara Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Greta Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Ingrid Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Dieter Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Greta Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Clara Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Clara Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Friedrich Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Eva Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Bernd Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 116,
                column: "Name",
                value: "Johann Wagner");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Eva Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Bernd Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 119,
                column: "Name",
                value: "Anton Schmidt");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 120,
                column: "Name",
                value: "Anton Bauer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Heinz Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Clara Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Heinz Koch" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 192, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 192, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Bühne", 192, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 192, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Tische", 192 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Schwarzlicht", 192 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 192, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Stühle", 192, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 192, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Stühle", 192, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Stühle", 192, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", 192, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Tische", 192, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Bühne", 192, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Beamer", 192, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Tische", 192, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Tische", 192, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Bühne", 192, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Bühne", 192, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Stühle", 192, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 192, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Beamer", 192, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", 192, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 24,
                column: "RoomId",
                value: 192);

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Schwarzlicht", 192 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 26,
                column: "RoomId",
                value: 192);

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", 192, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Stühle", 192 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 192, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Tische", 192, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", 192, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Bühne", 192, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 192, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Beamer", 192 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Tische", 192 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Stühle", 192 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Stühle", 192, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", 192, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Bühne", 192, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 192, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Bühne", 192, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Beamer", 192, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Beamer", 192 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Stühle", 192, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Beamer", 192, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 192, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Stühle", 192, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Stühle", 192, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 192, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Stühle", 192, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", 192, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Beamer", 192 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Stühle", 192, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 54,
                column: "RoomId",
                value: 192);

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 192, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Stühle", 192, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Bühne", 192, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Stühle", 192 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Tische", 192 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Schwarzlicht", 192 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Beamer", 192 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Bühne", 192, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Bühne", 192, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Tische", 192, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Tische", 192 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Tische", 192, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", 192, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Stühle", 192 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 192, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Bühne", 192, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 192, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 192, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Bühne", 192, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Beamer", 192 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Bühne", 192 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 192, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", 192, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Beamer", 192, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Tische", 192, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", 192, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Beamer", 192, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Beamer", 192, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", 192, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Beamer", 192, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Stühle", 192, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Beamer", 192 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Stühle", 192, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 192, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", 192, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Schwarzlicht", 192 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Bühne", 192, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Tische", 192, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 192, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 192, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 192, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Beamer", 192, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Schwarzlicht", 192 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Tische", 192, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 192, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Bühne", 192, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Stühle", 192, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", 192, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", 192, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Beamer", 192 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", 192, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Tische", 192, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Schwarzlicht", 192 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Beamer", 192, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Tische", 192, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Tische", 192, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Tische", 192, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Beamer", 192, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Stühle", 192 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Stühle", 192 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 192, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Bühne", 192 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Stühle", 192, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Tische", 192, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Beamer", 192, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Beamer", 192, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", 192, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 122,
                column: "RoomId",
                value: 192);

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Stühle", 192 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Bühne", 192, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Bühne", 192, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Bühne", 192, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Tische", 192, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Schwarzlicht", 192 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Bühne", 192, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 192, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Beamer", 192, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Beamer", 192, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Beamer", 192 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Tische", 192 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Tische", 192, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 192, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Beamer", 192, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Tische", 192, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Stühle", 192, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Tische", 192, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Bühne", 192 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", 192, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 143,
                column: "RoomId",
                value: 192);

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 192, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Tische", 192, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", 192, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Tische", 192, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Stühle", 192, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Beamer", 192, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 192, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Tische", 192, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Tische", 192, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Stühle", 192, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 192, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Beamer", 192, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Beamer", 192, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", 192, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Stühle", 192, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Beamer", 192, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 192, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Stühle", 192, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 162,
                column: "RoomId",
                value: 192);

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Bühne", 192, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Bühne", 192, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Stühle", 192 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 192, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", 192, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Schwarzlicht", 192 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Tische", 192, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", 192, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", 192, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Stühle", 192, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Stühle", 192, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Tische", 192, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 192, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Beamer", 192 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", 192, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Bühne", 192 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Tische", 192 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", 192, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Tische", 192, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Bühne", 192, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Beamer", 192, " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 184,
                column: "RoomId",
                value: 192);

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 192, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", 192, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 187,
                column: "RoomId",
                value: 192);

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Bühne", 192, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 192, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Tische", 192 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Bühne", 192, " " });

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
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Bühne", 192 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Stühle", 192 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Beamer", 192, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Beamer", 192, "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Stühle", 192 });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "RoomId", "SpecialProperties" },
                values: new object[] { 192, "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Description", "RoomId", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", 192, "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Description", "RoomId" },
                values: new object[] { "Stühle", 192 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "4a0e03c5-9476-4260-8471-ab57ee32d8cb", "19e91c87-186f-40c2-9694-34695c4bacb2" },
                    { "5b1a2e36-19ed-43e8-8b92-74d8bd606cee", "9f3be6d0-c21f-4772-8502-b64a1d7ff1bf" },
                    { "72a2e83a-2884-4355-b32d-56ae2d536601", "d36bad40-97cb-4f3a-a09d-4d71df570a97" },
                    { "e31b9502-193d-4c44-a518-9b0b91989759", "d9bf8141-190e-4f30-9107-fedee3fe22ce" }
                });
        }
    }
}
