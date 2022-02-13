using Part1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    class EmployeeRecord
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string StateCode { get; set; }
        public decimal HoursWorkedInTheYear { get; set; }
        public decimal HourlyRate { get; set; }
        public decimal YearlyPay { get; }
        public decimal TaxDue { get; }
        public EmployeeRecord(string csv)
        {
            string[] items = csv.Split(',');
            StreamReader reader = null;
            try
            {
                reader = File.OpenText("employees.csv");
                string line = reader.ReadLine();
                if (items.Length != 5)
                {
                    throw new Exception($"Invalid number of items in csv string... Should be 5..");
                }
                int id;
                if (int.TryParse(items[0], out id))
                {
                    Id = id;
                }
                else
                {
                    throw new Exception("Invalid Id, not an integer");
                }
                Name = items[1];
                StateCode = items[2];
                decimal hours;
                if (decimal.TryParse(items[3], out hours))
                {
                    HoursWorkedInTheYear = hours;
                }
                else
                {
                    throw new Exception("HoursWorkedInAYear is invalid,it is not a decimal value..");
                }
                decimal rate;
                if (decimal.TryParse(items[4], out rate))
                {
                    HourlyRate = rate;
                }
                else
                {
                    throw new Exception("Invalid HourlyRate, it is not a decimal value..");
                }
                decimal yearlyPay = HoursWorkedInTheYear * HourlyRate;
                YearlyPay = yearlyPay;

                

                decimal taxDue = TaxCalculator.ComputeTaxFor(StateCode, YearlyPay);
                TaxDue = taxDue;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error!!!" + ex.Message);
                Console.WriteLine("Attempting to resume...");
            }
        }
        public override string ToString()
        {
            return $"Tax Info for employee: {Name}.  Yearly Pay: {YearlyPay} Total Tax Owed:{TaxDue}";
        }
    }
    static class EmployeesList
    {
        // create an EmployeeList
        
        static List<EmployeeRecord> employees;
        public static List<EmployeeRecord> Employees { get { return employees; } }
        
        static EmployeesList()
        {
            
            StreamReader reader = null;
            try
            {
                employees = new List<EmployeeRecord>();
                reader = File.OpenText("employees.csv");
                string line;
                do
                {
                    line = reader.ReadLine();
                    try
                    {
                        EmployeeRecord employee = new EmployeeRecord(line);
                        employees.Add(employee);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("Resume");
                    }
                }
                while (!reader.EndOfStream);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!! " + ex.Message);
                Console.WriteLine("Attempting to resume..");
            }

        }
        public static void PrintEmployeeList()
        {
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine(employees[i].ToString());
            }
           
            
        }
    }
   
    }