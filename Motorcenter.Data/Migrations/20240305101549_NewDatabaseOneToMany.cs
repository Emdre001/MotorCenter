using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Motorcenter.Data.Migrations
{
    /// <inheritdoc />
    public partial class NewDatabaseOneToMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TypeVehicle");

            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_TypeId",
                table: "Vehicles",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Types_TypeId",
                table: "Vehicles",
                column: "TypeId",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Types_TypeId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_TypeId",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Vehicles");

            migrationBuilder.CreateTable(
                name: "TypeVehicle",
                columns: table => new
                {
                    VehicleId = table.Column<int>(type: "int", nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeVehicle", x => new { x.VehicleId, x.TypeId });
                    table.ForeignKey(
                        name: "FK_TypeVehicle_Types_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TypeVehicle_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TypeVehicle_TypeId",
                table: "TypeVehicle",
                column: "TypeId");
        }
    }
}
