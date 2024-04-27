using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class _16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "SustainabilityComponents",
                newName: "Title_RU");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "SustainabilityComponents",
                newName: "Slug");

            migrationBuilder.AddColumn<string>(
                name: "Content_AZ",
                table: "SustainabilityComponents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Content_EN",
                table: "SustainabilityComponents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Content_RU",
                table: "SustainabilityComponents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NavTitleComponentId",
                table: "SustainabilityComponents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Title_AZ",
                table: "SustainabilityComponents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title_EN",
                table: "SustainabilityComponents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "96df5ecd-1705-4f86-94b2-638d2f759754");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d6z593d-5f8e-392d-10zk-132c92mz9482",
                column: "ConcurrencyStamp",
                value: "8fac4210-e190-4b28-a2c4-accb7c59c697");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94c234a8-4ce0-4353-97a0-7b5e5e270da2", "AQAAAAEAACcQAAAAEFSaKVjwF15Hdaf7K/wuNLV3Lq9RDGsQaxPIQeWVUxWH8G5zbrZOYQVH+39uz1Pn6A==", "f8a335ee-8e16-4f72-a94b-a29ee689a7d2" });

            migrationBuilder.CreateIndex(
                name: "IX_SustainabilityComponents_NavTitleComponentId",
                table: "SustainabilityComponents",
                column: "NavTitleComponentId");

            migrationBuilder.AddForeignKey(
                name: "FK_SustainabilityComponents_NavTitleComponents_NavTitleComponentId",
                table: "SustainabilityComponents",
                column: "NavTitleComponentId",
                principalTable: "NavTitleComponents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SustainabilityComponents_NavTitleComponents_NavTitleComponentId",
                table: "SustainabilityComponents");

            migrationBuilder.DropIndex(
                name: "IX_SustainabilityComponents_NavTitleComponentId",
                table: "SustainabilityComponents");

            migrationBuilder.DropColumn(
                name: "Content_AZ",
                table: "SustainabilityComponents");

            migrationBuilder.DropColumn(
                name: "Content_EN",
                table: "SustainabilityComponents");

            migrationBuilder.DropColumn(
                name: "Content_RU",
                table: "SustainabilityComponents");

            migrationBuilder.DropColumn(
                name: "NavTitleComponentId",
                table: "SustainabilityComponents");

            migrationBuilder.DropColumn(
                name: "Title_AZ",
                table: "SustainabilityComponents");

            migrationBuilder.DropColumn(
                name: "Title_EN",
                table: "SustainabilityComponents");

            migrationBuilder.RenameColumn(
                name: "Title_RU",
                table: "SustainabilityComponents",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Slug",
                table: "SustainabilityComponents",
                newName: "Content");

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
    }
}
