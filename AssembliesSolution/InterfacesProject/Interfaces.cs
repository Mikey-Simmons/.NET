namespace InterfacesProject
{
    public interface IBlack
    {
        int Id { get; set; }
        void Process();
        void vProcess();
    }
    public interface IFactory
    {
        public static string Prompt { get; set; } = "(B)lack"; // only supported in c# 8.0 or greater. new feature in interfaces
        // this is the standard prompt that version 1 of our program will show
        IBlack Create(char c);
        List<IBlack> Create(string pattern);
    }
}