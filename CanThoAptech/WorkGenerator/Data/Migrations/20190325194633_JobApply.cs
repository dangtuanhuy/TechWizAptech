using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkGenerator.Data.Migrations
{
    public partial class JobApply : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JobApply",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    JobId = table.Column<int>(nullable: false),
                    ApplyDetailsId = table.Column<int>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    TrainingId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobApply", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobApply_AppliedDetails_ApplyDetailsId",
                        column: x => x.ApplyDetailsId,
                        principalTable: "AppliedDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobApply_Job_JobId",
                        column: x => x.JobId,
                        principalTable: "Job",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobApply_Training_TrainingId",
                        column: x => x.TrainingId,
                        principalTable: "Training",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_JobApply_ApplyDetailsId",
                table: "JobApply",
                column: "ApplyDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_JobApply_JobId",
                table: "JobApply",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_JobApply_TrainingId",
                table: "JobApply",
                column: "TrainingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobApply");
        }
    }
}
