using InterfacesProject;

namespace Colors
{
    public class Black : InterfacesProject.IBlack
    {
        public Black(int id)
        {
            Id = id;
            Console.WriteLine($"{Id,3}>Constructing a Black({id})");
        }
        ~Black()
        {
            Console.WriteLine($"{Id,3}>Destroying(finalizing) a ~Black()");
        }
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Process()
        {
            Console.WriteLine($"{Id,3}>Process as a Black");
        }

        public virtual void  vProcess()
        {
            Console.WriteLine($"{Id,3}>vProcess as a Black");
        }
       
    }
}