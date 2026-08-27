using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_C_Sharp.Algorithm
{
    public class BinarySearch
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
            int outputIndex = BinarySearchEx(arr, expectedValue);
            if (outputIndex == -1)
            {
                Console.WriteLine("Element not found");
            }
            else
            {
                Console.WriteLine("Element found at index " + outputIndex);
            }
        }
        public int BinarySearchEx(int[] arr, int searchElement)
        {
            // Sort the array because Binary Search requires sorted data.
            Array.Sort(arr);

            // Stores the middle index of the current search range.
            int mid;

            // Starting index of the search range.
            int arrayStart = 0;

            // Ending index of the search range.
            int arrayEnd = arr.Length - 1;

            // Continue while a valid search range exists.
            while (arrayStart <= arrayEnd)
            {
                // Calculate the middle index.
                mid = arrayStart + (arrayEnd - arrayStart) / 2;

                // Check whether the middle element is the search element.
                if (arr[mid] == searchElement)
                {
                    return mid;
                }
                // Search element is greater, so search the right half.
                else if (searchElement > arr[mid])
                {
                    arrayStart = mid + 1;
                }
                // Search element is smaller, so search the left half.
                else
                {
                    arrayEnd = mid - 1;
                }
            }

            // Element was not found.
            return -1;
        }
    }
}
