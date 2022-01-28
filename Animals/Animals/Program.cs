class Program
{
    public static void Main()
    {
        // list of animals used to test
        List<IAnimal> Animals = new List<IAnimal>();
        var mydog = new Dog();
        var mycat = new Cat();
        var mycow = new Cow();
        var mybact = new Bacterium();
        Animals.Add(mydog);
        Animals.Add(mycat);
        Animals.Add(mycow);
        Animals.Add(mybact);

        //foreach loop to run through list of animals
        foreach (IAnimal element in Animals)


        {
            //  check if animal is mammal or not and then run through all methods
            var element1 = element as IMammal;
            if (element1 is IMammal)
            {
                Console.WriteLine(element1.speak());
                Console.WriteLine(element1.run());
                Console.WriteLine(element1.eat());


            }
            else
            {
                Console.WriteLine(element.eat());


            }



        }

    }
    public interface IAnimal
    {
        public string eat();



    }
    public interface IMammal : IAnimal

    {
        string speak();
        string run();
    }

    public class Dog : IMammal
    {

        public string speak()
        {
            return "Bark!";
        }
        public string run()
        {
            return "Dogs can run at a top speed of 45 mph!";
        }
        public string eat()
        {
            return "Dogs eat bones.";
        }
        public Dog()
        {

        }
    }
    public class Cat : IMammal
    {
        public string speak()
        {
            return "Meow!";
        }
        public string run()
        {
            return "Cats can run at a top speed of 30 mph!";
        }
        public string eat()
        {
            return "Cats eat Mice.";
        }
    }
    public class Cow : IMammal
    {
        public string speak()
        {
            return "Moo!";
        }
        public string run()
        {
            return "Cows can run at a top speed of 25 mph!";
        }
        public string eat()
        {
            return "Cows eat grass.";
        }
    }
    public class Bacterium : IAnimal
    {

        public string eat()
        {
            return "Bacteria eat viruses.";
        }
    }
}


