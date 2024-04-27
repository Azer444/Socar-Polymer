using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class standartRoleAddded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0dj93jd-3si3-344j-84dj-3djewk3kk5563c", "71939e35-dd4d-4b10-ad25-70326798f375", "Standart", "STANDART" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec906711-6e6a-44ac-9411-6d3019af47a1", "AQAAAAEAACcQAAAAEKH+18ijaHQYZrOwtkWXPuxX+AS7dbJTzKvERC/KoXA2PiTI8MP/WgtV0eWtlemZvA==", "0ef312e9-a59c-4d71-bf1b-14fadb4eba09" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0dj93jd-3si3-344j-84dj-3djewk3kk5563c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "f3452b29-6793-4f21-af2d-49d6f5ad7abf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d6z593d-5f8e-392d-10zk-132c92mz9482",
                column: "ConcurrencyStamp",
                value: "4228f3bc-f36e-4623-9ffc-3cea010ec9d5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a761163-25a0-4f38-92f8-5259aad71d68", "AQAAAAEAACcQAAAAEGiouXCztDe2N9nVby8yrv5EzYs6gkSLzv1iviMjzWVy1/nJwE7eHqExc6aTMS/Hjw==", "d3422aa6-8655-4161-a5cf-91424d4b6094" });
        }
    }
}
