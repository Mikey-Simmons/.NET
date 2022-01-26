using System;

namespace ProcessInvoices
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date;
            if (args.Length == 0)
            {
                date = DateTime.Now;
            }
            else if (args.Length != 1)
            {
                Console.WriteLine("Usage: this progam expects to be given a single date (mm/dd/yyyy)"); return;
            }
            else if(DateTime.TryParse(args[0], out date)) 
            {
                Console
                    .WriteLine("The date given is invalid. Make sure it is in this form (mm/dd/yyyy)");return;
            }

            Console.WriteLine($"Date for Late fee computation: {date.ToShortDateString()}");
            var reader = System.IO.File.OpenText("invoices.dat");
            while (true)
            {
                string myLine = reader.ReadLine();
                if (myLine == null)
                {
                    break;
                }
                string[] lines = myLine.Split(',');
                if(lines.Length != 3)
                {
                    Console.WriteLine($"the line {myLine} is not valid. make sure it has 3 parts seperated by 2 commas."); continue;
                }
                int invoiceNumber;
                DateTime invoiceDate;
                decimal invoiceTotal;
                if (!int.TryParse(lines[0], out invoiceNumber))
                {
                
                    Console.WriteLine($"the line {myLine} is not valid. the first part must be an integer to represent the invoice number");continue;
                }
                if (!DateTime.TryParse(lines[1], out invoiceDate))
                {
                    Console.WriteLine($"the line {myLine} is not valid. the second part must be a invoice due date in standard format (mm/dd/yyyy)"); continue;
                }
                if (!decimal.TryParse(lines[2], out invoiceTotal))
                {
                    Console.WriteLine($"the line {myLine} is not valid. the third part must be an invoice amount(in decimals) "); continue;
                }
                else
                {
                    Console.WriteLine($"Invoice Number: {invoiceNumber},Due: {invoiceDate.ToShortDateString()} Fee:{ComputeLateFees(date, invoiceDate, invoiceTotal):0.00} ");
                }
                


            }
            reader.Close();
        }
        
        static decimal ComputeLateFees(DateTime date, DateTime dueDate, Decimal total)
        {
          int numOfDaysLate = (date - dueDate).Days;
            if(numOfDaysLate< 1)
            {
                return 0;
            }
            if(numOfDaysLate<= 7)
            {
                return total * .1M;
            }
            numOfDaysLate -= 7;
            return (total * 1M) + numOfDaysLate * 0.1M;


        }
    }
}