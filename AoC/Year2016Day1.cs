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
    internal static class Year2016Day1utils
    {
        public static Direction ChangeDirection(this Direction d, string mv)
        {
            switch (mv[0])
            {
                case 'L':
                    d = d.Left();
                    break;
                case 'R':
                    d = d.Right();
                    break;
                default:
                    break;
            }
            return d;
        }
    }
    internal class Year2016Day1 : Solver
    {
        readonly string _text;
        readonly private InputData _instr;
        public Year2016Day1(string filepath)
        {
            _filepath = filepath;
            _text = File.ReadAllText(filepath);
            _instr = new InputData(_text);
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

            public void Move(Coords mvVector)
            {
                _position += mvVector;
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
            Walker w = new(x: 0, y: 0, dir: Direction.North);
            foreach (string mv in directions)
            {
                w.Move(mv);
            }
            return Coords.ManhDist(w.Position, startPos);
        }

        private class InputData
        {
            private readonly string[] _instr;
            private readonly List<Coords> _steps = new();
            public InputData(string inputText)
            {
                _instr = inputText.Split(", ");
                ParseInput();
            }

            private void Add(Coords c, int n)
            {
                if (n > 0)
                {
                    _steps.Add(c);
                    Add(c, n - 1);
                }
            }

            private void ParseInput()
            {
                Regex firstNum = new(@"\d+");
                Direction d = Direction.North;
                foreach (string instruction in _instr)
                {
                    d = d.ChangeDirection(instruction);
                    int steps = int.Parse(firstNum.Match(instruction).Value);
                    Add(dirVectors[d], steps);
                }
            }

            public Coords[] Steps { get => _steps.ToArray(); }
        }

        override public int SolvePart2()
        {
            var startPos = new Coords(0, 0);
            Walker w = new(x: 0, y: 0, dir: Direction.North);
            HashSet<Coords> visited = new()
            {
                startPos
            };
            foreach (Coords step in _instr.Steps)
            {
                w.Move(step);
                if (visited.Contains(w.Position))
                {
                    return Coords.ManhDist(w.Position, startPos);
                }
                visited.Add(w.Position);
            }
            return -1;
        }
    }
}