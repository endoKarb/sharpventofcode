using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC
{
    internal static class Utils
    {
        public struct Coords
        {
            public Coords(int x, int y)
            {
                X = x;
                Y = y;
            }

            public int X { get; }
            public int Y { get; }

            public override string ToString()
            {
                return $"x: {X}, y: {Y}";
            }
            public static Coords operator -(Coords c1, Coords c2)
            {
                return new Coords(c1.X - c2.X, c1.Y - c2.Y);
            }
            public static Coords operator +(Coords c1, Coords c2)
            {
                return new Coords(c1.X + c2.X, c1.Y + c2.Y);
            }
            public static Coords Abs(Coords c1)
            {
                return new Coords(x: Math.Abs(c1.X), y: Math.Abs(c1.Y));
            }
            public static int ManhDist (Coords c1, Coords c2)
            {
                Coords dist = Abs(c1 - c2);
                //Debug.WriteLine($"{c1}, {c2}, {dist}");
                return dist.X + dist.Y;
            }
        }
        public enum Direction
        {
            North,
            East,
            South,
            West
        }
        public static Direction Right (this Direction d)
        {
            return d == Direction.West ? Direction.North : d++;
        }
        public static Direction Left(this Direction d)
        {
            return d == Direction.North ? Direction.West : d--;
        }
        public static int Mod(int a, int b)
        {
            b = b >= 0 ? b : -b;
            a = a >= 0 ? a : b + a;
            return a % b;
        }
    }
}
