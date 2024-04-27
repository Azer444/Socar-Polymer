using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class _11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NavTitleComponentId",
                table: "MarketTitleComponents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "37bc91bb-89ea-498a-afa7-21f8b86deb0c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d6z593d-5f8e-392d-10zk-132c92mz9482",
                column: "ConcurrencyStamp",
                value: "e4a887f8-2078-4da2-b824-65d22a733190");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23cabe60-f490-49b3-bde6-8d5433c87371", "AQAAAAEAACcQAAAAEKX+a8FEf9ch6C3A9Jz4EmchegZZGyEXF1+wxQgGiVJtbVUgQv6ldZhovtzKavWsBg==", "eee48a54-6c98-4ccb-b457-69ad04a0e8d5" });

            migrationBuilder.CreateIndex(
                name: "IX_MarketTitleComponents_NavTitleComponentId",
                table: "MarketTitleComponents",
                column: "NavTitleComponentId");

            migrationBuilder.AddForeignKey(
                name: "FK_MarketTitleComponents_NavTitleComponents_NavTitleComponentId",
                table: "MarketTitleComponents",
                column: "NavTitleComponentId",
                principalTable: "NavTitleComponents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MarketTitleComponents_NavTitleComponents_NavTitleComponentId",
                table: "MarketTitleComponents");

            migrationBuilder.DropIndex(
                name: "IX_MarketTitleComponents_NavTitleComponentId",
                table: "MarketTitleComponents");

            migrationBuilder.DropColumn(
                name: "NavTitleComponentId",
                table: "MarketTitleComponents");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "4eb6b7a8-e7e9-42b5-beaa-4031248978b7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d6z593d-5f8e-392d-10zk-132c92mz9482",
                column: "ConcurrencyStamp",
                value: "ad2caf13-fa04-4591-81ae-d0fd04910bc8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d3ef2c1-1c40-4ade-a7de-cec2cf4e8d8c", "AQAAAAEAACcQAAAAEMqA3h2ByElbdEP4czTzCb5h57mP7h38Qi2QQl2XbNWMwmtcDVmj+nQvHYFtvgHDuw==", "3d9d655f-09d7-441e-8a77-03d1c1c9a6b5" });
        }
    }
}
