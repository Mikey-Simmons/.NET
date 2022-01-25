using System;

namespace Counting
{
    class Program
    {
        static void Main(string [] args)
        {
            if(args.Length != 1)
            {
                Console.WriteLine("Usage: This program is expecting a single integer.");
                return;
            }
            int arg;
            if(int.TryParse(args[0], out arg))
            {
                Console.WriteLine(MakeAllLines(arg));
            }
            else
            {
                Console.WriteLine($"Usage: the supplied parameter {args[0]} was not a valid integer!");
            }
        }
        static string MakeALine(int num)
        {
            string s = $"{num}";
            System.Text.StringBuilder sb = new System.Text.StringBuilder(50);
            for(int i = 0; i < num; i++)
            {
                sb.Append(s);
            }
            return sb.ToString();
        }
        static string MakeAllLines(int count)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(500);
            for(int i = 0;i <= count; i++)
            {
                sb.Append(MakeALine(i));
                sb.Append('\n');
            }
            return sb.ToString();
        }
    }
}