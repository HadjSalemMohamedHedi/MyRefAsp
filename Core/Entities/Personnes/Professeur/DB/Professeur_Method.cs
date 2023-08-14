using Core.Entities.Personnes.Models.DB;

namespace Core.Entities.Personnes.Professeur.DB
{
    public partial class Professeur_C : Personne
    {
        public Professeur_C()
        {
            Matiere = "Default Matiere";
            Bureau = "Default Bureau Professeur";
        }
    }
}
