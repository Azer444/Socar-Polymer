using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class categoryPropertyModelModified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Order",
                table: "ProductFields");

            migrationBuilder.DropColumn(
                name: "Order",
                table: "ProductCategoryProperties");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "ProductFields",
                newName: "Content_RU");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "ProductCategoryProperties",
                newName: "Name_EN");

            migrationBuilder.AddColumn<string>(
                name: "Content_AZ",
                table: "ProductFields",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Content_EN",
                table: "ProductFields",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name_AZ",
                table: "ProductCategoryProperties",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name_RU",
                table: "ProductCategoryProperties",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0dj93jd-3si3-344j-84dj-3djewk3kk5563c",
                column: "ConcurrencyStamp",
                value: "4aeee5dc-2855-4fd8-b29d-1ddb2529baa2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "cb8bcd02-d703-4613-b82a-096772512271");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d6z593d-5f8e-392d-10zk-132c92mz9482",
                column: "ConcurrencyStamp",
                value: "75f3c399-d53b-4669-b78e-e2a4584b4d67");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b495698-9283-4d44-917d-b301b4153451", "AQAAAAEAACcQAAAAEJEXWL2u8a8ItOmC0mnU8XzGrAyPgxhboyOpl9nnRzezbCvMtmdHXrWSSSZRKYkDvw==", "0c4d94fd-6ae5-4e42-bbfb-09be980b1ef1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content_AZ",
                table: "ProductFields");

            migrationBuilder.DropColumn(
                name: "Content_EN",
                table: "ProductFields");

            migrationBuilder.DropColumn(
                name: "Name_AZ",
                table: "ProductCategoryProperties");

            migrationBuilder.DropColumn(
                name: "Name_RU",
                table: "ProductCategoryProperties");

            migrationBuilder.RenameColumn(
                name: "Content_RU",
                table: "ProductFields",
                newName: "Content");

            migrationBuilder.RenameColumn(
                name: "Name_EN",
                table: "ProductCategoryProperties",
                newName: "Name");

            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "ProductFields",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "ProductCategoryProperties",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0dj93jd-3si3-344j-84dj-3djewk3kk5563c",
                column: "ConcurrencyStamp",
                value: "4ae4b78d-85fb-4d59-9614-adadf22388b4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "114fd0bc-b8fa-489a-b621-ac31d96bf42d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d6z593d-5f8e-392d-10zk-132c92mz9482",
                column: "ConcurrencyStamp",
                value: "025c9089-90b5-4115-8266-03aad124fdcd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e9307726-5bf7-45bf-b3e5-f27b21359237", "AQAAAAEAACcQAAAAENqlQv8krv7U/cE+Nf0G/h1au5x+xytbKyRnzLes4rMgoF6WyfKJfXr18hoTlQ34XQ==", "23cd4d8b-e0e6-47d9-9c2f-9aa3c583a4f2" });
        }
    }
}
