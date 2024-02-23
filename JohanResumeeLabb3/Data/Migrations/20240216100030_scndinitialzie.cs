using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JohanResumeeLabb3.Data.Migrations
{
    /// <inheritdoc />
    public partial class scndinitialzie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Jobs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Jobs");
        }
    }
}
