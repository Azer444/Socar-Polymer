using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class managerEmailConfirmedTrue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0dj93jd-3si3-344j-84dj-3djewk3kk5563c",
                column: "ConcurrencyStamp",
                value: "4ae4b78d-85fb-4d59-9614-adadf22388b4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "114fd0bc-b8fa-489a-b621-ac31d96bf42d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d6z593d-5f8e-392d-10zk-132c92mz9482",
                column: "ConcurrencyStamp",
                value: "025c9089-90b5-4115-8266-03aad124fdcd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e9307726-5bf7-45bf-b3e5-f27b21359237", true, "AQAAAAEAACcQAAAAENqlQv8krv7U/cE+Nf0G/h1au5x+xytbKyRnzLes4rMgoF6WyfKJfXr18hoTlQ34XQ==", "23cd4d8b-e0e6-47d9-9c2f-9aa3c583a4f2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0dj93jd-3si3-344j-84dj-3djewk3kk5563c",
                column: "ConcurrencyStamp",
                value: "71939e35-dd4d-4b10-ad25-70326798f375");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "af917413-3560-476d-8af2-1788395f9048");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d6z593d-5f8e-392d-10zk-132c92mz9482",
                column: "ConcurrencyStamp",
                value: "23ee3782-3a6d-469f-8079-414d20c334aa");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec906711-6e6a-44ac-9411-6d3019af47a1", false, "AQAAAAEAACcQAAAAEKH+18ijaHQYZrOwtkWXPuxX+AS7dbJTzKvERC/KoXA2PiTI8MP/WgtV0eWtlemZvA==", "0ef312e9-a59c-4d71-bf1b-14fadb4eba09" });
        }
    }
}
