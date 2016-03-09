using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystem
{
    public class Schedule
    {
        public Schedule()
        {

        }

        public int ScheduleID { get; set; }
        public string StartingCity { get; set; }
        public string EndCity { get; set; }
        public string CityStop { get; set; }
        public DateTime? TravelTime { get; set; }
        public int TicketPrice { get; set; }


    }
}
