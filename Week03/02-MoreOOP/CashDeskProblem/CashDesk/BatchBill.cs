using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashDesk
{
    public class BatchBill:  IEnumerable
    {
        private List<Bill> batchBill;

        public List<Bill> Batch
        {
            get
            {
                return batchBill;
            }
            set
            {
                this.batchBill = value;
            }
        }
        public BatchBill()
        {

        }

        public BatchBill(List<Bill> money)
        {
            this.batchBill = money;
        }

        public int Count()
        {
            return batchBill.Count();
        }

        public int Total()
        {
            int total = 0;
            for (int i = 0; i < batchBill.Count; i++)
            {
                total += batchBill[i].Value();
            }
            return total;
        }

        public override string ToString()
        {
            string format = string.Format("The Batch {0} have {1} amount", batchBill.Count, Total());
            return format;
        }

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)Batch).GetEnumerator();
        }
    }
}
