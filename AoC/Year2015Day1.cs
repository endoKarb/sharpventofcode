using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AoC
{
    internal class Year2015Day1 : Solver
    {
        readonly string _text;
        public Year2015Day1(string filepath)
        {
            _filepath = filepath;
            _text = File.ReadAllText(filepath);
        }

        override public int SolvePart1()
        {
            int floor = 0;
            for (int i = 0; i < _text.Length; i++)
            {
                switch (_text[i])
                {
                    case '(':
                        floor++;
                        break;
                    case ')':
                        floor--;
                        break;
                    default:
                        break;
                }
            }
            return floor;
        }

        override public int SolvePart2()
        {
            int floor = 0;
            int i;
            for (i = 0; i < _text.Length; i++)
            {
                if (floor == -1)
                {
                    break;
                }
                switch (_text[i])
                {
                    case '(':
                        floor++;
                        break;
                    case ')':
                        floor--;
                        break;
                    default:
                        break;
                }
            }
            return i;
        }
    }
}
