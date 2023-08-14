using Core.Entities.Personnes.Models.DB;

namespace Core.Entities.Personnes.Professeur.DB
{
    public partial class Professeur_C : Personne
    {
        public string Matiere { get; set; }
        public string Bureau { get; set; }
    }
}
