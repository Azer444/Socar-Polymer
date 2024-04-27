using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class _19 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MarketSubComponentFiles_MarketSubComponents_MarketComponentSubComponentId",
                table: "MarketSubComponentFiles");

            migrationBuilder.DropColumn(
                name: "PhotoName",
                table: "MarketSubComponents");

            migrationBuilder.RenameColumn(
                name: "MarketComponentSubComponentId",
                table: "MarketSubComponentFiles",
                newName: "MarketSubComponentId");

            migrationBuilder.RenameIndex(
                name: "IX_MarketSubComponentFiles_MarketComponentSubComponentId",
                table: "MarketSubComponentFiles",
                newName: "IX_MarketSubComponentFiles_MarketSubComponentId");

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

            migrationBuilder.CreateIndex(
                name: "IX_MarketSubComponentPhoto_MarketSubComponentId",
                table: "MarketSubComponentPhoto",
                column: "MarketSubComponentId");

            migrationBuilder.AddForeignKey(
                name: "FK_MarketSubComponentFiles_MarketSubComponents_MarketSubComponentId",
                table: "MarketSubComponentFiles",
                column: "MarketSubComponentId",
                principalTable: "MarketSubComponents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MarketSubComponentFiles_MarketSubComponents_MarketSubComponentId",
                table: "MarketSubComponentFiles");

            migrationBuilder.DropTable(
                name: "MarketSubComponentPhoto");

            migrationBuilder.RenameColumn(
                name: "MarketSubComponentId",
                table: "MarketSubComponentFiles",
                newName: "MarketComponentSubComponentId");

            migrationBuilder.RenameIndex(
                name: "IX_MarketSubComponentFiles_MarketSubComponentId",
                table: "MarketSubComponentFiles",
                newName: "IX_MarketSubComponentFiles_MarketComponentSubComponentId");

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
                value: "ad887679-233c-4eba-8780-f437c72e2240");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d6z593d-5f8e-392d-10zk-132c92mz9482",
                column: "ConcurrencyStamp",
                value: "ab28c65d-a85c-4ade-b6e7-810fab3687ce");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ceff1f9-cf09-4617-9729-90a887e89009", "AQAAAAEAACcQAAAAEGxVSqLr3Eu4R0OrWURH4TA0CE0dtyygaWvPimZqXCe7DjD4ewO+GfRvY/jouHyoyw==", "ec4c2524-e919-4672-a410-810fb22fc0a9" });

            migrationBuilder.AddForeignKey(
                name: "FK_MarketSubComponentFiles_MarketSubComponents_MarketComponentSubComponentId",
                table: "MarketSubComponentFiles",
                column: "MarketComponentSubComponentId",
                principalTable: "MarketSubComponents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
