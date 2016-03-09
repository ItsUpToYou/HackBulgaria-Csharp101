using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystem
{
    public class Trains
    {
   
        public int TrainsID { get; set; }
        public int Identifier { get; set; }
        public int SeatId { get; set; }
        public string BriefDescription { get; set; }

        public virtual ICollection<Seat> Seats { get; set; }
    }   
}
