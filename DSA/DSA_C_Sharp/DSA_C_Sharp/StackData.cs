using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_C_Sharp
{
    public class StackData
    {
        public void StackEx()
        {
            //LIFO
            Stack<int> stackData = new Stack<int>();
            //Push() - add the element 
            //Pop() remove the Top Element
            //Peek()- display top element without removing it 
            stackData.Push(1);
            stackData.Push(2);
            stackData.Push(3);
            stackData.Push(4);
            Console.WriteLine(stackData.Peek());


            Console.WriteLine("Output of Stack");
            foreach (int item in stackData)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Output of Stack after POP");
            stackData.Pop();
            foreach (int item in stackData)
            {
                Console.WriteLine(item);
            }
        }
    }
}
