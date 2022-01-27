using System;
namespace InheritanceTesting{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello world");
            black b;
        
        }
    }
class black
{
    public black()
    {
       
    }
        public int _data1;
        public int BlackProperty1
        {
            get { return _data1; } set { _data1 = value; } 
        }
        public int BlackProperty2
        {
            get { return _data2; }
            set { _data2 = value; }
        }
        protected int DoWork1()
        {
            return _data1 * 10;
        }
        protected int _data2;
}
    //child  parent
class blue : black
    {
        public blue()
        { }
            protected int _bluedata1;

        public int BlueProperty1
        {
            get { return _bluedata1; }
            set
            {
                _bluedata1 = value;
            }
        }
        public int BlueProperty2
        {
            get; set;
        }
        }
    }
