using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class addcolumnfilename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FileName",
                table: "CertificateComponentFiles",
                newName: "FileName_EN");

            migrationBuilder.AddColumn<string>(
                name: "FileName_RU",
                table: "CertificateComponentFiles",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileName_RU",
                table: "CertificateComponentFiles");

            migrationBuilder.RenameColumn(
                name: "FileName_EN",
                table: "CertificateComponentFiles",
                newName: "FileName");

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
    }
}
