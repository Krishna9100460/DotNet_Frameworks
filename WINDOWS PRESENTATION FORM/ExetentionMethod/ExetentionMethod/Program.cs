using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExetentionMethod
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            NewClass.OldClasses.Add(new OldClass());
            NewClass.OldClasses.Add(new OldClass()); NewClass.OldClasses.Add(new OldClass());

            OldClass oldClass = NewClass.OldClasses.Find(x => x.b < 100);
            //OldClass oldClass = new OldClass();
            //oldClass.Test1();
            //oldClass.Test2();
            //oldClass.Test3();
            //oldClass.Test4(240);
            //oldClass.Test5();
        }
    }
}
