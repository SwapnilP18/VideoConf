using Microsoft.EntityFrameworkCore.Migrations;

namespace ConferenceApp.Migrations
{
    public partial class AddedMultitenancySupport : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8337047c-3f3f-425d-a635-5b67dde80afa");

            migrationBuilder.RenameColumn(
                name: "TenantID",
                table: "User",
                newName: "TenantId");

            migrationBuilder.RenameColumn(
                name: "TenantID",
                table: "RoomSettings",
                newName: "TenantId");

            migrationBuilder.RenameColumn(
                name: "TenantID",
                table: "Rooms",
                newName: "TenantId");

            migrationBuilder.RenameColumn(
                name: "TenantID",
                table: "RoomConfigurations",
                newName: "TenantId");

            migrationBuilder.RenameColumn(
                name: "TenantID",
                table: "Meetings",
                newName: "TenantId");

            migrationBuilder.AlterColumn<string>(
                name: "TenantId",
                table: "User",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(36)");

            migrationBuilder.AlterColumn<string>(
                name: "TenantId",
                table: "RoomSettings",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(36)");

            migrationBuilder.AlterColumn<string>(
                name: "TenantId",
                table: "Rooms",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TenantId",
                table: "RoomConfigurations",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TenantId",
                table: "Meetings",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(36)");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TenantID", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a24c6d61-4546-42b9-84ea-c1206a95924b", 0, "4fbf5dfd-f74a-438d-b0ab-9bf8ae30f44c", "superadmin@gmail.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEDrD6uSmslI37GN8m01FUtT6ZOXctQ5YYJMREqYFEOD3SqkU2M+2Cpvb1oEcDdMwag==", null, false, "6a440f5d-8fd9-4725-83d9-f0ab5168223b", null, false, "SuperAdmin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a24c6d61-4546-42b9-84ea-c1206a95924b");

            migrationBuilder.RenameColumn(
                name: "TenantId",
                table: "User",
                newName: "TenantID");

            migrationBuilder.RenameColumn(
                name: "TenantId",
                table: "RoomSettings",
                newName: "TenantID");

            migrationBuilder.RenameColumn(
                name: "TenantId",
                table: "Rooms",
                newName: "TenantID");

            migrationBuilder.RenameColumn(
                name: "TenantId",
                table: "RoomConfigurations",
                newName: "TenantID");

            migrationBuilder.RenameColumn(
                name: "TenantId",
                table: "Meetings",
                newName: "TenantID");

            migrationBuilder.AlterColumn<string>(
                name: "TenantID",
                table: "User",
                type: "char(36)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 64);

            migrationBuilder.AlterColumn<string>(
                name: "TenantID",
                table: "RoomSettings",
                type: "char(36)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 64);

            migrationBuilder.AlterColumn<string>(
                name: "TenantID",
                table: "Rooms",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 64);

            migrationBuilder.AlterColumn<string>(
                name: "TenantID",
                table: "RoomConfigurations",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 64);

            migrationBuilder.AlterColumn<string>(
                name: "TenantID",
                table: "Meetings",
                type: "char(36)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 64);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TenantID", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8337047c-3f3f-425d-a635-5b67dde80afa", 0, "f1657ed6-c651-46a5-b63d-5169e72a3dfb", "superadmin@gmail.com", false, false, null, null, null, "AQAAAAEAACcQAAAAELROyAKrIL7HRmHQWoQNCGE+2bvngDD88MWxSALRI77CtFC08OCQwRVpqZLHmGD/1g==", null, false, "6912654b-099e-43be-b370-728e9bb31f5c", null, false, "SuperAdmin" });
        }
    }
}
