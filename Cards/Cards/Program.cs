using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Page23
{
    class Program
    {
        public static void Main()
        {
            var mycard = new Card(2,2,false);
            
            mycard.Flip();
            Console.WriteLine(mycard);
        }
    }
 public   class Card
    {
        private int faceValue;
        private int suit;
        private bool facing;

        // constructors (2) :  
        public Card(int number)
        {
            if(number < 13)
            {
                suit = 0;
            }
            if(number >13 && number < 26)
            {
                suit = 1;
            }
            if(number >26 && number < 39)
            {
                suit=2;
            }
            if(number > 39)
            {
                suit = 3;
            }
            faceValue = number%13;
            facing = true;
        }
        public Card(int faceValue,
                    int suit,
                    bool facing)
        {
            this.faceValue = faceValue;
            this.suit = suit;
            this.facing = facing;

        }
        // public properties
        int Value
        {
            get
            {
                
                return faceValue;
            }
            set { faceValue = value; }
        }
        int Suit
        {
            get
            {
                
                return suit;
            }
            set { suit = value; }
        }
        bool Facing
        {
            get
            {
                
                return facing;
            }
            set { facing = value; }
        }
        // methods 
        public void Flip()
        {
            if (facing == false)
            {
                facing =true;
            }
            else if (facing == true)
            {
                facing = false;
            }
        }
        public void Reveal()
        {
            if(facing == false)
            {
                facing = true;
            }
        }
        public void Hide()
        {
            facing = false;
        }
        public override string ToString()
        {
            // this method is actually implemented correctly


            // condition?true-stuff:false-stuff;

            // facing is the condition: 
            //   it is either true (show)
            //   or false (hide)
            // "A23456789TJQK"[Value] is the 
            //   character to return 
            //   if facing is true
            // '?' is the character to 
            //   return if facing is false

            // similar thing for suit

            char v = Facing
                     ? "A23456789TJQK"[Value]
                     : '?';
            char s = Facing
                     ? "CDHS"[Suit]
                     : '?';

            return $"{v}{s}";
        }
        
    }



    
}
