using System;

namespace OOPTesting
{
    class Program
    {
        static void Main()
        {

  

        class Color
        {

            int _red;
            public int Red
            {
                get
                {
                    return _red;
                }
                set
                {
                    if (value < 0 || value > 255)
                    {
                        throw new Exception("Value must be between 0-255");
                    }
                }
            }
            int _green;
            public int Green
            {
                get
                {
                    return _green;
                }
                set
                {
                    if (value < 0 || value > 255)
                    {
                        throw new Exception("Value must be between 0-255");
                    }
                }
            }

            int _blue;
            public int Blue
            {
                get
                {
                    return _blue;
                }
                set
                {
                    if (value < 0 || value > 255)
                    {
                        throw new Exception("Value must be between 0-255");
                    }
                }
            }
            int _opacity;
            public int Opacity
            {
                get
                {
                    return _opacity;
                }
                set
                {
                    if (value < 0)
                    {
                        _opacity = 0;

                    }
                    if (value > 255)
                    {
                        _opacity = 255;

                    }
                }
            }






            // default ctor 
            public Color()
            {
                Red = 0;
                Green = 0;
                Blue = 0;
                Opacity = 255;
            }

            // ctor accepting 1 integer

            public Color(int Red)
            {
                this.Red = Red;
                Green = Red;
                Blue = Red;
                Opacity = 255;
            }

            // ctor accepting 3 integers
            public Color(int Red, int Green, int Blue)
            {
                this.Red = Red;
                this.Green = Green;
                this.Blue = Blue;
                Opacity = 255;
            }

            // ctor accepting 4 integers
            public Color(int Red, int Green, int Blue, int Opacity)
            {
                this.Red = Red;
                this.Green = Green;
                this.Blue = Blue;
                this.Opacity = Opacity;
            }

        }

    }


        class Color
        {

            int _red;
            public int Red
            {
                get
                {
                    return _red;
                }
                set
                {
                    if (value < 0 || value > 255)
                    {
                        throw new Exception("Value must be between 0-255");
                    }
                }
            }
            int _green;
            public int Green
            {
                get
                {
                    return _green;
                }
                set
                {
                    if (value < 0 || value > 255)
                    {
                        throw new Exception("Value must be between 0-255");
                    }
                }
            }

            int _blue;
            public int Blue
            {
                get
                {
                    return _blue;
                }
                set
                {
                    if (value < 0 || value > 255)
                    {
                        throw new Exception("Value must be between 0-255");
                    }
                }
            }
            int _opacity;
            public int Opacity
            {
                get
                {
                    return _opacity;
                }
                set
                {
                    if (value < 0)
                    {
                        _opacity = 0;

                    }
                    if (value > 255)
                    {
                        _opacity = 255;

                    }
                }
            }






            // default ctor 
            public Color()
            {
                Red = 0;
                Green = 0;
                Blue = 0;
                Opacity = 255;
            }

            // ctor accepting 1 integer

            public Color(int Red)
            {
                this.Red = Red;
                Green = Red;
                Blue = Red;
                Opacity = 255;
            }

            // ctor accepting 3 integers
            public Color(int Red, int Green, int Blue)
            {
                this.Red = Red;
                this.Green = Green;
                this.Blue = Blue;
                Opacity = 255;
            }

            // ctor accepting 4 integers
            public Color(int Red, int Green, int Blue, int Opacity)
            {
                this.Red = Red;
                this.Green = Green;
                this.Blue = Blue;
                this.Opacity = Opacity;
            }

        }

    }
}
    }
}