using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace jjodel_persistence.Migrations
{
    /// <inheritdoc />
    public partial class addedversion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Version",
                table: "ProjectTemplates",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Version",
                table: "ProjectTemplates");
        }
    }
}
