using FactoryProject;
using InterfacesProject;
using System;
namespace ProgramProject
{
     class Program
    {
        static void Main()
        {
            Work();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Console.WriteLine("Press return to Exit Main...");
            Console.ReadLine();
            Console.WriteLine("Exitting Main");
        }
        static void Work()
        {
            Factory f = new Factory();
            Console.WriteLine($"Enter a pattern>{IFactory.Prompt}:");
            string pattern = Console.ReadLine();

            List<IBlack> data = f.Create(pattern);
            foreach(IBlack item in data)
            {
                item.Process();
                item.vProcess();
            }
        }
    }
} 