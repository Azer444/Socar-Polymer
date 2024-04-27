using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class _21 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MarketSubComponentPhoto");

            migrationBuilder.AddColumn<string>(
                name: "PhotoName",
                table: "MarketSubComponents",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotoName",
                table: "MarketSubComponents");

            migrationBuilder.CreateTable(
                name: "MarketSubComponentPhoto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MarketSubComponentId = table.Column<int>(type: "int", nullable: false),
                    PhotoName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarketSubComponentPhoto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MarketSubComponentPhoto_MarketSubComponents_MarketSubComponentId",
                        column: x => x.MarketSubComponentId,
                        principalTable: "MarketSubComponents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_MarketSubComponentPhoto_MarketSubComponentId",
                table: "MarketSubComponentPhoto",
                column: "MarketSubComponentId");
        }
    }
}
