using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WeatherAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class addedShipBetweenWeatherAndAppUSer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AddById",
                table: "WeatherForecasts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AddedById",
                table: "WeatherForecasts",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_WeatherForecasts_AddedById",
                table: "WeatherForecasts",
                column: "AddedById");

            migrationBuilder.AddForeignKey(
                name: "FK_WeatherForecasts_AspNetUsers_AddedById",
                table: "WeatherForecasts",
                column: "AddedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WeatherForecasts_AspNetUsers_AddedById",
                table: "WeatherForecasts");

            migrationBuilder.DropIndex(
                name: "IX_WeatherForecasts_AddedById",
                table: "WeatherForecasts");

            migrationBuilder.DropColumn(
                name: "AddById",
                table: "WeatherForecasts");

            migrationBuilder.DropColumn(
                name: "AddedById",
                table: "WeatherForecasts");
        }
    }
}
