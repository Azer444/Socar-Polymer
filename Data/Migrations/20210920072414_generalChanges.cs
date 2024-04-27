using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class generalChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "4a547ab2-23e5-4d06-b39e-d0c3761bbeda");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d6z593d-5f8e-392d-10zk-132c92mz9482",
                column: "ConcurrencyStamp",
                value: "9966fa82-d78a-44f7-8b31-bc6986a00984");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e923b299-0554-4993-85a8-c8c18d2417d8", "AQAAAAEAACcQAAAAEBYoDgi/hEhx9uRdJiiSWOg9YX+4UPwxcLVke+xZMj54mkiTm5YhGKEQUF9lqX78lQ==", "adea1241-8477-47f4-b86f-7cb95c4a6d46" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
