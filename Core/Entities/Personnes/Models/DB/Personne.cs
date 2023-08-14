using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Personnes.Models.DB
{
    public partial class Personne
    {
        public int PersonneId { get; set;}
        public string Name { get; set;}
        public string firstName { get; set;}
        public DateOnly dateBirth { get; set;}
    }
}
