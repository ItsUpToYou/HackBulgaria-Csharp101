using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackCompanyLib
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime DateOfOrder { get; set; }
        public int CustomerId { get; set; }
        public double TotalPrice { get; set; }

        public Order(int id, DateTime dateOfOrder, int customerId, double totalPrice)
        {
            this.OrderId = id;
            this.DateOfOrder = dateOfOrder;
            this.CustomerId = customerId;
            this.TotalPrice = totalPrice;
        }
    }
}
