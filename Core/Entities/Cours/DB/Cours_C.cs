using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Cours.DB
{
    public partial class Cours_C
    {
        [Key]
        public int CoursId { get; set; }
        public string Name { get; set; }
    }
}
