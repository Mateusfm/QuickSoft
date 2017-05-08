using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Formularios.Models
{
    public class User
    {
        [Key]
        [ScaffoldColumn(false)]
        public int UserID { get; set; }

        [Required, StringLength(100), Display(Name = "Name")]
        public string UserName { get; set; }

        [Required]
        public DateTime Data { get; set; }

        [Required, StringLength(100), Display(Name = "Email")]
        public string Email { get; set; }

        public string Phone { get; set; }

        [Required, StringLength(50)]
        public string Cpf { get; set; }

        public string Cnpj { get; set; }

        public string TypeCompany { get; set; }

        public int? CityID { get; set; }

        public virtual City City { get; set; }

        public int? UfID { get; set; }

        public virtual Uf Uf { get; set; }

        [StringLength(1000)]
        public string Observacoes { get; set; }
    }
}