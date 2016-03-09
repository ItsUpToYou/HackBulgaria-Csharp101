using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystem
{
     public class CityManager
    {
        public static void AddCity(string city)
        {
            using (var conn = new CodeFirstTicketSystem())
            {
                City addCity = new City() { Name = city };
                conn.Cities.Add(addCity);
                conn.SaveChanges();
            }
        }
    }
}
