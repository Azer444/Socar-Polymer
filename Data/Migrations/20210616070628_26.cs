using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class _26 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SDSName",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TDSName",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProductBrochure",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductBrochure", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductBrochure_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "090e1ab3-332b-42a5-8350-e032e3844a8f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d6z593d-5f8e-392d-10zk-132c92mz9482",
                column: "ConcurrencyStamp",
                value: "c6b728a5-f705-42ed-865a-ee99b322e67b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a78b7f4b-44dc-43fb-aca9-88e861677d96", "AQAAAAEAACcQAAAAEOa9K6/NX7HZw5ARaWz2g5cLBKxAazwSHd9UBWwVJ5P8UeZasU8r+f/0QlyaK2Ruww==", "e4572834-23a8-4a65-b934-0b5249ca66fc" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductBrochure_ProductId",
                table: "ProductBrochure",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductBrochure");

            migrationBuilder.DropColumn(
                name: "SDSName",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "TDSName",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "4f47e553-2137-4f4b-beb2-97fc319c894e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d6z593d-5f8e-392d-10zk-132c92mz9482",
                column: "ConcurrencyStamp",
                value: "b2c4a917-36c4-45fa-902e-76efa8ad3ed1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "573ad87a-5178-4d2e-920e-0478d31597d5", "AQAAAAEAACcQAAAAEC7x30NQzf9NwrBPomzPu02xJ9a4teVOcRfcs20xiQE3sNwpKapNEyCj72mKW5S3cg==", "a406b452-0dcc-426f-adb9-eb6ba2bfd55a" });
        }
    }
}
