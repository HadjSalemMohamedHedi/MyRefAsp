using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core.Migrations
{
    public partial class RelationProfesseurDeparmanyTomany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "ProfDeparts",
                columns: table => new
                {
                    ID_ProfDepart = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Prof = table.Column<int>(type: "int", nullable: false),
                    ID_Departement = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfDeparts", x => x.ID_ProfDepart);
                    table.ForeignKey(
                        name: "FK_ProfDeparts_Departement_C_ID_Departement",
                        column: x => x.ID_Departement,
                        principalTable: "Departement_C",
                        principalColumn: "DepartementId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfDeparts_Professeur_C_ID_Prof",
                        column: x => x.ID_Prof,
                        principalTable: "Professeur_C",
                        principalColumn: "PersonneId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProfDeparts_ID_Departement",
                table: "ProfDeparts",
                column: "ID_Departement");

            migrationBuilder.CreateIndex(
                name: "IX_ProfDeparts_ID_Prof",
                table: "ProfDeparts",
                column: "ID_Prof");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProfDeparts");

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
    }
}
