using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace jjodel_persistence.Migrations
{
    /// <inheritdoc />
    public partial class addedtemplates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProjectTemplates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    State = table.Column<string>(type: "text", nullable: false),
                    ViewpointsNumber = table.Column<double>(type: "double precision", nullable: false),
                    MetamodelsNumber = table.Column<double>(type: "double precision", nullable: false),
                    ModelsNumber = table.Column<double>(type: "double precision", nullable: false),
                    Creation = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTemplates", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectTemplates");
        }
    }
}
