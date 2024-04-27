using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class _29 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SustainabilityComponents");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "09eedd4f-a5c8-478a-93ee-927783f39b02");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d6z593d-5f8e-392d-10zk-132c92mz9482",
                column: "ConcurrencyStamp",
                value: "a0d6bcc5-b6af-4d42-b7c9-49c529bc757a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "921aa54d-ce00-4a6d-9f0a-c655f6deed76", "AQAAAAEAACcQAAAAEN33hH+YjCirw8R2mIqQSl/LOxLd96SsRM9KdYABix6X3wNX95hkmRDiFDeX3i9kfQ==", "38b44365-e9ac-4944-b92c-e60dc26684e3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SustainabilityComponents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content_AZ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content_RU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NavTitleComponentId = table.Column<int>(type: "int", nullable: false),
                    PhotoName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Slug = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title_AZ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title_EN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title_RU = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SustainabilityComponents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SustainabilityComponents_NavTitleComponents_NavTitleComponentId",
                        column: x => x.NavTitleComponentId,
                        principalTable: "NavTitleComponents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_SustainabilityComponents_NavTitleComponentId",
                table: "SustainabilityComponents",
                column: "NavTitleComponentId");
        }
    }
}
