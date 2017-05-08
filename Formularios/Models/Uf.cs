using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Formularios.Models
{
    public class Uf
    {
        [ScaffoldColumn(false)]
        public int UfID { get; set; }

        [Required]
        public string UfName { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}