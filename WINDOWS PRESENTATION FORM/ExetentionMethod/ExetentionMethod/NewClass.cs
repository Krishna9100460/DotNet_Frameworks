using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExetentionMethod
{
    public static class NewClass
    {
        public static List<OldClass> OldClasses = new List<OldClass>();
        public static void Test3(this OldClass a)
        {
            Console.WriteLine("Method Three from newclass"+(a.b*a.c));
        }
        public static void Test4(this OldClass a, int x)
        {
            Console.WriteLine("Method Four from newclass: " +(a.c/a.b));
        }
        public static void Test5(this OldClass O)
        {
            Console.WriteLine("Method Five from new class:" + O.b%O.c);
        }
    }
}
