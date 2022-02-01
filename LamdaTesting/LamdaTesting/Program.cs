using System;

namespace LambdaTesting
{
    class Program
    {
        static void Main(string[] args )
        {
            Predicate<string> p;
            p = isString3letters;
           Action<int, string, bool> c;
           Action a;
            c = testc;
            a = test;
            a();
            Func<int> f;
            Func<string, int> f2;
            testb(2);
            c(2, "yo", true);
            f = function1;
            Console.WriteLine(f());
            f2 = function2a;
            f2("yo");
            Console.WriteLine(p("pee"));
            Console.WriteLine(p("pushin p"));
        }
        static void test()
        {
            Console.WriteLine("This is  a test");
        }
        static bool isString3letters(string s)
        {
            if (s.Length == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
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
        static int function1() {
            return 666; }
        static int function2a(string s)
        {
            return 0;
        }
        static string function2b(int i)
        {
            return "zero";
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