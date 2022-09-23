using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC
{
    internal class Utils
    {
        public enum Direction
        {
            North,
            East,
            South,
            West
        }
        static public int Mod(int a, int b)
        {
            b = b >= 0 ? b : -b;
            a = a >= 0 ? a : b + a;
            return a % b;
        }
    }
}
