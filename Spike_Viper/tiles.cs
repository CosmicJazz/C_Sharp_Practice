using System;
using System.Collections.Generic;
using System.Text;
using Spike_Viper;

namespace Spike_Viper
{
    public class Tile
    {

    }

    public static class TileTypes
    {

        public static readonly TileType Air;
        public static readonly TileType Grass;
        public static readonly TileType Wood;

        static TileTypes()
        {
            Air = new TileType("Air", ConsoleColor.Cyan, ConsoleColor.Black, "  ");
            Grass = new TileType("Grass", ConsoleColor.Green, ConsoleColor.DarkGreen, "##");
            Wood = new TileType("Wood", ConsoleColor.DarkRed, ConsoleColor.Black, "||");
        }
    }

    public class TileType
    {
        public string Name { get; set; }
        public ConsoleColor BackColor { get; set; }
        public ConsoleColor ForeColor { get; set; }
        public string RenderString { get; set; }

        public TileType(string name, ConsoleColor backColor, ConsoleColor foreColor, string rednderString)
        {
            this.Name = name;
            this.BackColor = backColor;
            this.ForeColor = foreColor;
            this.RenderString = rednderString;
        }
    }
}