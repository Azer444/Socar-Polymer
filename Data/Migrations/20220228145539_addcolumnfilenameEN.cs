using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class addcolumnfilenameEN : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DisplayName",
                table: "CertificateComponentFiles",
                newName: "DisplayName_EN");

            migrationBuilder.AddColumn<string>(
                name: "DisplayName_RU",
                table: "CertificateComponentFiles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0dj93jd-3si3-344j-84dj-3djewk3kk5563c",
                column: "ConcurrencyStamp",
                value: "fb21c6fb-c7d9-4595-8021-05cc7b646547");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "52518b95-f728-4c94-b971-733c102fd7a0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d6z593d-5f8e-392d-10zk-132c92mz9482",
                column: "ConcurrencyStamp",
                value: "4d3dce09-e365-4afc-bb3b-1220a6806e39");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69a4b87f-5f78-4916-9428-35fa9778828c", "AQAAAAEAACcQAAAAEDo1XjtcvZQ8KvykNFcVhGqtxCAjA03FPxz4Hl6rWtXWfA4ITd18T6UnxZmDYOctrQ==", "14e90cae-e7a7-4bd5-872b-db3ef281692c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DisplayName_RU",
                table: "CertificateComponentFiles");

            migrationBuilder.RenameColumn(
                name: "DisplayName_EN",
                table: "CertificateComponentFiles",
                newName: "DisplayName");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0dj93jd-3si3-344j-84dj-3djewk3kk5563c",
                column: "ConcurrencyStamp",
                value: "d1bd4315-a7f3-4f7a-aaf9-a05bf144bc19");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "94a8e785-d310-487e-8732-156c2cd5e3e7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d6z593d-5f8e-392d-10zk-132c92mz9482",
                column: "ConcurrencyStamp",
                value: "b1ac3eba-c84d-4efc-82b4-01f5ab44475d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3ecf438-8abe-46e6-a701-949ede0b64af", "AQAAAAEAACcQAAAAEKL0PzVw1Q20MaizxIplvUC9WQiKTWhbhs7/w5Ds7d+CWoOh9uZ2kWDjT9jLOfyO+g==", "29c5bc0f-8b61-441d-86de-f53284c14fe3" });
        }
    }
}
