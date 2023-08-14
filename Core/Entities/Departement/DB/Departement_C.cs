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
    }
}
