using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest
{
    interface IInterfaceOne
    {
        public virtual void Add()
        {
            int a = 10;
            int b = 20;
            int c = a + b;
        }
    }
}
