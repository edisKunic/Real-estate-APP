using Microsoft.EntityFrameworkCore.Migrations;

namespace RealestateApplication.Migrations
{
    public partial class migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Ads",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Ads",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
