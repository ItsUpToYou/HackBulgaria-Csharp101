using System.ComponentModel.DataAnnotations.Schema;

namespace TicketSystem
{
    public class Seat
    {
        public int SeatId { get; set; }
        public bool FirstClass { get; set; }

        public int TrainsId { get; set; }
        [ForeignKey("TrainsId")]
        public virtual Trains Trains { get; set; }

    }
}
