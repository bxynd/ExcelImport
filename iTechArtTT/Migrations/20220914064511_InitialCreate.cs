using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iTechArtTT.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Pet1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pet1Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pet2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pet2Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pet3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pet3Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
