using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC
{
    interface Solver
    {
        abstract public int SolvePart1();
        abstract public int SolvePart2();
    }
    abstract internal class AoCSolver : Solver
    {
        protected string _filepath;
        abstract public int SolvePart1();
        abstract public int SolvePart2();

    }
}
