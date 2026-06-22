using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpaceObjects.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CosmoObjects",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    MassInTons = table.Column<double>(type: "double precision", nullable: false),
                    SpeedKmPerSecond = table.Column<double>(type: "double precision", nullable: false),
                    AgeInBillionYears = table.Column<double>(type: "double precision", nullable: false),
                    Type = table.Column<string>(type: "character varying(13)", maxLength: 13, nullable: false),
                    DiameterInKm = table.Column<double>(type: "double precision", nullable: true),
                    Material = table.Column<string>(type: "text", nullable: true),
                    EventHorizonRadiusInKm = table.Column<double>(type: "double precision", nullable: true),
                    GravityPower = table.Column<double>(type: "double precision", nullable: true),
                    HasLife = table.Column<bool>(type: "boolean", nullable: true),
                    Atmosphere = table.Column<string>(type: "text", nullable: true),
                    RadiusInKm = table.Column<double>(type: "double precision", nullable: true),
                    TemperatureInKelvin = table.Column<double>(type: "double precision", nullable: true),
                    Color = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CosmoObjects", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CosmoObjects");
        }
    }
}
