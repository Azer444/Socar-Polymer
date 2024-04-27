using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class addLanguageToProductFieldModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "ProductFields",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0dj93jd-3si3-344j-84dj-3djewk3kk5563c",
                column: "ConcurrencyStamp",
                value: "52340b84-39e4-4fcb-8b90-6837af95a1fd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "66d4f3b1-f9b9-4b14-bb26-c40379bee71f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d6z593d-5f8e-392d-10zk-132c92mz9482",
                column: "ConcurrencyStamp",
                value: "213d3a01-40c8-41d0-b66e-604875a8acf7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "46141a6b-7d91-429b-9673-79cdfac6d512", "AQAAAAEAACcQAAAAEBL50lgBg+XSy53ociOnMNii5KJV9/9dS4KDVVTtUdvnm3tz4u2dN/ZufbY0j5Y6yw==", "f16a9902-9c20-4c95-ab0b-af863254976c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Language",
                table: "ProductFields");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0dj93jd-3si3-344j-84dj-3djewk3kk5563c",
                column: "ConcurrencyStamp",
                value: "4aeee5dc-2855-4fd8-b29d-1ddb2529baa2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "cb8bcd02-d703-4613-b82a-096772512271");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d6z593d-5f8e-392d-10zk-132c92mz9482",
                column: "ConcurrencyStamp",
                value: "75f3c399-d53b-4669-b78e-e2a4584b4d67");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b495698-9283-4d44-917d-b301b4153451", "AQAAAAEAACcQAAAAEJEXWL2u8a8ItOmC0mnU8XzGrAyPgxhboyOpl9nnRzezbCvMtmdHXrWSSSZRKYkDvw==", "0c4d94fd-6ae5-4e42-bbfb-09be980b1ef1" });
        }
    }
}
