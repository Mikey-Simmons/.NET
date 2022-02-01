using System;

namespace LambdaTesting
{
    class Program
    {
        static void Main(string[] args )
        {
           Action a;
            a = test;
            a();
            
            
        }
        static void test()
        {
            Console.WriteLine("This is  a test");
        }
        static Action Test2()
        {
            return test;
        }
    }
    
}

// Lambda Expressions and predefined Delegates

//Func= a variable that can be attached to a method that returns something
//is computing something



//Action = a variable that can be attached to a method that returns *void*
//is doing something


//Predicate= a variable that can be attached to a method returning a bool (True or False)
//is answering a y/n or t/f question