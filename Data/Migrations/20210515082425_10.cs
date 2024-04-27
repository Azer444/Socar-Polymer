using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class _10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PhotoPath",
                table: "NavTitleComponents",
                newName: "PhotoName");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "4eb6b7a8-e7e9-42b5-beaa-4031248978b7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d6z593d-5f8e-392d-10zk-132c92mz9482",
                column: "ConcurrencyStamp",
                value: "ad2caf13-fa04-4591-81ae-d0fd04910bc8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d3ef2c1-1c40-4ade-a7de-cec2cf4e8d8c", "AQAAAAEAACcQAAAAEMqA3h2ByElbdEP4czTzCb5h57mP7h38Qi2QQl2XbNWMwmtcDVmj+nQvHYFtvgHDuw==", "3d9d655f-09d7-441e-8a77-03d1c1c9a6b5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PhotoName",
                table: "NavTitleComponents",
                newName: "PhotoPath");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "dc21f762-d6b4-48aa-a23e-e878bf5c8c81");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d6z593d-5f8e-392d-10zk-132c92mz9482",
                column: "ConcurrencyStamp",
                value: "bb1163dc-e83c-4855-91cd-c4d3dd6529d7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c77231e-538c-4cee-b427-39c5e9cc0d64", "AQAAAAEAACcQAAAAEPDqNMQ38UzQjYoN9WJHCTZw45oBNrpdGaLVT+wH6xE+xopRM8el6/K33iYDito/Rg==", "5d81017a-d2ca-4b1d-96e0-eb44f18374d8" });
        }
    }
}
