using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class _27 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductBrochure_Products_ProductId",
                table: "ProductBrochure");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductBrochure",
                table: "ProductBrochure");

            migrationBuilder.RenameTable(
                name: "ProductBrochure",
                newName: "ProductBrochures");

            migrationBuilder.RenameIndex(
                name: "IX_ProductBrochure_ProductId",
                table: "ProductBrochures",
                newName: "IX_ProductBrochures_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductBrochures",
                table: "ProductBrochures",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "d0d8593a-91aa-432c-b871-c6e349eca205");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d6z593d-5f8e-392d-10zk-132c92mz9482",
                column: "ConcurrencyStamp",
                value: "aa2ea256-63fa-4c52-b798-74bf04d79753");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bdeab693-4a67-4b73-a74c-dde019138ecd", "AQAAAAEAACcQAAAAENOEDaDr7xcJXnr6bMpgF/Pu55i0fw5c4YR0JdK4KQ0wLAyhORgG2Bv8ZAr+PbcZCw==", "df270c02-deac-41ad-a96f-638573bb5232" });

            migrationBuilder.AddForeignKey(
                name: "FK_ProductBrochures_Products_ProductId",
                table: "ProductBrochures",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductBrochures_Products_ProductId",
                table: "ProductBrochures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductBrochures",
                table: "ProductBrochures");

            migrationBuilder.RenameTable(
                name: "ProductBrochures",
                newName: "ProductBrochure");

            migrationBuilder.RenameIndex(
                name: "IX_ProductBrochures_ProductId",
                table: "ProductBrochure",
                newName: "IX_ProductBrochure_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductBrochure",
                table: "ProductBrochure",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ProductBrochure_Products_ProductId",
                table: "ProductBrochure",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
