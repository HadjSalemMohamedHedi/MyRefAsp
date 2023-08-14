using Core.Entities.Personnes.Professeur.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Departement.DB
{
    public class ProfDeparts
    {
        [Key]
        public int ID_ProfDepart { get; set; }
        public int ID_Prof { get; set; }
        public int ID_Departement { get; set; }



        public Professeur_C Professeur { get; set; }
        public Departement_C Departement { get; set; }


    }
}
