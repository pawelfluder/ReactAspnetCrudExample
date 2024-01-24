using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharpCountriesProg.Migrations
{
    /// <inheritdoc />
    public partial class Countries_CreateTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(4000)", nullable: false),
                    Capital = table.Column<string>(type: "nvarchar(4000)", nullable: false),
                    SurfaceAreaKm2 = table.Column<int>(type: "int", nullable: false),
                    PopulationMln = table.Column<double>(type: "float", nullable: false),
                    President = table.Column<string>(type: "nvarchar(4000)", nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(4000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
