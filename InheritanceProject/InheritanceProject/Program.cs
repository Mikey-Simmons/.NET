using System;


namespace InheritanceProject
{
    public class Program
    {

        public static void Main()
        {
            //tests 
            var my_emp = new Employee("Mikey", "50000", "04/12/2017");
            Console.WriteLine(my_emp.getName());
            Console.WriteLine(my_emp.getSalary());
            Console.WriteLine(my_emp.hiredDate());

            var my_emp2 = new Engineer("Joe Goldberg", "50000000", "04/12/2016","ITT Tech");
            Console.WriteLine(my_emp2.getName());
            Console.WriteLine(my_emp2.getSalary());
            Console.WriteLine(my_emp2.hiredDate());
            var my_emp3 = new SoftwareEngineer("Bob Joe", "1000000000000", "01/22/2012", "Harvard");
            Console.WriteLine(my_emp3.getName());
            Console.WriteLine(my_emp3.getSalary());
            Console.WriteLine(my_emp3.hiredDate());
        }
    }
    public class Employee
    {
        public string name { get; set; }
        public string salary { get; set; }
        public string hireDate { get; set; }
        public Employee(string Name, string Salary, string HireDate)
        {
            this.name = Name;
            this.salary = Salary;  
            this.hireDate = HireDate;

    }   
        virtual public string getName()
        {
            return $"Employee Name: {name}";
        }
        virtual public string getSalary()
        {
            return $"Salary: {salary}";
        }
        virtual public string hiredDate()
        {
            return $"Hire Date: {hireDate}";
        }
            

    }
        class Engineer : Employee
    {
        public string schoolAttended;
        public Engineer(string name, string salary, string HireDate, string schoolAttended)
            : base(name, salary, HireDate)
        {
            this.schoolAttended = schoolAttended;
        }


    }
    class SoftwareEngineer : Engineer
    {
        public override  string getSalary()
        {
            return "Sorry, this employee's salary is private.";
        }
        public SoftwareEngineer(string name, string salary, string hireDate, string SchoolAttended):base(name,salary,hireDate,SchoolAttended) {

        }
    }

}

