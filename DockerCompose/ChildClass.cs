using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DockerCompose
{
    class ChildClass : SealedClassAndMethod
    {
        public sealed override void Method()
        {
            base.Method();
        }
    }
}
