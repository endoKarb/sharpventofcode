using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AoC
{
    public enum Direction
    {
        North = 0,
        East = 1,
        South = 2,
        West = 3,
    }
    internal class Year2016Day1 : Solver
    {
        readonly string _text;
        public Year2016Day1(string filepath)
        {
            _filepath = filepath;
            _text = File.ReadAllText(filepath);
        }
        override public int SolvePart1()
        {
            Dictionary<Direction, (int X, int Y)> d = new()
            {
                [Direction.North] = (0, +1),
                [Direction.South] = (0, -1),
                [Direction.East] = (+1, 0),
                [Direction.West] = (-1, 0)
            };
            var pos = Direction.North;
            return (int)Turn(pos, "L");
        }

        static private int Mod(int a, int b)
        {
            b = b >= 0 ? b : -b;
            a = a >= 0 ? a : b + a;
            return a % b;
        }

        static private Direction Turn(Direction d, string t)
        {
            int newD = (int) d;
            switch (t[0])
            {
                case 'L':
                    newD--;
                    break;
                case 'R':
                    newD++;
                    break;
                default:
                    break;
            }
            return (Direction)Mod(newD, 4);
        }

        override public int SolvePart2()
        {
            return 0;
        }
    }
}