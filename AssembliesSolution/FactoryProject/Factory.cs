using Colors;
using InterfacesProject;

namespace FactoryProject
{
    public class Factory : IFactory
    {
        public Factory()
        {
            IFactory.Prompt = "(B)lack";
        }
        static int i = 1;
        public IBlack Create(char c)
        {
            switch (char.ToUpper(c))
            {
                case ('B'): return new Black(i++);
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