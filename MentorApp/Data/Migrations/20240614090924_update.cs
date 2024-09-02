using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MentorApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mentor_Categories_CategoryId",
                table: "Mentor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mentor",
                table: "Mentor");

            migrationBuilder.RenameTable(
                name: "Mentor",
                newName: "Mentors");

            migrationBuilder.RenameIndex(
                name: "IX_Mentor_CategoryId",
                table: "Mentors",
                newName: "IX_Mentors_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mentors",
                table: "Mentors",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Mentors_Categories_CategoryId",
                table: "Mentors",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mentors_Categories_CategoryId",
                table: "Mentors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mentors",
                table: "Mentors");

            migrationBuilder.RenameTable(
                name: "Mentors",
                newName: "Mentor");

            migrationBuilder.RenameIndex(
                name: "IX_Mentors_CategoryId",
                table: "Mentor",
                newName: "IX_Mentor_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mentor",
                table: "Mentor",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Mentor_Categories_CategoryId",
                table: "Mentor",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
