using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackCompanyLib
{
    public class OrderProduct
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        
        public OrderProduct(int orderId, int prodId, int quantity)
        {
            this.OrderId = orderId;
            this.ProductId = prodId;
            this.Quantity = quantity;
        }
    }
}
