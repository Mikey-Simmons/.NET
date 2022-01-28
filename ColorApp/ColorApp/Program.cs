using System;
public class Program
{
    public static void Main()
    {

    }
}
namespace Exercise
{
    class Color
    {
        public int Red;
        public int Green;
        public int Blue;
        public int Opacity;
        // default ctor
        public Color()
        {
            Red = 0;
            Green = 0;
            Blue = 0;
            Opacity = 255;
        }
        // ctor accepting 1 integer
        public Color(int Red)
        {
            Red = Red;
            Green = Red;
            Blue = Red;
            Opacity = 255;
        }
        // ctor accepting 3 integers
        public Color(int Red, int Green, int Blue)
        {
            Red = Red;
            Green = Green;
            Blue = Blue;
            Opacity = 255;
        }
        // ctor accepting 4 integers
        public Color(int Red, int Green, int Blue, int Opacity)
        {
            Red = Red;
            Green = Green;
            Blue = Blue;
            Opacity = Opacity;
        }
    }
}