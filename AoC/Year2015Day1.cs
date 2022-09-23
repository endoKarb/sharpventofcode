using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AoC
{
    internal class Year2015Day1 : AoCSolver
    {
        readonly string _text;
        public Year2015Day1(string filepath)
        {
            _filepath = filepath;
            _text = File.ReadAllText(filepath);
        }

        override public int SolvePart1()
        {
            int answer = 0;
            for (int i = 0; i < _text.Length; i++)
            {
                switch (_text[i])
                {
                    case '(':
                        answer++;
                        break;
                    case ')':
                        answer--;
                        break;
                    default:
                        break;
                }
            }
            return answer;
        }

        override public int SolvePart2()
        {
            return 0;
        }
    }
}
