using Core.Entities.Personnes.Etudiant.DB;
using Core.Entities.Personnes.Professeur.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Departement.DB
{
    public partial class Departement_C
    {
        [Key]
        public int DepartementId { get; set; }
        public string? Name { get; set; }

        //Chaque Departement contient plusieurs etudiant
        public ICollection<Etudiant_C> Etudiant_C { get; set; }


        //Chaque Departement contient plusieurs Professeur
        public ICollection<ProfDeparts> ProfDeparts { get; set; }



    }
}
