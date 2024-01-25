#nullable disable

namespace Motorcenter.Data.Migrations
{
    /// <summary>
    /// Migrationsklass för att skapa och ta bort tabeller och relationer i databasen.
    /// </summary>
    public partial class Initial : Migration
    {
        /// <summary>
        /// Metod för att definiera ändringar som ska utföras vid uppdatering av databasen (Up-metoden).
        /// </summary>
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Skapa Brands-tabellen
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),  // Automatiskt generera Id med en ökande sekvens
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)  // Kräv att Name inte kan vara null
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);  // Sätt primärnyckel för Brands-tabellen till Id
                });

            // Skapa Colors-tabellen
            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),  // Automatiskt generera Id med en ökande sekvens
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),  // Kräv att Name inte kan vara null
                    OptionType = table.Column<int>(type: "int", nullable: false)  // Kräv att OptionType inte kan vara null
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);  // Sätt primärnyckel för Colors-tabellen till Id
                });

            // Skapa Filters-tabellen
            migrationBuilder.CreateTable(
                name: "Filters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),  // Automatiskt generera Id med en ökande sekvens
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),  // Kräv att Name inte kan vara null
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),  // Kräv att TypeName inte kan vara null
                    OptionType = table.Column<int>(type: "int", nullable: false)  // Kräv att OptionType inte kan vara null
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filters", x => x.Id);  // Sätt primärnyckel för Filters-tabellen till Id
                });

            // Skapa Fuels-tabellen
            migrationBuilder.CreateTable(
                name: "Fuels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),  // Automatiskt generera Id med en ökande sekvens
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),  // Kräv att Name inte kan vara null
                    OptionType = table.Column<int>(type: "int", nullable: false)  // Kräv att OptionType inte kan vara null
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fuels", x => x.Id);  // Sätt primärnyckel för Fuels-tabellen till Id
                });

            // Skapa Mileages-tabellen
            migrationBuilder.CreateTable(
                name: "Mileages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),  // Automatiskt generera Id med en ökande sekvens
                    Range = table.Column<string>(type: "nvarchar(max)", nullable: false)  // Kräv att Range inte kan vara null
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mileages", x => x.Id);  // Sätt primärnyckel för Mileages-tabellen till Id
                });

            // Skapa VehicleTypes-tabellen
            migrationBuilder.CreateTable(
                name: "VehicleTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),  // Automatiskt generera Id med en ökande sekvens
                    Suv = table.Column<string>(type: "nvarchar(max)", nullable: false),  // Kräv att Suv inte kan vara null
                    Sedan = table.Column<string>(type: "nvarchar(max)", nullable: false),  // Kräv att Sedan inte kan vara null
                    Kombi = table.Column<string>(type: "nvarchar(max)", nullable: false),  // Kräv att Kombi inte kan vara null
                    Van = table.Column<string>(type: "nvarchar(max)", nullable: false)  // Kräv att Van inte kan vara null
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleTypes", x => x.Id);  // Sätt primärnyckel för VehicleTypes-tabellen till Id
                });

            // Skapa Years-tabellen
            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),  // Automatiskt generera Id med en ökande sekvens
                    Range = table.Column<string>(type: "nvarchar(max)", nullable: false)  // Kräv att Range inte kan vara null
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);  // Sätt primärnyckel för Years-tabellen till Id
                });

            // Skapa VehicleTypeFilters-tabellen
            migrationBuilder.CreateTable(
                name: "BrandFilters",
                columns: table => new
                {
                    FilterId = table.Column<int>(type: "int", nullable: false),
                    VehicleTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrandFilters", x => new { x.VehicleTypeId, x.FilterId });
                    table.ForeignKey(
                        name: "FK_VehicleTypeFilters_Filters_FilterId",
                        column: x => x.FilterId,
                        principalTable: "Filters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VehicleTypeFilters_VehicleTypes_VehicleTypeId",
                        column: x => x.VehicleTypeId,
                        principalTable: "VehicleTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            // Skapa Vehicles-tabellen
            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),  // Automatiskt generera Id med en ökande sekvens
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),  // Kräv att Name inte kan vara null
                    YearId = table.Column<int>(type: "int", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    MileageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);  // Sätt primärnyckel för Vehicles-tabellen till Id
                    table.ForeignKey(
                        name: "FK_Vehicles_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehicles_Mileages_MileageId",
                        column: x => x.MileageId,
                        principalTable: "Mileages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehicles_Years_YearId",
                        column: x => x.YearId,
                        principalTable: "Years",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            // Skapa VehicleColors-tabellen
            migrationBuilder.CreateTable(
                name: "VehicleColors",
                columns: table => new
                {
                    VehicleId = table.Column<int>(type: "int", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleColors", x => new { x.VehicleId, x.ColorId });
                    table.ForeignKey(
                        name: "FK_VehicleColors_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VehicleColors_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            // Skapa VehicleFuels-tabellen
            migrationBuilder.CreateTable(
                name: "VehicleFuels",
                columns: table => new
                {
                    VehicleId = table.Column<int>(type: "int", nullable: false),
                    FuelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleFuels", x => new { x.FuelId, x.VehicleId });
                    table.ForeignKey(
                        name: "FK_VehicleFuels_Fuels_FuelId",
                        column: x => x.FuelId,
                        principalTable: "Fuels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VehicleFuels_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            // Skapa vehicleTypeVehicles-tabellen
            migrationBuilder.CreateTable(
                name: "vehicleTypeVehicles",
                columns: table => new
                {
                    VehicleId = table.Column<int>(type: "int", nullable: false),
                    VehicleTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehicleTypeVehicles", x => new { x.VehicleId, x.VehicleTypeId });
                    table.ForeignKey(
                        name: "FK_vehicleTypeVehicles_VehicleTypes_VehicleTypeId",
                        column: x => x.VehicleTypeId,
                        principalTable: "VehicleTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_vehicleTypeVehicles_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            // Skapa index för VehicleColors-tabellen
            migrationBuilder.CreateIndex(
                name: "IX_BrandFilters_FilterId",
                table: "BrandFilters",
                column: "FilterId");


            // Skapa unikt index för Vehicles-tabellen
            migrationBuilder.CreateIndex(
                name: "IX_VehicleTypes_VehicleId",
                table: "VehicleTypes",
                column: "VehicleId");
              

            
        }

        /// <summary>
        /// Metod för att definiera ångradetillståndet vid nedgradering av databasen (Down-metoden).
        /// </summary>
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Ångra skapandet av tabellerna och deras relationer

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "BrandFilters");

            migrationBuilder.DropTable(
                name: "BrandVehicleTypes");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Filters");

            migrationBuilder.DropTable(
                name: "Fuels");

            migrationBuilder.DropTable(
                name: "Mileages");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "VehicleTypes");
        }
    }
}
