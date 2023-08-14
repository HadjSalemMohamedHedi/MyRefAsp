using Core.Entities.Departement.DB;
using Core.Entities.Personnes.Models.DB;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities.Personnes.Professeur.DB
{
    public partial class Professeur_C : Personne
    {
        public string Matiere { get; set; }
        public string Bureau { get; set; }


        public ICollection<ProfDeparts> ProfDeparts { get; set; }

    }
}
