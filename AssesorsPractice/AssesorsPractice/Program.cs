using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page24
{
    public class Prorgram
    {
        public static void Main()
        {

        }
        }
    }
    public class Person
    {
        private string firstName;
        public string FirstName {
        get { return firstName; }
        set { firstName = value; }
    }   
        
            


        private string lastName;
    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    
    }
    public string FullName
    {
        get
        {
            return firstName + " " + lastName;
        }
    }
   
        








        public Person()
        {
            this.firstName = "";
            this.lastName = "";
        }
        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }

