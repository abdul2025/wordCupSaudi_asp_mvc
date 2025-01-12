using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace worldcup.Migrations
{
    /// <inheritdoc />
    public partial class changetocategoryTranstoTransportType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transport_CategoriesTransport_VehicleId",
                table: "Transport");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoriesTransport",
                table: "CategoriesTransport");

            migrationBuilder.RenameTable(
                name: "CategoriesTransport",
                newName: "TransportType");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TransportType",
                table: "TransportType",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Transport_TransportType_VehicleId",
                table: "Transport",
                column: "VehicleId",
                principalTable: "TransportType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transport_TransportType_VehicleId",
                table: "Transport");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TransportType",
                table: "TransportType");

            migrationBuilder.RenameTable(
                name: "TransportType",
                newName: "CategoriesTransport");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoriesTransport",
                table: "CategoriesTransport",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Transport_CategoriesTransport_VehicleId",
                table: "Transport",
                column: "VehicleId",
                principalTable: "CategoriesTransport",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
