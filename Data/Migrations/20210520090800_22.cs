using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class _22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DisplayName",
                table: "MarketTitleComponentFiles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DisplayName",
                table: "MarketSubComponentFiles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DisplayName",
                table: "MarketComponentFiles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "96499eda-3bad-4a75-891f-405ad5443708");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d6z593d-5f8e-392d-10zk-132c92mz9482",
                column: "ConcurrencyStamp",
                value: "95c0c591-3960-411e-9997-27b1bebf9678");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b49b8aa-116e-4783-a04f-073a760d768d", "AQAAAAEAACcQAAAAEFg482415lWVTCvwEfnddJJZSRkbhGUM+j9vizkW/moIYY83q6mPFMRQ/usYQZt6RA==", "e48bcb3e-9ffc-4ceb-ad75-e046683e6879" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DisplayName",
                table: "MarketTitleComponentFiles");

            migrationBuilder.DropColumn(
                name: "DisplayName",
                table: "MarketSubComponentFiles");

            migrationBuilder.DropColumn(
                name: "DisplayName",
                table: "MarketComponentFiles");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "3fbe9ebf-efa3-4ebe-95e9-38f34bc717cf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d6z593d-5f8e-392d-10zk-132c92mz9482",
                column: "ConcurrencyStamp",
                value: "afacd695-0c79-45e5-ab50-a9ca22a1ff12");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9026c388-0688-48cc-90e0-d4794765020d", "AQAAAAEAACcQAAAAED0wM2veUxMeoLu2uepF9ET+WWnPTS6IYIVVZCR008ZTU2PLk7/JWe8ubBsLg7CEqQ==", "d78d82b9-6d80-4e04-9d35-829ecc70e68b" });
        }
    }
}
