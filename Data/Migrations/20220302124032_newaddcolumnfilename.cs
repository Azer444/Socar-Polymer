using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class newaddcolumnfilename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FileName_AZ",
                table: "CertificateComponents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FileName_EN",
                table: "CertificateComponents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FileName_RU",
                table: "CertificateComponents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0dj93jd-3si3-344j-84dj-3djewk3kk5563c",
                column: "ConcurrencyStamp",
                value: "fa110c11-3d1b-4a5d-bc03-4775c8da5b66");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "6888b4e4-4892-455f-b67f-5e16c19207ac");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d6z593d-5f8e-392d-10zk-132c92mz9482",
                column: "ConcurrencyStamp",
                value: "d71ccce0-9ac9-47be-ada4-80d3ae0badba");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23ce0b1a-66e8-470c-bab2-543676dddce3", "AQAAAAEAACcQAAAAEMydW5eSqZo+iHdmwUt9BWDQpdeovw8iTPRIr7FbgnQVgpA6gU9EHi+gI192I1uYSQ==", "cdad2ba9-af99-4c9e-a132-411c9731fe37" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileName_AZ",
                table: "CertificateComponents");

            migrationBuilder.DropColumn(
                name: "FileName_EN",
                table: "CertificateComponents");

            migrationBuilder.DropColumn(
                name: "FileName_RU",
                table: "CertificateComponents");

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
    }
}
