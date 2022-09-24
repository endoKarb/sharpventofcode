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
        private readonly InputData _instr;
        private readonly Coords _startPos = new(0, 0);
        public Year2016Day1(string filepath)
        {
            _filepath = filepath;
            _instr = new InputData(File.ReadAllText(filepath));
        }
        private static readonly Dictionary<Direction, Coords> dirVectors = new()
        {
            [Direction.North] = new Coords(x: 0, y: +1),
            [Direction.South] = new Coords(x: 0, y: -1),
            [Direction.East] = new Coords(x: +1, y: 0),
            [Direction.West] = new Coords(x: -1, y: 0),
        };
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
        override public int SolvePart1()
        {
            
            Walker w = new(x: 0, y: 0, dir: Direction.North);
            foreach (Coords step in _instr.Steps)
            {
                w.Move(step);
            }
            return Coords.ManhDist(w.Position, _startPos);
        }
        override public int SolvePart2()
        {
            Walker w = new(x: 0, y: 0, dir: Direction.North);
            HashSet<Coords> visited = new()
            {
                _startPos
            };
            foreach (Coords step in _instr.Steps)
            {
                w.Move(step);
                if (visited.Contains(w.Position))
                {
                    SolvePart2AndDraw();
                    return Coords.ManhDist(w.Position, _startPos);
                }
                visited.Add(w.Position);
            }
            return -1;
        }

        public int SolvePart2AndDraw()
        {
            Walker w = new(x: 0, y: 0, dir: Direction.North);
            int minX = 0;
            int minY = 0;
            int maxX = 0;
            int maxY = 0;
            Coords firstIntersection = new(0, 0);
            int solution = -1;
            HashSet<Coords> visited = new()
            {
                _startPos
            };
            foreach (Coords step in _instr.Steps)
            {
                w.Move(step);
                minX = w.Position.X < minX ? w.Position.X : minX;
                maxX = w.Position.X > maxX ? w.Position.X : maxX;
                minY = w.Position.Y < minY ? w.Position.Y : minY;
                maxY = w.Position.Y > maxY ? w.Position.Y : maxY;
                if (visited.Contains(w.Position))
                {
                    firstIntersection = w.Position;
                    solution = Coords.ManhDist(firstIntersection, _startPos);
                }
                visited.Add(w.Position);
            }
            int offsetY = Math.Abs(minY);
            int offsetX = Math.Abs(minX);
            int[,] a = new int[maxY + offsetY + 1, maxX + offsetX + 1];
            foreach (Coords c in visited)
            {
                a[maxY - (c.Y + Math.Abs(minY)), c.X + Math.Abs(minX)] = 1;
            }
            StringBuilder sb = new(a.GetLength(1)+1 * a.GetLength(0));
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i == maxY - offsetY && j == offsetX)
                    {
                        sb.Append('0');
                    } else if (i == maxY - (offsetY + firstIntersection.Y) && j == offsetX + firstIntersection.X)
                    {
                        sb.Append('X');
                    } else
                    {
                        switch (a[i, j])
                        {
                            case 0:
                                sb.Append('.');
                                break;
                            case 1:
                                sb.Append('#');
                                break;
                            default:
                                break;
                        }
                    }                    
                }
                sb.Append('\n');
            }
            File.WriteAllText("./output.txt", sb.ToString());
            //Debug.WriteLine(sb.ToString());
            return solution;
        }
    }
}