using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class _33 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ErrorMessage_AZ",
                table: "ContactFormComponent",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ErrorMessage_EN",
                table: "ContactFormComponent",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ErrorMessage_RU",
                table: "ContactFormComponent",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SuccessMessage_AZ",
                table: "ContactFormComponent",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SuccessMessage_EN",
                table: "ContactFormComponent",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SuccessMessage_RU",
                table: "ContactFormComponent",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "ContactMessages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactMessages", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "81a0219c-1afa-4188-a3f4-270880845abd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d6z593d-5f8e-392d-10zk-132c92mz9482",
                column: "ConcurrencyStamp",
                value: "717646a5-b5e6-4f78-932c-345987353937");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6f36269a-97b3-4170-b5af-65c47fcbec0c", "AQAAAAEAACcQAAAAEF8hUn+4PvzvuSvYskWFFZOIE1tMXHKhwDR4ELzboX+WahCODrbDOSbMwUcz+wNGWg==", "4e931b6a-ceaf-4766-b490-cb49cbdddff1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactMessages");

            migrationBuilder.DropColumn(
                name: "ErrorMessage_AZ",
                table: "ContactFormComponent");

            migrationBuilder.DropColumn(
                name: "ErrorMessage_EN",
                table: "ContactFormComponent");

            migrationBuilder.DropColumn(
                name: "ErrorMessage_RU",
                table: "ContactFormComponent");

            migrationBuilder.DropColumn(
                name: "SuccessMessage_AZ",
                table: "ContactFormComponent");

            migrationBuilder.DropColumn(
                name: "SuccessMessage_EN",
                table: "ContactFormComponent");

            migrationBuilder.DropColumn(
                name: "SuccessMessage_RU",
                table: "ContactFormComponent");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "67fd009f-9bba-443a-b9a4-a28db5795a41");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d6z593d-5f8e-392d-10zk-132c92mz9482",
                column: "ConcurrencyStamp",
                value: "777a324a-905a-42ca-b67d-7565608689c6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "625e6424-7a37-4894-a25e-5e8cb94b01cd", "AQAAAAEAACcQAAAAEHwBPqPgwVHyIExGrNkif8Cs1H2HsYVz9x3S0Si6XPG7gpci3KsXod8w6c+k/urUiQ==", "3905e4e6-81f7-4674-9a4b-b7324ad9c460" });
        }
    }
}
