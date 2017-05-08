using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Formularios.Models
{
    public class UserContext : DbContext
    {
        public UserContext()
            : base("Formularios")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Uf> Ufs { get; set; }
    }
}