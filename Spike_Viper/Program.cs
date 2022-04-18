using System;
using Spike_Viper;

namespace Spike_Viper
{
    class Program
    {
        public const int SizeX = 32;
        public const int SizeY = 32;

        static void Main(string[] args)
        {
            Draw();
        }

        public static void Draw()
        {
            for (int y = SizeY; y > 0; y--)
            {
                //Console.Write("y = {0}", y);
                for (int x = 0; x < SizeX; x++)
                {
                    //Console.Write("x = {0}", x);
                    //Console.Write("\u2588\u2588");
                    Console.BackgroundColor = TileTypes.Grass.BackColor;
                    Console.ForegroundColor = TileTypes.Grass.ForeColor;
                    Console.Write(TileTypes.Grass.RenderString);

                }
                Console.BackgroundColor = ConsoleColor.Black; ;
                Console.Write('\n');
            }
        }
    }
}
