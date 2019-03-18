using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyTrips.Migrations
{
    public partial class Modelo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Host",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    hotelName = table.Column<string>(nullable: false),
                    thumb = table.Column<string>(nullable: false),
                    stars = table.Column<int>(nullable: false),
                    location = table.Column<string>(nullable: false),
                    cityId = table.Column<int>(nullable: false),
                    country = table.Column<string>(nullable: false),
                    date = table.Column<string>(nullable: false),
                    price = table.Column<decimal>(nullable: false),
                    @class = table.Column<string>(name: "class", nullable: false),
                    guest = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Host", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Host_City_cityId",
                        column: x => x.cityId,
                        principalTable: "City",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Host_cityId",
                table: "Host",
                column: "cityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Host");

            migrationBuilder.DropTable(
                name: "City");
        }
    }
}
