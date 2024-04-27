using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class adddb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0dj93jd-3si3-344j-84dj-3djewk3kk5563c",
                column: "ConcurrencyStamp",
                value: "a4b604f9-f478-46a5-aef6-fef74c173cd3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "b19c2220-d946-4949-9085-5d77b3ad63df");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d6z593d-5f8e-392d-10zk-132c92mz9482",
                column: "ConcurrencyStamp",
                value: "e4bb7f3b-7e20-47a6-9aab-aa63efd15e3c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "826eff15-2cf5-4bb8-8b66-edaf3596e364", "AQAAAAEAACcQAAAAEHr0lK5ZYbdaxRxTS7Q9iD7ORabqMV1Y5pZkjcWWd0tUevoqK2lG5881Evjoeeenvw==", "8de31e0b-72aa-4348-bdec-ffdcd472a071" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0dj93jd-3si3-344j-84dj-3djewk3kk5563c",
                column: "ConcurrencyStamp",
                value: "a08018f6-c721-483f-b5b6-9c02f3562c0b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "840c590c-f9c5-4408-af89-de7525b33a4d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d6z593d-5f8e-392d-10zk-132c92mz9482",
                column: "ConcurrencyStamp",
                value: "7dab3eee-eb11-496a-b918-5d7022914c09");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cea58b34-31f3-45b5-bba6-0a0ccada3817", "AQAAAAEAACcQAAAAEOqyIAAYJOJBkysrCYi38KxYWMDIBj5DDgbmZ4pJZ39I0mSUD++wUTBTA3MBZNVwWw==", "11f1fe4b-5b11-4492-b67e-cae7248e00a1" });
        }
    }
}
