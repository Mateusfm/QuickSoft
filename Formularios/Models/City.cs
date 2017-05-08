using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Formularios.Models
{
    public class City
    {
        [ScaffoldColumn(false)]
        public int CityID { get; set; }

        public string CityName { get; set; }

        [Required]
        public int? UfID { get; set; }

        public virtual Uf Uf { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}