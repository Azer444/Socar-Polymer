using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class _24 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "ProductFields",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "PhotoName",
                table: "CertificateComponents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "5285fb07-b95c-47c8-b944-5e1767774bf4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d6z593d-5f8e-392d-10zk-132c92mz9482",
                column: "ConcurrencyStamp",
                value: "be3f40be-5370-4f55-8d8a-ecd909abefa9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "742ed686-963d-4b9f-904e-97249ddc5912", "AQAAAAEAACcQAAAAENJKmRDpmRKpq739643ghj5TRdolskXPsfzuRL7mV57n1Hno121BaDi6ytco5dkGNw==", "c2678e86-dcbf-4958-b019-11d41eee94dc" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotoName",
                table: "CertificateComponents");

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "ProductFields",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "ba0141b0-9a02-4ac1-878b-f49f6e52fbf3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d6z593d-5f8e-392d-10zk-132c92mz9482",
                column: "ConcurrencyStamp",
                value: "1c58b338-07be-4813-896e-e1de29a8e949");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f014da25-c049-4384-a7ff-c825942fc10e", "AQAAAAEAACcQAAAAEETvQfmNgcoDdl8q0BqwXThPBhQYJLsmgZR6zteCOg3XTkWfZBHC5h5+1d4gUI656g==", "f9273586-c850-474b-952e-f30fb032801f" });
        }
    }
}
