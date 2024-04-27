using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class tdsAndSdsModified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TDSName",
                table: "Products",
                newName: "TDSName_RU");

            migrationBuilder.RenameColumn(
                name: "SDSName",
                table: "Products",
                newName: "TDSName_EN");

            migrationBuilder.AddColumn<string>(
                name: "SDSName_AZ",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SDSName_EN",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SDSName_RU",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TDSName_AZ",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0dj93jd-3si3-344j-84dj-3djewk3kk5563c",
                column: "ConcurrencyStamp",
                value: "52273840-278e-441f-8196-2ce3b57e2536");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "310a1edb-6998-46b4-86da-889ecadfb027");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d6z593d-5f8e-392d-10zk-132c92mz9482",
                column: "ConcurrencyStamp",
                value: "cf34d44f-dbfe-4806-9284-07c392edd3a1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "732375f6-83e7-44b3-bff7-cf1d5ae844b3", "AQAAAAEAACcQAAAAEF0IrSjQApzJVTzsp0eDRX/wUPr6/BjtaZdfQTyp8AgqavERstA+PTJSrZ1T9s8l4Q==", "93c623c6-fcfc-4a26-bc65-528f4fd648af" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SDSName_AZ",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SDSName_EN",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SDSName_RU",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "TDSName_AZ",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "TDSName_RU",
                table: "Products",
                newName: "TDSName");

            migrationBuilder.RenameColumn(
                name: "TDSName_EN",
                table: "Products",
                newName: "SDSName");

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
    }
}
