namespace Colors
{
    public class Orange : Black
    {
        public Orange(int id) : base(id)
        {
            Console.WriteLine($"{Id,3}>Constructing a Black({id})");
        }
        ~Orange()
        {
            Console.WriteLine($"{Id,3}>Destorying an Orange()");
        }
        public  void Process()
        {
            Console.WriteLine($"{Id,3}>Processing as an Orange");
        }
        public override void vProcess()
        {
            Console.WriteLine($"{Id,3}vProcessing as an Orange");
        }
    }
}