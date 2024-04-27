using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class _28 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "ProductTitleCategories",
                newName: "Name_EN");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "ProductCategories",
                newName: "Name_RU");

            migrationBuilder.AddColumn<string>(
                name: "Name_AZ",
                table: "ProductTitleCategories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name_RU",
                table: "ProductTitleCategories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name_AZ",
                table: "ProductCategories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name_EN",
                table: "ProductCategories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "83bbc3fc-83ed-432d-81ae-87c6cb913cc1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d6z593d-5f8e-392d-10zk-132c92mz9482",
                column: "ConcurrencyStamp",
                value: "bd1a6193-ddc5-478a-9b60-cb73b520c312");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84ce720f-4604-468c-aed4-c688fe2daad6", "AQAAAAEAACcQAAAAEBrutHwo8H7WRrRb0qS1juqwNN9VbPXQKBu/fi0duCRjCiLFD8O5bETeJvY+ifNf/A==", "b077d0b6-b280-44ae-a0f2-bb3f571f6cb1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name_AZ",
                table: "ProductTitleCategories");

            migrationBuilder.DropColumn(
                name: "Name_RU",
                table: "ProductTitleCategories");

            migrationBuilder.DropColumn(
                name: "Name_AZ",
                table: "ProductCategories");

            migrationBuilder.DropColumn(
                name: "Name_EN",
                table: "ProductCategories");

            migrationBuilder.RenameColumn(
                name: "Name_EN",
                table: "ProductTitleCategories",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Name_RU",
                table: "ProductCategories",
                newName: "Name");

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
        }
    }
}
