using System;
using myNamespace;
using otherNamespace;
public class Program
{
   
    public static void Main()
    {
          myNamespace.AnotherProgram.printText() ;
        otherNamespace.AnotherProgramAgain.printSomeText() ;
    }

}
namespace myNamespace
{
    public class AnotherProgram
    {
        public static void printText() {
            Console.WriteLine("Hello Earth!");
        }

    }
}
 namespace otherNamespace
{
    public class AnotherProgramAgain
    {
        public static void printSomeText()
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("I am text from the otherNamespace.");

        }
    }
}