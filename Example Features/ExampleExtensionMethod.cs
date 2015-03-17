using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestPractices.Example_Features
{
    public static class IntExtensions
    {
        public static int Multiply(this int x, int y)
        {
            return x*y;
        }
    }
}
