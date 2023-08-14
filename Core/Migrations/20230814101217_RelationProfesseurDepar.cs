using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core.Migrations
{
    public partial class RelationProfesseurDepar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Departement_CId",
                table: "Professeur_C",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Professeur_C_Departement_CId",
                table: "Professeur_C",
                column: "Departement_CId");

            migrationBuilder.AddForeignKey(
                name: "FK_Professeur_C_Departement_C_Departement_CId",
                table: "Professeur_C",
                column: "Departement_CId",
                principalTable: "Departement_C",
                principalColumn: "DepartementId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Professeur_C_Departement_C_Departement_CId",
                table: "Professeur_C");

            migrationBuilder.DropIndex(
                name: "IX_Professeur_C_Departement_CId",
                table: "Professeur_C");

            migrationBuilder.DropColumn(
                name: "Departement_CId",
                table: "Professeur_C");
        }
    }
}
