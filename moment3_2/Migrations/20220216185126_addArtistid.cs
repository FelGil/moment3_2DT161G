using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace moment3_2.Migrations
{
    public partial class addArtistid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ArtistId",
                table: "Cd",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ArtistId",
                table: "Artist",
                type: "INTEGER",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArtistId",
                table: "Cd");

            migrationBuilder.DropColumn(
                name: "ArtistId",
                table: "Artist");
        }
    }
}
