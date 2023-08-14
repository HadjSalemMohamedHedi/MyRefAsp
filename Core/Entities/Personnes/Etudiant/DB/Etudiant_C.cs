using Core.Entities.Personnes.Models.DB;


namespace Core.Entities.Personnes.Etudiant.DB
{
    public partial class Etudiant_C : Personne
    {
        public string? Niveau { get; set; }
        public string? Programme { get; set; }
    }
}
