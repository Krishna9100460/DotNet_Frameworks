using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_C_Sharp.Algorithm
{
    public class LinearSearchAlg
    {
        public void InputFun()
        {
            Console.WriteLine("Enter the size of the array");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter elements");
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter the element to be searched");
            int expectedValue = Convert.ToInt32(Console.ReadLine());
            int outputIndex = LinearSearch(arr, expectedValue);
            if (outputIndex == -1)
            {
                Console.WriteLine("Element not found");
            }
            else
            {
                Console.WriteLine("Element found at index " + outputIndex);
            }
        }
        public int LinearSearch(int[] arr, int expectedValue)
        {
            int outputIndex = -1;
            try
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == expectedValue)
                    {
                        return outputIndex = i;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return outputIndex;
        }

    }
}
