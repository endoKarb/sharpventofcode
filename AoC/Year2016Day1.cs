using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using static AoC.Utils;
using System.Diagnostics;

namespace AoC
{
    
    internal class Year2016Day1 : Solver
    {
        readonly string _text;
        public Year2016Day1(string filepath)
        {
            _filepath = filepath;
            _text = File.ReadAllText(filepath);
        }

        private static readonly Dictionary<Direction, (int X, int Y)> dirVectors = new()
        {
            [Direction.North] = (0, +1),
            [Direction.South] = (0, -1),
            [Direction.East] = (+1, 0),
            [Direction.West] = (-1, 0)
        };
        override public int SolvePart1()
        {
            var pos = (X: 0, Y: 0);
            var dir = Direction.North;
            dir = Turn(dir, "L");
            Debug.WriteLine($"{dir}");
            pos = Move(pos, dir);
            Debug.WriteLine($"{pos}");
            return 0;
        }
        static private (int X, int Y) Move((int X, int Y) p, Direction d)
        {
            var (X, Y) = dirVectors[d];
            return (X: p.X + X, Y: p.Y + Y);
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