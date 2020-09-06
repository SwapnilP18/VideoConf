using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConferenceApp.Migrations
{
    public partial class EntityRelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a24c6d61-4546-42b9-84ea-c1206a95924b");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "FeatureID",
                table: "RoomSettings");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "RoomSettings");

            migrationBuilder.DropColumn(
                name: "MoodifiedBy",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "FeatureID",
                table: "RoomConfigurations");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "RoomConfigurations");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "Meetings");

            migrationBuilder.AddColumn<Guid>(
                name: "RoomFeatureID",
                table: "RoomSettings",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Rooms",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "RoomFeatureID",
                table: "RoomConfigurations",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TenantID", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9bb05bec-8680-4a3f-8d47-90f4c585356b", 0, "2d91e2c9-fcf3-4122-8038-be482c7f1777", "superadmin@gmail.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEIenTH82XpAjKHrcu2wl3xXPFLaFfxiNBXJaW+DyXenIyVyieFY2wyY9X7nI7/gGXA==", null, false, "93adbbf7-9666-49bc-9dac-1b77056124dc", null, false, "SuperAdmin" });

            migrationBuilder.CreateIndex(
                name: "IX_UserRoomMappings_RoomID",
                table: "UserRoomMappings",
                column: "RoomID");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoomMappings_UserID",
                table: "UserRoomMappings",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_RoomSettings_RoomFeatureID",
                table: "RoomSettings",
                column: "RoomFeatureID");

            migrationBuilder.CreateIndex(
                name: "IX_RoomSettings_RoomID",
                table: "RoomSettings",
                column: "RoomID");

            migrationBuilder.CreateIndex(
                name: "IX_RoomConfigurations_RoomFeatureID",
                table: "RoomConfigurations",
                column: "RoomFeatureID");

            migrationBuilder.CreateIndex(
                name: "IX_Meetings_RoomID",
                table: "Meetings",
                column: "RoomID");

            migrationBuilder.AddForeignKey(
                name: "FK_Meetings_Rooms_RoomID",
                table: "Meetings",
                column: "RoomID",
                principalTable: "Rooms",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomConfigurations_RoomFeatures_RoomFeatureID",
                table: "RoomConfigurations",
                column: "RoomFeatureID",
                principalTable: "RoomFeatures",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomSettings_RoomFeatures_RoomFeatureID",
                table: "RoomSettings",
                column: "RoomFeatureID",
                principalTable: "RoomFeatures",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomSettings_Rooms_RoomID",
                table: "RoomSettings",
                column: "RoomID",
                principalTable: "Rooms",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoomMappings_Rooms_RoomID",
                table: "UserRoomMappings",
                column: "RoomID",
                principalTable: "Rooms",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoomMappings_User_UserID",
                table: "UserRoomMappings",
                column: "UserID",
                principalTable: "User",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meetings_Rooms_RoomID",
                table: "Meetings");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomConfigurations_RoomFeatures_RoomFeatureID",
                table: "RoomConfigurations");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomSettings_RoomFeatures_RoomFeatureID",
                table: "RoomSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomSettings_Rooms_RoomID",
                table: "RoomSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoomMappings_Rooms_RoomID",
                table: "UserRoomMappings");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoomMappings_User_UserID",
                table: "UserRoomMappings");

            migrationBuilder.DropIndex(
                name: "IX_UserRoomMappings_RoomID",
                table: "UserRoomMappings");

            migrationBuilder.DropIndex(
                name: "IX_UserRoomMappings_UserID",
                table: "UserRoomMappings");

            migrationBuilder.DropIndex(
                name: "IX_RoomSettings_RoomFeatureID",
                table: "RoomSettings");

            migrationBuilder.DropIndex(
                name: "IX_RoomSettings_RoomID",
                table: "RoomSettings");

            migrationBuilder.DropIndex(
                name: "IX_RoomConfigurations_RoomFeatureID",
                table: "RoomConfigurations");

            migrationBuilder.DropIndex(
                name: "IX_Meetings_RoomID",
                table: "Meetings");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9bb05bec-8680-4a3f-8d47-90f4c585356b");

            migrationBuilder.DropColumn(
                name: "RoomFeatureID",
                table: "RoomSettings");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "RoomFeatureID",
                table: "RoomConfigurations");

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "User",
                type: "varchar(64) CHARACTER SET utf8mb4",
                maxLength: 64,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FeatureID",
                table: "RoomSettings",
                type: "char(36)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "RoomSettings",
                type: "varchar(64) CHARACTER SET utf8mb4",
                maxLength: 64,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MoodifiedBy",
                table: "Rooms",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "Rooms",
                type: "varchar(64) CHARACTER SET utf8mb4",
                maxLength: 64,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FeatureID",
                table: "RoomConfigurations",
                type: "char(36)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "RoomConfigurations",
                type: "varchar(64) CHARACTER SET utf8mb4",
                maxLength: 64,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TenantId",
                table: "Meetings",
                type: "varchar(64) CHARACTER SET utf8mb4",
                maxLength: 64,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TenantID", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a24c6d61-4546-42b9-84ea-c1206a95924b", 0, "4fbf5dfd-f74a-438d-b0ab-9bf8ae30f44c", "superadmin@gmail.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEDrD6uSmslI37GN8m01FUtT6ZOXctQ5YYJMREqYFEOD3SqkU2M+2Cpvb1oEcDdMwag==", null, false, "6a440f5d-8fd9-4725-83d9-f0ab5168223b", null, false, "SuperAdmin" });
        }
    }
}
