using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExetentionMethod
{
    public class OldClass
    {
        public int b = 100;
        public int c = 200;
        public void Test1()
        {
            Console.WriteLine("Method 1 from old class"+(c+b));
        }
        public void Test2()
        {
            Console.WriteLine("Method 2 from old class "+(c-b));
        }
    }
}
