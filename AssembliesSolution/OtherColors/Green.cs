using Colors;
using System;


namespace otherColors
{
    
        public class Green : Orange
        {
            public Green(int id): base(id)
            {
                Console.WriteLine($"{Id,3}>Constructing a Black({id})");
            }
            ~Green()
            {
                Console.WriteLine($"{Id,3}>Destorying a Green()");
            }
            public new void Process()
            {
                Console.WriteLine($"{Id,3}>Processing as a Green");
            }
            public override void vProcess()
            {
                Console.WriteLine($"{Id,3}vProcessing as a a Green");
            }
        }
    
}
