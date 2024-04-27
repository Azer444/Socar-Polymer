using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class CreateTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0dj93jd-3si3-344j-84dj-3djewk3kk5563c",
                column: "ConcurrencyStamp",
                value: "fdd59ca0-2518-47f9-9aaa-10ad0970e384");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "c3ba0682-e19f-4f99-b446-74b9d2b53204");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d6z593d-5f8e-392d-10zk-132c92mz9482",
                column: "ConcurrencyStamp",
                value: "728cc080-f916-4f4b-a4db-b8eafa1378c1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "231008d6-9853-4960-963a-7a712b2787e1", "AQAAAAEAACcQAAAAEGva6WzQBuwowzY4zIRgHdgaNAosSMkQJNdBYJjI9sGPYDdiskK4JUeadg3Oic9O4A==", "4993d17a-c4bc-451d-9600-f78bf0743e5e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
