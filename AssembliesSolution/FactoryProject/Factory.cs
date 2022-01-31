using Colors;
using InterfacesProject;
using otherColors;


namespace FactoryProject
{
    public class Factory : IFactory
    {
        public Factory()
        {
            IFactory.Prompt = "(B)lack (O)range (G)reen (P)urple";
        }
        static int i = 1;
        public IBlack Create(char c)
        {
            switch (char.ToUpper(c))
            {
                case ('B'): return new Black(i++);
                case ('O'): return new Orange(i++);
                case ('G'): return new Green(i++);
                case ('P'): return new Purple(i++);
                default: throw new Exception($"did not recognize pattern character {c}");
            }

        }

        public List<IBlack> Create(string pattern)
        {
            List<IBlack> result = new List<IBlack>(pattern.Length);
            foreach (char c in pattern)
            {
                result.Add(Create(c));
            }
            return result;
        }
    }
}