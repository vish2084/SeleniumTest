using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest
{
    public class ConstReadOnlyAndStatic
    {
        public const int a = 10;
        public readonly int b;
        public ConstReadOnlyAndStatic()
        {
            b = 20;
        }

        public ConstReadOnlyAndStatic(int c)
        {
            b = c;
        }
    }
}
