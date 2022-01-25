using System;
namespace Hypotenuse

{
    
    public class StudentProgram
    {
        public static double StudentMain()
        {
            double x = Hypotenuse(10.0, 20.0);
            Console.WriteLine(x);
            return x;
        }
        public static double Hypotenuse(double a, double b)
        {
            double y = Math.Sqrt(a * a + b * b);
            return y;
        }
    }
}