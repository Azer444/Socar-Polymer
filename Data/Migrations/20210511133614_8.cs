using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class _8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "MarketSubComponents",
                newName: "Title_RU");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "MarketSubComponents",
                newName: "Title_EN");

            migrationBuilder.AddColumn<string>(
                name: "Content_AZ",
                table: "MarketSubComponents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Content_EN",
                table: "MarketSubComponents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Content_RU",
                table: "MarketSubComponents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Slug",
                table: "MarketSubComponents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title_AZ",
                table: "MarketSubComponents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "90f11dcd-dca7-4e55-b8ce-5ae5b3ebe58b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d6z593d-5f8e-392d-10zk-132c92mz9482",
                column: "ConcurrencyStamp",
                value: "f8b191c0-4b51-422f-a98a-a243309e3305");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a34de737-ab79-402f-b6f8-d8dc673067a4", "AQAAAAEAACcQAAAAENZbOD/uGK6E1GF1TKUOhRmS95T2Rtf+HWmCZpwtyWqPp7jO0zeuP5tkJsgyhTy43A==", "1492d0b8-98f5-4b86-9575-86b0818f2f69" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content_AZ",
                table: "MarketSubComponents");

            migrationBuilder.DropColumn(
                name: "Content_EN",
                table: "MarketSubComponents");

            migrationBuilder.DropColumn(
                name: "Content_RU",
                table: "MarketSubComponents");

            migrationBuilder.DropColumn(
                name: "Slug",
                table: "MarketSubComponents");

            migrationBuilder.DropColumn(
                name: "Title_AZ",
                table: "MarketSubComponents");

            migrationBuilder.RenameColumn(
                name: "Title_RU",
                table: "MarketSubComponents",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Title_EN",
                table: "MarketSubComponents",
                newName: "Content");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "13e03919-ab5c-44ee-9d40-ae6104ba0714");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d6z593d-5f8e-392d-10zk-132c92mz9482",
                column: "ConcurrencyStamp",
                value: "b0e6be8c-3bbb-46e5-bb04-ce51551ae559");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b0000eba-5f1e-4d30-808d-d7835a38a49f", "AQAAAAEAACcQAAAAEBeqGmIilLVN3u+lZsQXvrfEI8Tm92CdJdiO8bM7GZ+Tq7BL2xgwmv2E9mdCfuYiuQ==", "99517886-e2bb-4166-bca4-2c9149052abc" });
        }
    }
}
