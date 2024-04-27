using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class langRemovedFromProductField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Language",
                table: "ProductFields");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0dj93jd-3si3-344j-84dj-3djewk3kk5563c",
                column: "ConcurrencyStamp",
                value: "b71cedfb-edde-4adb-b808-3e3d0dc932a1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "89410d0b-3d14-4302-93b9-0180ae76aad9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d6z593d-5f8e-392d-10zk-132c92mz9482",
                column: "ConcurrencyStamp",
                value: "a53ec2f1-aa9f-45a7-be6c-b55bb11e6b16");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f83776ae-27ed-4447-a82a-fc6e226cefee", "AQAAAAEAACcQAAAAEAiL5qXfZI6z6jJRIpWBqq29mpfnJS0CQI4IeU/K3mrdXJcHsQhYUUqxAbuW6EGJKA==", "17163471-77f3-448c-8f1d-b3788241ae3d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
