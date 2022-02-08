using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    static class TaxCalculator
    {
        // Create a static dictionary field that holds a List of TaxRecords and is keyed by a string
        static Dictionary<string, List<TaxRecord>> states;

        


        // create a static constructor 
        static TaxCalculator()
        {
            StreamReader reader = null;
            try
            {
                states = new Dictionary<string, List<TaxRecord>>();
                reader = File.OpenText("taxtable.csv");
                string line;
                do
                {
                    line = reader.ReadLine();
                    try
                    {
                        TaxRecord tr = new TaxRecord(line);
                        List<TaxRecord> records;
                        bool found = states.TryGetValue(tr.StateCode, out records);
                        if (found)
                        {
                            records.Add(tr);
                        }
                        else
                        {
                            records = new List<TaxRecord>();
                            records.Add(tr);
                            states.Add(tr.StateCode, records);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                        Console.WriteLine("Resuming...");
                    }
                    
                }
                while(!reader.EndOfStream);
            }
            catch (Exception ex)
            { Console.WriteLine(ex); 
              Console.WriteLine("Attempting to resume...");
            }  

            
        }
        public static decimal ComputeTaxFor(string state, decimal totalEarned)
        {
            List<TaxRecord> records;
            bool found = states.TryGetValue(state, out records);
            if(found)
            {
                Console.WriteLine($"Found {records.Count} records for state: {state}");
                decimal totalTax = 0M;
                foreach(TaxRecord tr in records)
                {
                    if(totalEarned >= tr.Floor && totalEarned <= tr.Ceiling)
                    {
                        decimal incomeForThisBracket = totalEarned - tr.Floor;
                        decimal thisBracket = incomeForThisBracket * tr.Rate;
                        Console.WriteLine($"Found Record {tr} [income: {incomeForThisBracket} Tax: {thisBracket}] Total Tax: {totalTax +thisBracket}");
                        return totalTax + (totalEarned - tr.Floor)* tr.Rate;

                    }
                    else

                    {
                        decimal incomeForThisBracket = tr.Ceiling-tr.Floor;
                        decimal thisBracket = incomeForThisBracket * tr.Rate;
                        Console.WriteLine($"Found record {tr} this Bracket: [income: {incomeForThisBracket} Tax: {thisBracket}] Total Tax So Far: {totalTax+thisBracket }");
                        totalTax = +thisBracket;
                    }
                }
                throw new Exception($"Income was higher than the tax ceiling: {totalEarned}");
            }
            else
            {
                throw new Exception("There was an error...");
            }
        }
        

    }  // this is the end of the Tax Calculator


    class TaxRecord
    {
        public string StateCode
        {
            get;init;
        }

        public string State
        {
            get;init;
        }
        public decimal Floor
        {
            get; init;
        }
        public decimal Ceiling
        {
            get; init;
        }
        public decimal Rate
        {
            get; init;
        }
        public decimal YearlyPay
        {
            get; init;
        }

        public TaxRecord(string csv)
        {
            string[] items = csv.Split(',');
            if(items.Length != 5)
            {
                throw new Exception($"csv doesn't have 5 fields seperated by commas... ");
            }
            // assigning state code variable
            StateCode = items[0];
            // asssigning state variable
            State = items[1];
            decimal a;
            if(decimal.TryParse(items[2], out a))
            {
                Floor = a;
            }
            else
            {
                throw new Exception($"item Flooris not a decimal [{items[2]} line=[{csv}]");
            }
            //declaring ceiling var
            decimal b;
            if(decimal.TryParse(items[3], out b))
            {
                Ceiling = b;
            }
            else
            {
                throw new Exception($"item ceiling is not a decimal [{items[3]} line=[{csv}]");
            }
            //rate var
            decimal c;
            if(decimal.TryParse(items[4],out c))
            {
                Rate = c;
            }
            else
            {
                throw new Exception($"item rate is not a decimal [{items[4]} line=[{csv}]");
            }
        }
        public override string ToString()
        {
            return  $"Tax Record for {StateCode} {State} Floor: {Floor,15:000000000.00} Ceiling:{Ceiling,15:00000000.00} Rate:{Rate:00.00000}";
        }
    }  // this is the end of the TaxRecord

    class Program
    {
        public static void Main()
        {
            


            do
            {
                try
                {
                    Console.WriteLine("Enter a State Abbreviation:");
                    string state = Console.ReadLine().ToUpper();
                    Console.WriteLine("Enter an Income Amount:");
                    string line;
                    decimal income;
                    // validating data
                    while(!decimal.TryParse(line = Console.ReadLine(),out income))
                    {
                        Console.WriteLine($"The Income amount provided '{line}' was not a valid decimal value...");
                        Console.WriteLine("Please enter the Income Amount in decimal form!");
                    }
                    decimal tax = TaxCalculator.ComputeTaxFor(state, income);
                    Console.WriteLine($"The total tax is: ${tax} ");

                }
                catch (Exception ex)

                {
                    Console.WriteLine(ex.Message);
                }
            } while (true);


        }
    }

}