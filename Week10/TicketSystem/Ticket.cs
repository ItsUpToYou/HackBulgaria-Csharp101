using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystem
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public DateTime TripDateAndTime { get; set; }
        public int OriginalPrice { get; set; }
        public int PriceSold { get; set; }
        public int UserSoldTo { get; set; }
        public int SeatNumber { get; set; }

    }
}
