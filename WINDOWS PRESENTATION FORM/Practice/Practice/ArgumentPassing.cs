using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class ArgumentPassing
    {
        internal void Method_One(bool isFlag)
        {
            isFlag = false;
        }
        internal void Method_Two(out int d)
        {
            bool data = true;
            bool flag = true;
            if(data)
            {
                
            }
            d = 500;
            Method_One(flag);
        }
    }
}
