using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Properties_Training
{
    class Box
    {
        //member variable
        private int length = 3;
        private int height;
        //public int width;
        private int volume;

        //Variables can be set and retrieved as such
        public int Width { get; set; }

        //this code does the exact same as above, but we have space for more logic
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value < 0)
                {
                    height = -value;
                }
                else
                {
                    height = value;
                }
            }
        }

        public int Volume
        {
            get
            {
                return this.length * this.length * this.height;
            }
        }

        public Box(int length, int height, int width)
        {
            this.length = length;
            this.height = height;
            Width = width;

            //The below is not possible as length is what is provided. this.length is the onject-specific variable.
            //length = this.length;
        }

        public void SetLength(int length)
        {
            if(length < 0)
            {
                throw new Exception("Length should be greater than 0.");
            }
            this.length = length;
        }

        public int GetLength()
        {
            return this.length;
        }

        public int FrontSurface
        {
            get { return height * length; }
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0}, height is {1}, and witdh is {2}.\nThe volume is {3}.", length, height, Width, volume=length*height*Width);
        }

    }
}
