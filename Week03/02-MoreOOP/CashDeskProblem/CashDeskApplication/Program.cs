using CashDesk;
using System;
using System.Collections.Generic;
using System.Text;

namespace CashDeskApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            CashDeskMoney cashDesk = new CashDeskMoney();
            Console.WriteLine("Command Menu: takebill, takebatch, total, inspect, exit");
            StringBuilder input = new StringBuilder();

            bool exit = false;
            while (!exit)
            {
                input.Append(Console.ReadLine());

                if (input.ToString().Contains("takebill"))
                {
                    input.Replace("takebill", string.Empty);
                    int amount = -1;

                    if (int.TryParse(input.ToString(), out amount))
                    {
                        if (ValidateBill(amount))
                        {
                            cashDesk.TakeMoney(new Bill(amount));
                            Console.WriteLine("Bill amount is added");
                        }
                        else
                        {
                            Console.WriteLine("Please enter the correct bill : 2,5,10,20,50,100");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount");
                    }
                }
                else if (input.ToString().Contains("takebatch"))
                {
                    input.Replace("takebatch", string.Empty);
                    List<Bill> batchBill = new List<Bill>();
                    int amount = -1;
                    string[] arrBatchBill = input.ToString().Split(' ');
                    foreach (var bill in arrBatchBill)
                    {
                        if (int.TryParse(bill, out amount))
                        {
                            if (ValidateBill(amount))
                            {
                                batchBill.Add(new Bill(amount));
                                Console.WriteLine("Bill amount is added");
                            }
                            else
                            {
                                Console.WriteLine("Invalid input");
                            }
                        }
                    }

                    if (batchBill.Count == 0)
                    {
                        Console.WriteLine("Invalid amount!");
                    }
                    else
                    {
                        cashDesk.TakeMoney(new BatchBill(batchBill));
                    }
                }
                else if (input.ToString().Contains("total"))
                {
                    Console.WriteLine("${0}", cashDesk.Total());
                }
                else if (input.ToString().Contains("inspect"))
                {
                    if (cashDesk.Total() != 0)
                    {
                        cashDesk.Inspect();
                    }
                    else
                    {
                        Console.WriteLine("The Cash Desk is empty.");
                    }
                }

                else if (input.ToString().Contains("exit"))
                {
                    exit = true;
                }
                else
                    Console.WriteLine("Invalid command!");

                input.Clear();
            }

        }
    
        static bool ValidateBill(int amount)
        {
            if (amount == 2 || amount == 5 || amount == 10 || amount == 20 || amount == 50 || amount == 100)
                return true;
            else
                return false;
        }

    }
}
