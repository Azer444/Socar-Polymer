using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class _7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "MarketComponents",
                newName: "Title_RU");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "MarketComponents",
                newName: "Title_EN");

            migrationBuilder.AddColumn<string>(
                name: "Content_AZ",
                table: "MarketComponents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Content_EN",
                table: "MarketComponents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Content_RU",
                table: "MarketComponents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Slug",
                table: "MarketComponents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title_AZ",
                table: "MarketComponents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content_AZ",
                table: "MarketComponents");

            migrationBuilder.DropColumn(
                name: "Content_EN",
                table: "MarketComponents");

            migrationBuilder.DropColumn(
                name: "Content_RU",
                table: "MarketComponents");

            migrationBuilder.DropColumn(
                name: "Slug",
                table: "MarketComponents");

            migrationBuilder.DropColumn(
                name: "Title_AZ",
                table: "MarketComponents");

            migrationBuilder.RenameColumn(
                name: "Title_RU",
                table: "MarketComponents",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Title_EN",
                table: "MarketComponents",
                newName: "Content");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "7e8c6d6a-71ba-4ab3-a716-e3e434bfc300");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d6z593d-5f8e-392d-10zk-132c92mz9482",
                column: "ConcurrencyStamp",
                value: "d2220a48-de7f-4270-a8b4-0b61b4e02251");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "752a8b4c-ce5d-4afa-b6bf-55b7be94eac3", "AQAAAAEAACcQAAAAEAErOcaf44xIT4TAQL43xjPFOY6dPgywzIsZB7ipCO1ZImcSnZtvuhC/rnFb5Mg22A==", "351eb123-c973-43fe-a8f8-1f8b9a1fb295" });
        }
    }
}
