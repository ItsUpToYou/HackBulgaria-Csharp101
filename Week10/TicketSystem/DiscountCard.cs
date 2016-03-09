using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystem
{
    public class DiscountCard
    {
        public DiscountCard()
        {

        }

        public int DiscountCardId { get; set; }
        public int DiscCardType { get; set; }
        public bool FirstClass { get; set; }
        public ulong DiscCardNumber { get; set; }
    }
}
