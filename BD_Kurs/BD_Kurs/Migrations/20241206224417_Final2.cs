using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BD_Kurs.Migrations
{
    /// <inheritdoc />
    public partial class Final2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DetId",
                table: "Sborki",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DetId",
                table: "Itogi",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Itogi_Details_DetId",
                table: "Itogi",
                column: "DetId",
                principalTable: "Details",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sborki_Details_DetId",
                table: "Sborki",
                column: "DetId",
                principalTable: "Details",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Itogi_Details_DetId",
                table: "Itogi");

            migrationBuilder.DropForeignKey(
                name: "FK_Sborki_Details_DetId",
                table: "Sborki");

            migrationBuilder.DropIndex(
                name: "IX_Sborki_DetId",
                table: "Sborki");

            migrationBuilder.DropIndex(
                name: "IX_Itogi_DetId",
                table: "Itogi");

            migrationBuilder.DropColumn(
                name: "DetId",
                table: "Sborki");

            migrationBuilder.DropColumn(
                name: "DetId",
                table: "Itogi");
        }
    }
}
