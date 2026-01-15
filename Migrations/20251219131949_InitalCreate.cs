using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaxisImporter.Migrations
{
    /// <inheritdoc />
    public partial class InitalCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Taxis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pickup = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dropoff = table.Column<DateTime>(type: "datetime2", nullable: false),
                    passengers = table.Column<int>(type: "int", nullable: false),
                    distance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    fare = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    tip = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    toll = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    total = table.Column<double>(type: "float", nullable: false),
                    colour = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    payment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pickupZone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dropoffZone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pickup_borough = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dropoff_borough = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Taxis", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Taxis");
        }
    }
}
