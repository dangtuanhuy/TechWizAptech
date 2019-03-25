using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkGenerator.Data.Migrations
{
    public partial class Double3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppliedDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: true),
                    AppliedDate = table.Column<DateTime>(nullable: false),
                    Information = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppliedDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppliedDetails_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ApplyJob",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    JobId = table.Column<string>(nullable: true),
                    ApplyDetailsId = table.Column<int>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    TrainingId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplyJob", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplyJob_AppliedDetails_ApplyDetailsId",
                        column: x => x.ApplyDetailsId,
                        principalTable: "AppliedDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplyJob_AspNetUsers_JobId",
                        column: x => x.JobId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ApplyJob_Training_TrainingId",
                        column: x => x.TrainingId,
                        principalTable: "Training",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppliedDetails_UserId",
                table: "AppliedDetails",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplyJob_ApplyDetailsId",
                table: "ApplyJob",
                column: "ApplyDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplyJob_JobId",
                table: "ApplyJob",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplyJob_TrainingId",
                table: "ApplyJob",
                column: "TrainingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplyJob");

            migrationBuilder.DropTable(
                name: "AppliedDetails");
        }
    }
}
