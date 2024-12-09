using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BD_Kurs.Migrations
{
    /// <inheritdoc />
    public partial class Final1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "m2",
                table: "Details",
                newName: "m");

            migrationBuilder.RenameColumn(
                name: "MArka",
                table: "Details",
                newName: "Mаrka");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "m",
                table: "Details",
                newName: "m2");

            migrationBuilder.RenameColumn(
                name: "Mаrka",
                table: "Details",
                newName: "MArka");
        }
    }
}
