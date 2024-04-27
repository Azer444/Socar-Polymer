using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class _4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PhotoPath",
                table: "SustainabilityComponents",
                newName: "PhotoName");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "cdde6095-e931-46ed-89c7-66dea7a8ad4c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d6z593d-5f8e-392d-10zk-132c92mz9482",
                column: "ConcurrencyStamp",
                value: "7bc9d6c1-e0d4-45ba-9eaf-4d0eb6a52586");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b558ed4d-e58a-4f7d-b117-9c961b66e89f", "AQAAAAEAACcQAAAAEIkm5T7tAnY3r4C2qRDnFDmsZnRJreEVpVG57CLLTz/IUmOBqsT1HWlBCltM1kn49Q==", "45127393-c7aa-477d-9445-ded93bd6058a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PhotoName",
                table: "SustainabilityComponents",
                newName: "PhotoPath");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "2e567134-c573-4183-b810-323b93331a6d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d6z593d-5f8e-392d-10zk-132c92mz9482",
                column: "ConcurrencyStamp",
                value: "d523869b-1b66-4977-9701-79ecf34a1847");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c5bcf32b-ee85-41a0-a6d3-9a5b66a37339", "AQAAAAEAACcQAAAAECL4YQgeY+OmtxovdWAsXDO4CaBMZ9K2FO3p9dgYN0tzB0OPnUYTuWpwL8XqtIS2/g==", "e54249eb-b58e-4c1a-9aea-492112ae41e0" });
        }
    }
}
