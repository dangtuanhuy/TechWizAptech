using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkGenerator.Data.Migrations
{
    public partial class UserUD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Companyname",
                table: "AspNetUsers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Companyname",
                table: "AspNetUsers",
                nullable: true);
        }
    }
}
