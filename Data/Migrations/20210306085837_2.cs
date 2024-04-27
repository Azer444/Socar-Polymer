using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PhotoPath",
                table: "CertificateComponents",
                newName: "PhotoName");

            migrationBuilder.RenameColumn(
                name: "FilePath",
                table: "CertificateComponentFiles",
                newName: "FileName");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "b856d48e-b355-41a4-a96a-cee105948091");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d6z593d-5f8e-392d-10zk-132c92mz9482",
                column: "ConcurrencyStamp",
                value: "7cc1a27c-a780-42fd-8120-934ac14aac0d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0467f4f8-dccb-4846-bbf2-9b7538f5c32e", "AQAAAAEAACcQAAAAEP66I8Eig0oXznnjCAIuAY6OGz0CnyOyQrUE3wBa17niUwUyWJ43+X9XGF7rwrtCXA==", "67411ac6-4cdd-4e4c-9184-ffbe28bc0268" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PhotoName",
                table: "CertificateComponents",
                newName: "PhotoPath");

            migrationBuilder.RenameColumn(
                name: "FileName",
                table: "CertificateComponentFiles",
                newName: "FilePath");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "f4735403-0cf2-440d-ac79-0741f6ca38cd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d6z593d-5f8e-392d-10zk-132c92mz9482",
                column: "ConcurrencyStamp",
                value: "9689f9f7-d491-41d5-9eea-91955b154594");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d065a213-8e4b-4156-b0dc-372d91d325d6", "AQAAAAEAACcQAAAAEPcd24Quns5CPIK47C5/DzjUYH7uq3AsgaM5Oh57o1GGIsmtU9iqQCFfgWOG3893PQ==", "a994576c-f591-4bf2-95e0-e3ab63aef5fd" });
        }
    }
}
