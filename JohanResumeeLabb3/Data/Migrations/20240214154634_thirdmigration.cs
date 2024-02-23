using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JohanResumeeLabb3.Data.Migrations
{
    /// <inheritdoc />
    public partial class thirdmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Education_About_AboutId",
                table: "Education");

            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_About_AboutId",
                table: "Jobs");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_About_AboutId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_About_AboutId",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_Skills_AboutId",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_Projects_AboutId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Jobs_AboutId",
                table: "Jobs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Education",
                table: "Education");

            migrationBuilder.DropIndex(
                name: "IX_Education_AboutId",
                table: "Education");

            migrationBuilder.DropColumn(
                name: "AboutId",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "AboutId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "AboutId",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "AboutId",
                table: "Education");

            migrationBuilder.RenameTable(
                name: "Education",
                newName: "Educations");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "About",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Educations",
                table: "Educations",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Educations",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "About");

            migrationBuilder.RenameTable(
                name: "Educations",
                newName: "Education");

            migrationBuilder.AddColumn<int>(
                name: "AboutId",
                table: "Skills",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AboutId",
                table: "Projects",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AboutId",
                table: "Jobs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AboutId",
                table: "Education",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Education",
                table: "Education",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_AboutId",
                table: "Skills",
                column: "AboutId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_AboutId",
                table: "Projects",
                column: "AboutId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_AboutId",
                table: "Jobs",
                column: "AboutId");

            migrationBuilder.CreateIndex(
                name: "IX_Education_AboutId",
                table: "Education",
                column: "AboutId");

            migrationBuilder.AddForeignKey(
                name: "FK_Education_About_AboutId",
                table: "Education",
                column: "AboutId",
                principalTable: "About",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_About_AboutId",
                table: "Jobs",
                column: "AboutId",
                principalTable: "About",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_About_AboutId",
                table: "Projects",
                column: "AboutId",
                principalTable: "About",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_About_AboutId",
                table: "Skills",
                column: "AboutId",
                principalTable: "About",
                principalColumn: "Id");
        }
    }
}
