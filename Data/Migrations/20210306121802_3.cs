using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class _3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MarketComponentFiles_News_NewsId",
                table: "MarketComponentFiles");

            migrationBuilder.DropIndex(
                name: "IX_MarketComponentFiles_NewsId",
                table: "MarketComponentFiles");

            migrationBuilder.DropColumn(
                name: "NewsId",
                table: "MarketComponentFiles");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "2e567134-c573-4183-b810-323b93331a6d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d6z593d-5f8e-392d-10zk-132c92mz9482",
                column: "ConcurrencyStamp",
                value: "d523869b-1b66-4977-9701-79ecf34a1847");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c5bcf32b-ee85-41a0-a6d3-9a5b66a37339", "AQAAAAEAACcQAAAAECL4YQgeY+OmtxovdWAsXDO4CaBMZ9K2FO3p9dgYN0tzB0OPnUYTuWpwL8XqtIS2/g==", "e54249eb-b58e-4c1a-9aea-492112ae41e0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NewsId",
                table: "MarketComponentFiles",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "b856d48e-b355-41a4-a96a-cee105948091");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d6z593d-5f8e-392d-10zk-132c92mz9482",
                column: "ConcurrencyStamp",
                value: "7cc1a27c-a780-42fd-8120-934ac14aac0d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0467f4f8-dccb-4846-bbf2-9b7538f5c32e", "AQAAAAEAACcQAAAAEP66I8Eig0oXznnjCAIuAY6OGz0CnyOyQrUE3wBa17niUwUyWJ43+X9XGF7rwrtCXA==", "67411ac6-4cdd-4e4c-9184-ffbe28bc0268" });

            migrationBuilder.CreateIndex(
                name: "IX_MarketComponentFiles_NewsId",
                table: "MarketComponentFiles",
                column: "NewsId");

            migrationBuilder.AddForeignKey(
                name: "FK_MarketComponentFiles_News_NewsId",
                table: "MarketComponentFiles",
                column: "NewsId",
                principalTable: "News",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
