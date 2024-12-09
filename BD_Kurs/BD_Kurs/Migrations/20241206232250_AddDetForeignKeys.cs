using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BD_Kurs.Migrations
{
    /// <inheritdoc />
    public partial class AddDetForeignKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Sborki_DetId",
                table: "Sborki");

            migrationBuilder.DropIndex(
                name: "IX_Itogi_DetId",
                table: "Itogi");

            migrationBuilder.CreateIndex(
                name: "IX_Sborki_DetId",
                table: "Sborki",
                column: "DetId");

            migrationBuilder.CreateIndex(
                name: "IX_Itogi_DetId",
                table: "Itogi",
                column: "DetId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Sborki_DetId",
                table: "Sborki");

            migrationBuilder.DropIndex(
                name: "IX_Itogi_DetId",
                table: "Itogi");

            migrationBuilder.CreateIndex(
                name: "IX_Sborki_DetId",
                table: "Sborki",
                column: "DetId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Itogi_DetId",
                table: "Itogi",
                column: "DetId",
                unique: true);
        }
    }
}
