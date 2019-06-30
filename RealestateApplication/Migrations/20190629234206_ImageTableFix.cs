using Microsoft.EntityFrameworkCore.Migrations;

namespace RealestateApplication.Migrations
{
    public partial class ImageTableFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdOfCorrespondingUser",
                table: "Images",
                newName: "IdOfCorrespondingAd");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdOfCorrespondingAd",
                table: "Images",
                newName: "IdOfCorrespondingUser");
        }
    }
}
