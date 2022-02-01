using System;

namespace LambdaTesting
{
    class Program
    {
        static void Main(string[] args )
        {
           Action<int, string, bool> c;
           Action a;
            c = testc;
            a = test;
            a();
            
            testb(2);
            c(2, "yo", true);
            
        }
        static void test()
        {
            Console.WriteLine("This is  a test");
        }
        static Action Test2()
        {
            return test;
        }
        static void testb(int a)
        {
            Console.WriteLine(a);   
        }
        static Action<int> test2b()
        {
            return testb;
        }
        static void testc(int a, string s, bool b)
        {
            Console.WriteLine("In testc");
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