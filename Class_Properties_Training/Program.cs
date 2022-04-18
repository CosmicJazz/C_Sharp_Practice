using System;

namespace Class_Properties_Training
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box1 = new Box(3,4,5);
            //box1.SetLength(4);
            //box1.Height = -4;
            //box1.Width = 10;
            //box1.length = 3;
            //box1.height = 4;
            //box1.width = 5;

            Console.WriteLine("The box's Width is " + box1.Width);
            box1.Width = 10;
            Console.WriteLine("The box's Width is " + box1.Width);
            Console.WriteLine("The box's volume is " + box1.Volume);
            Console.WriteLine("The front surface of the box is {0}", box1.FrontSurface);
            box1.DisplayInfo();

        }
    }
}
