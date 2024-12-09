using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BD_Kurs.Migrations
{
    /// <inheritdoc />
    public partial class wr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Details",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MArka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    T1 = table.Column<int>(type: "int", nullable: false),
                    de1 = table.Column<double>(type: "float", nullable: false),
                    m2 = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Details", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Itogi",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    de1 = table.Column<double>(type: "float", nullable: false),
                    m = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Itogi", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Sborki",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypePer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeOpor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kbe = table.Column<double>(type: "float", nullable: false),
                    HB = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    u = table.Column<double>(type: "float", nullable: false),
                    Mater = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Khb = table.Column<double>(type: "float", nullable: false),
                    Kfb = table.Column<double>(type: "float", nullable: false),
                    Y = table.Column<double>(type: "float", nullable: false),
                    x = table.Column<double>(type: "float", nullable: false),
                    Kd = table.Column<int>(type: "int", nullable: false),
                    Km = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sborki", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Details");

            migrationBuilder.DropTable(
                name: "Itogi");

            migrationBuilder.DropTable(
                name: "Sborki");
        }
    }
}
