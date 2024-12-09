using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BD_Kurs.Migrations
{
    /// <inheritdoc />
    public partial class Final : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Khl",
                table: "Sborki",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "thi",
                table: "Sborki",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "thiHP",
                table: "Sborki",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "z",
                table: "Sborki",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Khl",
                table: "Sborki");

            migrationBuilder.DropColumn(
                name: "thi",
                table: "Sborki");

            migrationBuilder.DropColumn(
                name: "thiHP",
                table: "Sborki");

            migrationBuilder.DropColumn(
                name: "z",
                table: "Sborki");
        }
    }
}
