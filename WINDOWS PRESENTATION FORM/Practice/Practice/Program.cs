using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 65;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 5; j > i; j--)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j <=i; j++)
                {
                    char c = Convert.ToChar(number);
                    Console.Write(c + " ");
                    number++;
                }
                Console.WriteLine();
            }

            for (int k = 0; k<5; k++)
            {
                for (int h = k; h > 0; h--)
                {
                    Console.Write(" ");
                }

                for (int h = 5; h >k; h--)
                {
                    char ch = Convert.ToChar(number);
                    Console.Write(ch + " ");
                    number++;
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
