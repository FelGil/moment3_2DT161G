using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace moment3_2.Migrations
{
    public partial class addCDIdToArtist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArtistId",
                table: "Artist");

            migrationBuilder.CreateIndex(
                name: "IX_Cd_ArtistId",
                table: "Cd",
                column: "ArtistId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cd_Artist_ArtistId",
                table: "Cd",
                column: "ArtistId",
                principalTable: "Artist",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cd_Artist_ArtistId",
                table: "Cd");

            migrationBuilder.DropIndex(
                name: "IX_Cd_ArtistId",
                table: "Cd");

            migrationBuilder.AddColumn<int>(
                name: "ArtistId",
                table: "Artist",
                type: "INTEGER",
                nullable: true);
        }
    }
}
