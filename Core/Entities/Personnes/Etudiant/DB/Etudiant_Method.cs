using Core.Entities.Personnes.Models.DB;

namespace Core.Entities.Personnes.Etudiant.DB
{
    public partial class Etudiant_C : Personne
    {

        public Etudiant_C()
        {
            Niveau = "Default Niveau";
            Programme = "Default Programme eudiant";
        }
    }
}
