using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Personnes.Models.DB
{
    public partial class Personne
    {
        [Key]
        public int PersonneId { get; set;}
        public string Name { get; set;}
        public string firstName { get; set;}
        public DateTime dateBirth { get; set;}
    }
}
