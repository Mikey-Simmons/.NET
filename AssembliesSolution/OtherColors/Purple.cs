using Colors;
using System;


namespace otherColors
{
    
        public class Purple : Black
        {
            public Purple(int id) : base(id)
            {
                Console.WriteLine($"{Id,3}>Constructing a Purple({id})");
            }
            ~Purple()
            {
                Console.WriteLine($"{Id,3}>Destorying a Purple()");
            }
            public void Process()
            {
                Console.WriteLine($"{Id,3}>Processing as a Purple");
            }
            public override void vProcess()
            {
                Console.WriteLine($"{Id,3}vProcessing as a a Purple");
            }
        }
    
}
