using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Deskbuddy.Migrations
{
    /// <inheritdoc />
    public partial class room : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Occupancies_Workplaces_WorkplaceId",
                table: "Occupancies");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5be4ba69-0b27-42a0-b525-3bf5ab51d370", "19a790bc-9ee0-4819-950a-599b66c6c969" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8ae6f1cf-c709-4321-8939-6483efd1a733", "3affb737-4d5f-4b99-8d7c-293fa69cc861" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bbac327f-442d-404c-9f9c-db73a2e4663d", "3de894ce-5c69-4d03-8a07-1e15cdb3467e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8b21007d-7978-4570-9fb4-b881123bdd3c", "5906a9c4-12d9-4a59-b304-44665ff0324d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5be4ba69-0b27-42a0-b525-3bf5ab51d370");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ae6f1cf-c709-4321-8939-6483efd1a733");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8b21007d-7978-4570-9fb4-b881123bdd3c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bbac327f-442d-404c-9f9c-db73a2e4663d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19a790bc-9ee0-4819-950a-599b66c6c969");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3affb737-4d5f-4b99-8d7c-293fa69cc861");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3de894ce-5c69-4d03-8a07-1e15cdb3467e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5906a9c4-12d9-4a59-b304-44665ff0324d");

            migrationBuilder.AlterColumn<int>(
                name: "WorkplaceId",
                table: "Occupancies",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "RoomId",
                table: "Occupancies",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Greta Koch" });

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
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Friedrich Becker" });

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
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Greta Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Ingrid Wagner");

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
                column: "Name",
                value: "Dieter Richter");

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
                column: "Name",
                value: "Bernd Bauer");

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
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Bernd Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22,
                column: "Name",
                value: "Greta Weber");

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
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Anton Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 33,
                column: "Name",
                value: "Eva Wagner");

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
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Johann Richter" });

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
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Eva Becker" });

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
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Clara Bauer" });

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
                column: "Name",
                value: "Anton Koch");

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
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Eva Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 52,
                column: "Name",
                value: "Eva Wagner");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Greta Wagner" });

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
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Heinz Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Greta Meier" });

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
                column: "Name",
                value: "Ingrid Meier");

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
                column: "Name",
                value: "Greta Koch");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 67,
                column: "Name",
                value: "Friedrich Wagner");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 68,
                column: "Name",
                value: "Heinz Müller");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 69,
                column: "Name",
                value: "Ingrid Becker");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Heinz Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 71,
                column: "Name",
                value: "Dieter Richter");

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
                column: "Name",
                value: "Greta Fischer");

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
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Ingrid Weber" });

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
                column: "Name",
                value: "Ingrid Becker");

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
                column: "Name",
                value: "Anton Wagner");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Friedrich Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Bernd Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Anton Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 88,
                column: "Name",
                value: "Anton Richter");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Ingrid Fischer" });

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
                column: "Name",
                value: "Heinz Bauer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 97,
                column: "Name",
                value: "Johann Koch");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Friedrich Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 99,
                column: "Name",
                value: "Greta Richter");

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
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Bernd Meier" });

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
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Bernd Fischer" });

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
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Heinz Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 117,
                column: "Name",
                value: "Bernd Bauer");

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
                column: "Name",
                value: "Anton Wagner");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Clara Wagner" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Beamer");

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
                column: "SpecialProperties",
                value: "Ruheraum");

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
                values: new object[] { "Schwarzlicht", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 11,
                column: "SpecialProperties",
                value: "Ruheraum");

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
                column: "SpecialProperties",
                value: "Ruheraum");

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 19,
                column: "Description",
                value: "Bühne");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Ruheraum" });

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
                column: "SpecialProperties",
                value: "Schlafraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 25,
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", " " });

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
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 32,
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 35,
                column: "SpecialProperties",
                value: "Schlafraum");

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Partyraum" });

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
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 41,
                column: "Description",
                value: "Schwarzlicht");

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
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Partyraum" });

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
                column: "Description",
                value: "Beamer");

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
                keyValue: 51,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Schlafraum" });

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Ruheraum" });

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
                column: "Description",
                value: "Stühle");

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
                column: "Description",
                value: "Beamer");

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
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 63,
                column: "Description",
                value: "Beamer");

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
                values: new object[] { "Stühle", " " });

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 71,
                column: "SpecialProperties",
                value: "Schlafraum");

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
                column: "SpecialProperties",
                value: "Partyraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", " " });

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
                keyValue: 79,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 80,
                column: "SpecialProperties",
                value: "Ruheraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Partyraum" });

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
                column: "SpecialProperties",
                value: "Schlafraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 92,
                column: "Description",
                value: "Stühle");

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
                column: "SpecialProperties",
                value: "Ruheraum");

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
                column: "Description",
                value: "Bühne");

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Partyraum" });

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
                column: "Description",
                value: "Tische");

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
                values: new object[] { "Schwarzlicht", "Schlafraum" });

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Partyraum" });

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 114,
                column: "SpecialProperties",
                value: "Schlafraum");

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
                column: "SpecialProperties",
                value: "Partyraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 117,
                column: "Description",
                value: "Schwarzlicht");

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Partyraum" });

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
                column: "SpecialProperties",
                value: "Schlafraum");

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 129,
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Partyraum" });

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
                value: " ");

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
                keyValue: 139,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 142,
                column: "Description",
                value: "Schwarzlicht");

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
                column: "SpecialProperties",
                value: "Ruheraum");

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
                column: "SpecialProperties",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 148,
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Ruheraum" });

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
                column: "SpecialProperties",
                value: "Ruheraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Partyraum" });

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
                column: "SpecialProperties",
                value: " ");

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 161,
                column: "SpecialProperties",
                value: "Ruheraum");

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
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Schlafraum" });

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
                column: "SpecialProperties",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 169,
                column: "Description",
                value: "Schwarzlicht");

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 176,
                column: "SpecialProperties",
                value: "Partyraum");

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
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 181,
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 182,
                column: "SpecialProperties",
                value: "Partyraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 183,
                column: "SpecialProperties",
                value: "Partyraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", " " });

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
                keyValue: 188,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Partyraum" });

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Ruheraum" });

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Ruheraum" });

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Partyraum" });

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Schlafraum" });

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

            migrationBuilder.CreateIndex(
                name: "IX_Occupancies_RoomId",
                table: "Occupancies",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Occupancies_Rooms_RoomId",
                table: "Occupancies",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Occupancies_Workplaces_WorkplaceId",
                table: "Occupancies",
                column: "WorkplaceId",
                principalTable: "Workplaces",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Occupancies_Rooms_RoomId",
                table: "Occupancies");

            migrationBuilder.DropForeignKey(
                name: "FK_Occupancies_Workplaces_WorkplaceId",
                table: "Occupancies");

            migrationBuilder.DropIndex(
                name: "IX_Occupancies_RoomId",
                table: "Occupancies");

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

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "Occupancies");

            migrationBuilder.AlterColumn<int>(
                name: "WorkplaceId",
                table: "Occupancies",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5be4ba69-0b27-42a0-b525-3bf5ab51d370", null, "Sekretariat", "SEKRETARIAT" },
                    { "8ae6f1cf-c709-4321-8939-6483efd1a733", null, "Mitarbeiter", "MITARBEITER" },
                    { "8b21007d-7978-4570-9fb4-b881123bdd3c", null, "Abteilungsleiter", "ABTEILUNGSLEITER" },
                    { "bbac327f-442d-404c-9f9c-db73a2e4663d", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "19a790bc-9ee0-4819-950a-599b66c6c969", 0, "41e466c7-d71f-453d-a59d-00d3fa01586b", null, false, false, null, null, "SEKRETARIAT@ABC.COM", "AQAAAAIAAYagAAAAEBjwX7/z3/Frm1Mi0kElLW2FGCtntVqKUYeprd/aRxK+wnEu2YVVY6trYIA1ozIMyQ==", null, false, "784ffdb4-afde-434c-b6ab-c151ed50235e", false, "sekretariat@abc.com" },
                    { "3affb737-4d5f-4b99-8d7c-293fa69cc861", 0, "04c1ec38-8769-41f8-a2be-9008f09bbcf0", null, false, false, null, null, "MITARBEITER@ABC.COM", "AQAAAAIAAYagAAAAECQ8G7g7yWlpP9qK3TO+tEuo4M1536v0pqOuWyNMhzIa1BFkrJmMT1kl0Q0jIkhM7g==", null, false, "7cb428a1-5560-449c-be68-ac995f96e294", false, "mitarbeiter@abc.com" },
                    { "3de894ce-5c69-4d03-8a07-1e15cdb3467e", 0, "deff4bd7-c96c-4670-b4a7-31675c90f724", null, false, false, null, null, "ADMIN@ABC.COM", "AQAAAAIAAYagAAAAEAzZw9BCqFUzX9Ymr2cHlu1XsJJ5g0qzQ444O7mQMUbJwrK8gPzTKawhswrgctLrnQ==", null, false, "0470fad8-1f96-4a05-b7db-c626e22217f5", false, "admin@abc.com" },
                    { "5906a9c4-12d9-4a59-b304-44665ff0324d", 0, "8da45376-a019-4f86-a3ad-2a64483aa656", null, false, false, null, null, "ABTEILUNGSLEITER@ABC.COM", "AQAAAAIAAYagAAAAEKZkykP6z/sb1C3fnwNbFhTTBfFtI34Xh8/nmSqrawVMP7ULqbjH/CYGckoce0f32Q==", null, false, "adae830d-9da2-4dda-a52a-5fef9d6e0160", false, "abteilungsleiter@abc.com" }
                });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Johann Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Anton Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Friedrich Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Anton Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Greta Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Eva Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Ingrid Schmidt");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Anton Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Bernd Richter");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Eva Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "Dieter Koch");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12,
                column: "Name",
                value: "Dieter Fischer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Greta Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Heinz Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Friedrich Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Eva Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Heinz Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Johann Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Johann Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Greta Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Dieter Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22,
                column: "Name",
                value: "Eva Becker");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Ingrid Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Heinz Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Johann Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Clara Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Bernd Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Anton Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Greta Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Johann Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Friedrich Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Eva Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 33,
                column: "Name",
                value: "Heinz Wagner");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Friedrich Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Bernd Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Dieter Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Ingrid Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Anton Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Friedrich Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Johann Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Friedrich Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Friedrich Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Dieter Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Clara Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Friedrich Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Anton Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Ingrid Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 48,
                column: "Name",
                value: "Friedrich Richter");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Dieter Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 50,
                column: "Name",
                value: "Friedrich Meier");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Eva Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 52,
                column: "Name",
                value: "Johann Wagner");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Anton Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Anton Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Clara Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Heinz Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Johann Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Anton Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 59,
                column: "Name",
                value: "Heinz Meier");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 60,
                column: "Name",
                value: "Friedrich Schmidt");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Eva Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Clara Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Clara Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Ingrid Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Eva Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 66,
                column: "Name",
                value: "Clara Fischer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 67,
                column: "Name",
                value: "Clara Müller");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 68,
                column: "Name",
                value: "Dieter Koch");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 69,
                column: "Name",
                value: "Heinz Bauer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Bernd Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 71,
                column: "Name",
                value: "Bernd Schmidt");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Clara Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 73,
                column: "Name",
                value: "Ingrid Weber");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Anton Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Heinz Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 76,
                column: "Name",
                value: "Eva Weber");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Friedrich Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Ingrid Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 79,
                column: "Name",
                value: "Johann Fischer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Greta Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Dieter Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Friedrich Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Greta Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 84,
                column: "Name",
                value: "Heinz Schmidt");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Greta Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Bernd Becker" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Bernd Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 88,
                column: "Name",
                value: "Clara Weber");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Dieter Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Anton Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Ingrid Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Dieter Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Dieter Richter" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Greta Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Clara Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 96,
                column: "Name",
                value: "Bernd Fischer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 97,
                column: "Name",
                value: "Friedrich Koch");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Anton Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 99,
                column: "Name",
                value: "Heinz Müller");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Ingrid Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Clara Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Greta Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Greta Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 104,
                column: "Name",
                value: "Friedrich Fischer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Clara Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Friedrich Wagner" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Eva Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Eva Fischer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Johann Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Johann Weber" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Johann Bauer" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Johann Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Heinz Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 2, "Anton Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Bernd Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 3, "Anton Meier" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 117,
                column: "Name",
                value: "Johann Schmidt");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 1, "Johann Koch" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 5, "Greta Müller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 120,
                column: "Name",
                value: "Heinz Müller");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Bernd Schmidt" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 122,
                column: "Name",
                value: "Clara Fischer");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "DepartmentId", "Name" },
                values: new object[] { 4, "Friedrich Richter" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "Stühle");

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
                column: "SpecialProperties",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 11,
                column: "SpecialProperties",
                value: " ");

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
                column: "SpecialProperties",
                value: "Partyraum");

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
                column: "SpecialProperties",
                value: "Schlafraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 19,
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 23,
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 24,
                column: "SpecialProperties",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 25,
                column: "Description",
                value: "Beamer");

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
                values: new object[] { "Beamer", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Schlafraum" });

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
                column: "Description",
                value: "Bühne");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 32,
                column: "Description",
                value: "Tische");

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Partyraum" });

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Ruheraum" });

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
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 41,
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 43,
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 46,
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 47,
                column: "SpecialProperties",
                value: "Ruheraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 55,
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 57,
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Partyraum" });

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
                column: "Description",
                value: "Bühne");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 66,
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 71,
                column: "SpecialProperties",
                value: "Ruheraum");

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
                value: "Ruheraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 77,
                column: "Description",
                value: "Tische");

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
                values: new object[] { "Beamer", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 90,
                column: "SpecialProperties",
                value: "Ruheraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 92,
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 93,
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 95,
                column: "SpecialProperties",
                value: "Partyraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 98,
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Partyraum" });

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
                column: "SpecialProperties",
                value: "Ruheraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", " " });

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
                values: new object[] { "Tische", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Partyraum" });

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 111,
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 114,
                column: "SpecialProperties",
                value: "Partyraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 116,
                column: "SpecialProperties",
                value: " ");

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
                values: new object[] { "Stühle", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", " " });

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
                column: "SpecialProperties",
                value: "Partyraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 122,
                column: "Description",
                value: "Schwarzlicht");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 124,
                column: "SpecialProperties",
                value: "Schlafraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 129,
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 134,
                column: "SpecialProperties",
                value: "Ruheraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 142,
                column: "Description",
                value: "Beamer");

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
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 145,
                column: "SpecialProperties",
                value: "Partyraum");

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
                column: "SpecialProperties",
                value: "Schlafraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 148,
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Schlafraum" });

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
                column: "SpecialProperties",
                value: "Partyraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Ruheraum" });

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
                values: new object[] { "Schwarzlicht", "Partyraum" });

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Ruheraum" });

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 161,
                column: "SpecialProperties",
                value: " ");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Tische", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 164,
                column: "Description",
                value: "Beamer");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 168,
                column: "SpecialProperties",
                value: "Schlafraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 169,
                column: "Description",
                value: "Tische");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", " " });

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
                values: new object[] { "Bühne", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 176,
                column: "SpecialProperties",
                value: "Schlafraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", " " });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 178,
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 181,
                column: "Description",
                value: "Stühle");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 182,
                column: "SpecialProperties",
                value: "Ruheraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 183,
                column: "SpecialProperties",
                value: "Ruheraum");

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", " " });

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Stühle", "Partyraum" });

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Bühne", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 193,
                column: "SpecialProperties",
                value: "Ruheraum");

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
                values: new object[] { "Beamer", "Schlafraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Partyraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", "Ruheraum" });

            migrationBuilder.UpdateData(
                table: "Workplaces",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Beamer", " " });

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
                columns: new[] { "Description", "SpecialProperties" },
                values: new object[] { "Schwarzlicht", "Partyraum" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "5be4ba69-0b27-42a0-b525-3bf5ab51d370", "19a790bc-9ee0-4819-950a-599b66c6c969" },
                    { "8ae6f1cf-c709-4321-8939-6483efd1a733", "3affb737-4d5f-4b99-8d7c-293fa69cc861" },
                    { "bbac327f-442d-404c-9f9c-db73a2e4663d", "3de894ce-5c69-4d03-8a07-1e15cdb3467e" },
                    { "8b21007d-7978-4570-9fb4-b881123bdd3c", "5906a9c4-12d9-4a59-b304-44665ff0324d" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Occupancies_Workplaces_WorkplaceId",
                table: "Occupancies",
                column: "WorkplaceId",
                principalTable: "Workplaces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
