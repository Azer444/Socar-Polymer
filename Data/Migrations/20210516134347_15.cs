using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class _15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Content",
                table: "CertificateComponents",
                newName: "Slug");

            migrationBuilder.AddColumn<string>(
                name: "Content_AZ",
                table: "CertificateComponents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Content_EN",
                table: "CertificateComponents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Content_RU",
                table: "CertificateComponents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "3ee4527d-ef16-4fc3-956c-217e90f4b6d5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d6z593d-5f8e-392d-10zk-132c92mz9482",
                column: "ConcurrencyStamp",
                value: "0ea723b0-91ac-40a2-abd4-aadd326441c6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "27ead182-8848-4cdf-b79c-d156752b1f1c", "AQAAAAEAACcQAAAAEIO36Zg1uqM6Ws3jsBdYwymfSEpmpJ1XHGd5JweaYfNroMTYeDdF7D/m8A6VyUjSOA==", "2958e9c1-e1d5-4423-ab12-a703e660b81d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content_AZ",
                table: "CertificateComponents");

            migrationBuilder.DropColumn(
                name: "Content_EN",
                table: "CertificateComponents");

            migrationBuilder.DropColumn(
                name: "Content_RU",
                table: "CertificateComponents");

            migrationBuilder.RenameColumn(
                name: "Slug",
                table: "CertificateComponents",
                newName: "Content");

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
        }
    }
}
