using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LegoSetInventoryManager.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Set Name",
                columns: table => new
                {
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Theme = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SetNumber = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    Pieces = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    MiniFigs = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    Complete = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Set Name", x => x.Title);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Set Name");
        }
    }
}
