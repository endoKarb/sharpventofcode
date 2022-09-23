using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using static AoC.Utils;
using System.Diagnostics;
using System.Text.RegularExpressions;

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

        private static readonly Dictionary<Direction, Coords> dirVectors = new()
        {
            [Direction.North] = new Coords(x: 0, y: +1),
            [Direction.South] = new Coords(x: 0, y: -1),
            [Direction.East] = new Coords(x: +1, y: 0),
            [Direction.West] = new Coords(x: -1, y: 0),
        };
        private class Walker
        {
            Coords _position;
            Direction _direction;

            public Walker(Direction dir, int x, int y)
            {
                _position = new Coords(x, y);
                _direction = dir;
            }

            public Direction Direction { get { return _direction; } }
            public Coords Position { get { return _position; } }

            public void Turn(string verse)
            {
                char v = verse.ToLower()[0];
                switch (v)
                {
                    case 'l':
                        _direction = _direction.Left();
                        break;
                    case 'r':
                        _direction = _direction.Right();
                        break;
                    default:
                        break;
                }
            }

            public void Move()
            {
                Coords v = dirVectors[_direction];
                _position += v;
            }

            public void Move(int steps)
            {
                if (steps > 0)
                {
                    Move();
                    Move(steps - 1);
                }
            }

            public void Move(string mv)
            {
                int steps = int.Parse(Regex.Match(mv, @"\d+").Value);
                Turn(mv);
                Move(steps);
            }
        }

        private string[] ParseInput()
        {
            return _text.Split(", ");
        }

        override public int SolvePart1()
        {
            string[] directions = ParseInput();
            var startPos = new Coords(0, 0);
            var w = new Walker(x: 0, y: 0, dir: Direction.North);
            foreach (string mv in directions)
            {
                w.Move(mv);
            }
            return Coords.ManhDist(w.Position, startPos);
        }

        override public int SolvePart2()
        {
            return 0;
        }
    }
}