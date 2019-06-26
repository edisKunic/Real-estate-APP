using Microsoft.EntityFrameworkCore.Migrations;

namespace RealestateApplication.Migrations
{
    public partial class updateAd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OfferType",
                table: "Ads",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OfferType",
                table: "Ads");
        }
    }
}
