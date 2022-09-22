using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2015
{
    internal class Day1Solver
    {
        readonly string _inputText;
        public Day1Solver()
        {
            _inputText = File.ReadAllText("../../../input/day1");
        }
        public int Part1()
        {
            int answer = 0;
            for (int i = 0; i < _inputText.Length; i++)
            {
                switch (_inputText[i])
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
    }
}
