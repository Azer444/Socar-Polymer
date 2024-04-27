using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class _14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NavTitleComponentId",
                table: "CertificateComponents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "2890c334-16cc-4548-91dd-8514ac59802b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d6z593d-5f8e-392d-10zk-132c92mz9482",
                column: "ConcurrencyStamp",
                value: "8a5c1c95-7026-4e18-bcb2-6fa6ae9737c2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2eecddbf-ed2b-4bbb-8ea4-366e6e9e7012", "AQAAAAEAACcQAAAAECbjwS8h1LCeb4vefkSvDlpKN3DAO7muyHwJsZtAgyGirvLLXClX0GXyZ9YGtdvvRQ==", "178272f2-b44b-4b49-a71e-4854b1d021de" });

            migrationBuilder.CreateIndex(
                name: "IX_CertificateComponents_NavTitleComponentId",
                table: "CertificateComponents",
                column: "NavTitleComponentId");

            migrationBuilder.AddForeignKey(
                name: "FK_CertificateComponents_NavTitleComponents_NavTitleComponentId",
                table: "CertificateComponents",
                column: "NavTitleComponentId",
                principalTable: "NavTitleComponents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CertificateComponents_NavTitleComponents_NavTitleComponentId",
                table: "CertificateComponents");

            migrationBuilder.DropIndex(
                name: "IX_CertificateComponents_NavTitleComponentId",
                table: "CertificateComponents");

            migrationBuilder.DropColumn(
                name: "NavTitleComponentId",
                table: "CertificateComponents");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "5177472f-f43d-493c-9ff7-b648cee6e2be");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d6z593d-5f8e-392d-10zk-132c92mz9482",
                column: "ConcurrencyStamp",
                value: "391d14cb-4533-4b45-bc62-2ce4894392c3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff0b0737-a98a-4761-9d72-c700eb7e0e69", "AQAAAAEAACcQAAAAEPZoR21Xkqtb034nPMbcjXmENbMx6N6f4YMeek7zKhC4WGew+OXHV5TnrPRzJ5P6DQ==", "d523f8d3-0ca8-4c26-9e44-4ed63074f935" });
        }
    }
}
