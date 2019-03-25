using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkGenerator.Data.Migrations
{
    public partial class JOK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Others",
                table: "Job",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Others",
                table: "Job");
        }
    }
}
