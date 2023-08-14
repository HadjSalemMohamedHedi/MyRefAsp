using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cours_C",
                columns: table => new
                {
                    CoursId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cours_C", x => x.CoursId);
                });

            migrationBuilder.CreateTable(
                name: "Departement_C",
                columns: table => new
                {
                    DepartementId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departement_C", x => x.DepartementId);
                });

            migrationBuilder.CreateTable(
                name: "Etudiant_C",
                columns: table => new
                {
                    PersonneId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Niveau = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Programme = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    firstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dateBirth = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etudiant_C", x => x.PersonneId);
                });

            migrationBuilder.CreateTable(
                name: "Professeur_C",
                columns: table => new
                {
                    PersonneId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Matiere = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bureau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    firstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dateBirth = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professeur_C", x => x.PersonneId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cours_C");

            migrationBuilder.DropTable(
                name: "Departement_C");

            migrationBuilder.DropTable(
                name: "Etudiant_C");

            migrationBuilder.DropTable(
                name: "Professeur_C");
        }
    }
}
