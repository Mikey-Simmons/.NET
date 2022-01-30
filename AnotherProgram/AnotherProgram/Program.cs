using System;
using myNamespace;
using otherNamespace;
public class Program
{
   
    public static void Main()
    {
        string s1 = printText();
    }

}
namespace myNamespace
{
    public class AnotherProgram
    {
        public string printText() {
            return "Hello Earth";
        }

    }
}
namespace otherNamespace
{
    public class AnotherProgramAgain
    {
        public string printSomeText()
        {
            return "Hello there!";
        }
    }
}