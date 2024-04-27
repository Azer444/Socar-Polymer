using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class _20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content",
                table: "PageAccessComponents");

            migrationBuilder.DropColumn(
                name: "PhotoPath",
                table: "PageAccessComponents");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "PageAccessComponents",
                newName: "Title_RU");

            migrationBuilder.AddColumn<string>(
                name: "Title_AZ",
                table: "PageAccessComponents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title_EN",
                table: "PageAccessComponents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Content_AZ",
                table: "NavComponents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Content_EN",
                table: "NavComponents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Content_RU",
                table: "NavComponents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "765c692a-9cdd-4d03-9dc8-d07c8515b320");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d6z593d-5f8e-392d-10zk-132c92mz9482",
                column: "ConcurrencyStamp",
                value: "f9d8f72f-ecc9-4410-8ff2-b6aed0389180");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a9bc1cd-6819-46d6-8710-5eb034c0e265", "AQAAAAEAACcQAAAAEErqs8UAIlEooStkl3cwXoid6T/yiEHeQR7M/q28yrF+3Ro0ErlPPIU8MHc46eL4dA==", "c40f61ad-429a-4001-8273-2caec919c226" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title_AZ",
                table: "PageAccessComponents");

            migrationBuilder.DropColumn(
                name: "Title_EN",
                table: "PageAccessComponents");

            migrationBuilder.DropColumn(
                name: "Content_AZ",
                table: "NavComponents");

            migrationBuilder.DropColumn(
                name: "Content_EN",
                table: "NavComponents");

            migrationBuilder.DropColumn(
                name: "Content_RU",
                table: "NavComponents");

            migrationBuilder.RenameColumn(
                name: "Title_RU",
                table: "PageAccessComponents",
                newName: "Title");

            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "PageAccessComponents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhotoPath",
                table: "PageAccessComponents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "f0bd3289-b416-40b8-b462-16d6883e5260");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d6z593d-5f8e-392d-10zk-132c92mz9482",
                column: "ConcurrencyStamp",
                value: "f3175033-36b8-4688-89d6-bf3dbe050858");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b11a87d5-668c-460c-ac30-d176c4d220ec", "AQAAAAEAACcQAAAAED0wGsetCBMr/nnzEJf0ZvI178WGwJDbznmElwbIHpKsUl/hnSeh5SWkrkNP+hY2Cg==", "8940437b-b393-4d9a-b29a-b50c457d8dab" });
        }
    }
}
