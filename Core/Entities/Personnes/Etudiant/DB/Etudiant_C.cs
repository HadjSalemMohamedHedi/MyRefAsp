using Core.Entities.Departement.DB;
using Core.Entities.Personnes.Models.DB;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities.Personnes.Etudiant.DB
{
    public partial class Etudiant_C : Personne
    {
        public string? Niveau { get; set; }
        public string? Programme { get; set; }

        //Chaque Etudiant appartient à un seul departement
        [ForeignKey("Departement_C")]
        public int Departement_CId { get; set; }
        public Departement_C? Departement_C { get; set; }


    }
}
