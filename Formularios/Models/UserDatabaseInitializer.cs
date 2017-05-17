using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Formularios.Models
{
    public class UserDatabaseInitializer : DropCreateDatabaseAlways<UserContext>
    {
        protected override void Seed(UserContext context)
        {   
            // Adiciona dados no banco em tempo de execução
            GetUfs().ForEach(uf      => context.Ufs.Add(uf));
            GetCities().ForEach(city => context.Cities.Add(city));
            GetUsers().ForEach(user  => context.Users.Add(user));

        }

        private static List<User> GetUsers()
        {
            var users = new List<User> {
                new User {
                    UserName = "João",
                    Data     = DateTime.Now,
                    Email    = "joao@hotmail.com",
                    Cpf      = "098.455.132-97",
                    CityID   = 1,
                    UfID     = 1,
                },
                new User {
                    UserName = "Marcos",
                    Data     = DateTime.Now,
                    Email    = "marcos@hotmail.com",
                    Cpf      = "098.455.162-97",
                    CityID   = 3,
                    UfID     = 2,
                }
            };
            return users;
        }


        private static List<City> GetCities()
        {
            var cities = new List<City>
            {
                new City{
                    CityID   = 1,
                    CityName = "Blumenau",
                    UfID     = 1,
                },
                new City{
                    CityID   = 2,
                    CityName = "Joinville",
                    UfID     = 1,
                },
                new City{
                    CityID   = 3,
                    CityName = "Curitiba",
                    UfID     = 2,
                },
                 new City{
                    CityID   = 4,
                    CityName = "Cascavel",
                    UfID     = 2,
                },

            };

            return cities;
        }

        private static List<Uf> GetUfs()
        {
            var ufs = new List<Uf>
            {
                new Uf{
                    UfID   = 1,
                    UfName = "Santa Catarina"
                },
                new Uf{
                    UfID   = 2,
                    UfName = "Paraná"
                }
            };

            return ufs;
        }
    }
}