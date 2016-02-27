using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading;

namespace BankAccountBalance
{
    class Program
    {
        /* 
        Pesho has extracted his bank account statement in a file and he wants to know how much money he has received, has spent and what is his balance (received - spent). He wants to be able to check that for any given date range.
        The format of Pesho's file is as below:

        25.03.2015г.;теглене;25.12лв
        28.03.2015г.;теглене;215.22лв
        29.03.2015г.;теглене;115.62лв
        30.03.2015г.;теглене;13.37лв
        31.03.2015г.;внасяне;1000.00лв
        01.04.2015г.;теглене;400.00лв
        i.e.

        <date>;<operation[теглене|внасяне]>;<amount[X.XXлв]>

        Hint: Use File.ReadAllText to read the contents of the file.
        */
        static void Main(string[] args)
        {
            CultureInfo customCulture = (CultureInfo)Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";

            Thread.CurrentThread.CurrentCulture = customCulture;

            string[] fileHistory = File.ReadAllText("ivan.txt", Encoding.Default).Split(new char[] { ';', ' ' });

            var fromDate = new DateTime(2015, 3, 29);
            var toDate = new DateTime(2015, 4, 1);

            CultureInfo bgCulture = new CultureInfo("bg-BG");

            decimal monthTax = 0;
            decimal inCome = 0;
            decimal outCome = 0;
            for (int i = 0; i < fileHistory.Length; i += 3)
            {
                var currentDate = DateTime.Parse(fileHistory[i], bgCulture);
                if (currentDate >= fromDate && currentDate <= toDate)
                {
                    if (fileHistory[i + 1] == "теглене")
                    {
                        outCome += decimal.Parse(fileHistory[i + 2].Replace("лв", ""));
                    }
                    else if (fileHistory[i + 1] == "внасяне")
                    {
                        inCome += decimal.Parse(fileHistory[i + 2].Replace("лв", ""));
                    }
                    else
                    {
                        monthTax += decimal.Parse(fileHistory[i + 2].Replace("лв", ""));
                        Console.WriteLine("Included monthly fee: {0}lv",monthTax);
                    }
                }
            }
            decimal balance = inCome - outCome - monthTax;
            Console.WriteLine("Balance for period {0} - {1}: {2:C2}", fromDate.ToShortDateString(), toDate.ToShortDateString(), balance);

        }
    }
}
