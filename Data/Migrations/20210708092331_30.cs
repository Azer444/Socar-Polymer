using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class _30 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Events");

            migrationBuilder.RenameColumn(
                name: "Where",
                table: "Events",
                newName: "Content_RU");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "Events",
                newName: "Title_RU");

            migrationBuilder.AddColumn<string>(
                name: "Content_AZ",
                table: "Events",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Content_EN",
                table: "Events",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Slug",
                table: "Events",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title_AZ",
                table: "Events",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title_EN",
                table: "Events",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "17b9ec6a-9e3d-472c-8269-64996304daa5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d6z593d-5f8e-392d-10zk-132c92mz9482",
                column: "ConcurrencyStamp",
                value: "1a7d5df0-78d6-46f9-b50d-a47e3fa62565");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "148b6269-dac8-4ade-a19a-db587472b60b", "AQAAAAEAACcQAAAAEJRQNylYFCG5KWfigfZ9UMwsHOS0t/Kr+0PbSr0k8j39TeMU+HhFiYJ2ekjwT+8bjA==", "93796b66-633a-4528-9c07-c05cc7bd99f6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content_AZ",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Content_EN",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Slug",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Title_AZ",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Title_EN",
                table: "Events");

            migrationBuilder.RenameColumn(
                name: "Title_RU",
                table: "Events",
                newName: "Content");

            migrationBuilder.RenameColumn(
                name: "Content_RU",
                table: "Events",
                newName: "Where");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "09eedd4f-a5c8-478a-93ee-927783f39b02");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d6z593d-5f8e-392d-10zk-132c92mz9482",
                column: "ConcurrencyStamp",
                value: "a0d6bcc5-b6af-4d42-b7c9-49c529bc757a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "921aa54d-ce00-4a6d-9f0a-c655f6deed76", "AQAAAAEAACcQAAAAEN33hH+YjCirw8R2mIqQSl/LOxLd96SsRM9KdYABix6X3wNX95hkmRDiFDeX3i9kfQ==", "38b44365-e9ac-4944-b92c-e60dc26684e3" });
        }
    }
}
