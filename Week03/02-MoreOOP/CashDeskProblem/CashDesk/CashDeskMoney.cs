using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashDesk
{
    public class CashDeskMoney
    {
        private Dictionary<Bill, int> repository = new Dictionary<Bill, int>();

        public void TakeMoney(Bill bill)
        {
            if (repository.ContainsKey(bill))
            {
                repository[bill]++;
            }
            else
            {
                repository.Add(bill, 1);
            }
        }

        public void TakeMoney(BatchBill batchBill)
        {
            foreach (Bill bbill in batchBill)
            {
                if (repository.ContainsKey(bbill))
                {
                    repository[bbill]++;
                }
                else
                {
                    repository.Add(bbill, 1);
                }
            }
        }

        public int Total()
        {
            int sum = 0;
            foreach (var bill in repository)
            {
                sum += bill.Key.Value() * bill.Value;
            }
            return sum;
        }

        public void Inspect()
        {            
            var bills = from pair in repository
                        orderby pair.Key.Value() ascending
                        select pair;

            foreach (var pair in bills)
            {
                Console.WriteLine("{0} - {1}", pair.Key, pair.Value);
            }
        }
    }
}
