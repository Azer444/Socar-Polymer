using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class _31 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AddressContent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title_AZ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title_RU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content_AZ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content_RU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content_EN = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressContent", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactFormComponent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title_AZ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title_RU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subtitle_1_AZ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subtitle_1_RU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subtitle_1_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subtitle_2_AZ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subtitle_2_RU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subtitle_2_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subtitle_3_AZ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subtitle_3_RU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subtitle_3_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subtitle_4_AZ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subtitle_4_RU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subtitle_4_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ButtonText_AZ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ButtonText_RU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ButtonText_EN = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactFormComponent", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactUsContent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title_AZ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title_RU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content_AZ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content_RU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content_EN = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactUsContent", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "7745f03e-3148-4e32-9ca2-75e4e053ebac");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d6z593d-5f8e-392d-10zk-132c92mz9482",
                column: "ConcurrencyStamp",
                value: "68f13d0f-63f0-454e-9b4e-573bac363a29");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d072beb-a92a-4e4e-9f6c-89d72a534c2d", "AQAAAAEAACcQAAAAEOGnxqDiVsM0vzQzsAJJUycVL51YpwaiNvW8YJI7DRiF+BUasLY2NLDlX6AdZBLlNA==", "b7019421-3754-477f-875c-4fdad5e4580e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddressContent");

            migrationBuilder.DropTable(
                name: "ContactFormComponent");

            migrationBuilder.DropTable(
                name: "ContactUsContent");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "17b9ec6a-9e3d-472c-8269-64996304daa5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d6z593d-5f8e-392d-10zk-132c92mz9482",
                column: "ConcurrencyStamp",
                value: "1a7d5df0-78d6-46f9-b50d-a47e3fa62565");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "148b6269-dac8-4ade-a19a-db587472b60b", "AQAAAAEAACcQAAAAEJRQNylYFCG5KWfigfZ9UMwsHOS0t/Kr+0PbSr0k8j39TeMU+HhFiYJ2ekjwT+8bjA==", "93796b66-633a-4528-9c07-c05cc7bd99f6" });
        }
    }
}
