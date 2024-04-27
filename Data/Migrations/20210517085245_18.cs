using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class _18 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NavComponents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NavTitleComponentId = table.Column<int>(type: "int", nullable: false),
                    Title_AZ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title_RU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NavComponents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NavComponents_NavTitleComponents_NavTitleComponentId",
                        column: x => x.NavTitleComponentId,
                        principalTable: "NavTitleComponents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_NavComponents_NavTitleComponentId",
                table: "NavComponents",
                column: "NavTitleComponentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NavComponents");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "653e995a-ebc2-430c-8a24-1f8a251db250");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d6z593d-5f8e-392d-10zk-132c92mz9482",
                column: "ConcurrencyStamp",
                value: "89156434-2df1-4bc7-9d1a-3c5e1afcf1c9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c47b4d88-42d1-48cd-bd85-12653ec4b968", "AQAAAAEAACcQAAAAEGHXRqEzFqSkDTr7IXfpnqCzgW7ZPQLcc/kaU/S0cW5nKqgeHHHTWrTeAB/QDjgi9A==", "875d5796-dcd7-419a-bef8-5f0a94a76a1e" });
        }
    }
}
