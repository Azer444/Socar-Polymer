using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class _25 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "News",
                newName: "Title_RU");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "News",
                newName: "Title_EN");

            migrationBuilder.AddColumn<string>(
                name: "Content_AZ",
                table: "News",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Content_EN",
                table: "News",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Content_RU",
                table: "News",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhotoName",
                table: "News",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Slug",
                table: "News",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title_AZ",
                table: "News",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content_AZ",
                table: "News");

            migrationBuilder.DropColumn(
                name: "Content_EN",
                table: "News");

            migrationBuilder.DropColumn(
                name: "Content_RU",
                table: "News");

            migrationBuilder.DropColumn(
                name: "PhotoName",
                table: "News");

            migrationBuilder.DropColumn(
                name: "Slug",
                table: "News");

            migrationBuilder.DropColumn(
                name: "Title_AZ",
                table: "News");

            migrationBuilder.RenameColumn(
                name: "Title_RU",
                table: "News",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Title_EN",
                table: "News",
                newName: "Content");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "5285fb07-b95c-47c8-b944-5e1767774bf4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d6z593d-5f8e-392d-10zk-132c92mz9482",
                column: "ConcurrencyStamp",
                value: "be3f40be-5370-4f55-8d8a-ecd909abefa9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "742ed686-963d-4b9f-904e-97249ddc5912", "AQAAAAEAACcQAAAAENJKmRDpmRKpq739643ghj5TRdolskXPsfzuRL7mV57n1Hno121BaDi6ytco5dkGNw==", "c2678e86-dcbf-4958-b019-11d41eee94dc" });
        }
    }
}
