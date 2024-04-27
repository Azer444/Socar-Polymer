using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class _6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "MarketTitleComponents",
                newName: "Title_RU");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "MarketTitleComponents",
                newName: "Content_RU");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "CertificateComponents",
                newName: "Title_RU");

            migrationBuilder.AddColumn<string>(
                name: "Content_AZ",
                table: "MarketTitleComponents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Content_EN",
                table: "MarketTitleComponents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Slug",
                table: "MarketTitleComponents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title_AZ",
                table: "MarketTitleComponents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title_EN",
                table: "MarketTitleComponents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title_AZ",
                table: "CertificateComponents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title_EN",
                table: "CertificateComponents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "7e8c6d6a-71ba-4ab3-a716-e3e434bfc300");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d6z593d-5f8e-392d-10zk-132c92mz9482",
                column: "ConcurrencyStamp",
                value: "d2220a48-de7f-4270-a8b4-0b61b4e02251");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "752a8b4c-ce5d-4afa-b6bf-55b7be94eac3", "AQAAAAEAACcQAAAAEAErOcaf44xIT4TAQL43xjPFOY6dPgywzIsZB7ipCO1ZImcSnZtvuhC/rnFb5Mg22A==", "351eb123-c973-43fe-a8f8-1f8b9a1fb295" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content_AZ",
                table: "MarketTitleComponents");

            migrationBuilder.DropColumn(
                name: "Content_EN",
                table: "MarketTitleComponents");

            migrationBuilder.DropColumn(
                name: "Slug",
                table: "MarketTitleComponents");

            migrationBuilder.DropColumn(
                name: "Title_AZ",
                table: "MarketTitleComponents");

            migrationBuilder.DropColumn(
                name: "Title_EN",
                table: "MarketTitleComponents");

            migrationBuilder.DropColumn(
                name: "Title_AZ",
                table: "CertificateComponents");

            migrationBuilder.DropColumn(
                name: "Title_EN",
                table: "CertificateComponents");

            migrationBuilder.RenameColumn(
                name: "Title_RU",
                table: "MarketTitleComponents",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Content_RU",
                table: "MarketTitleComponents",
                newName: "Content");

            migrationBuilder.RenameColumn(
                name: "Title_RU",
                table: "CertificateComponents",
                newName: "Title");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "b20f9944-af9e-486d-9dc5-5318ccc00c7c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d6z593d-5f8e-392d-10zk-132c92mz9482",
                column: "ConcurrencyStamp",
                value: "ef19de55-7b97-42f4-b428-a023202246c1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5fddd195-c183-4799-90cd-f2e51d62f7db", "AQAAAAEAACcQAAAAEPmjKz6L+Ig6f+xlClLWV4janx0/AbIeJF1VIpzw+0mGGfpgFO5N2Vp+Htnl7y43YA==", "10705972-5c3c-442d-8819-055f829da8fd" });
        }
    }
}
