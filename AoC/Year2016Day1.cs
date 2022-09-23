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
        
        

        

        private class Walker
        {
            (int X, int Y) _position;
            Direction _direction;

            public Walker(Direction dir, (int X, int Y) pos)
            {
                _position = pos;
                _direction = dir;
            }

            public Direction Direction { get { return _direction; } }
            public (int X, int Y) Position { get { return _position; } }

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
                var (X, Y) = dirVectors[_direction];
                _position = (X: _position.X + X, Y: _position.Y + Y);
            }

            public void Move(int steps)
            {
                if (steps > 0)
                {
                    Move();
                    Move(steps - 1);
                }
            }
        }

        override public int SolvePart1()
        {
            var w = new Walker(pos: (X: 0, Y: 0), dir: Direction.North);
            w.Turn("Left");
            Debug.WriteLine(w.Direction);
            w.Move(4);
            Debug.WriteLine(w.Position);
            return 0;
        }

        override public int SolvePart2()
        {
            return 0;
        }
    }
}