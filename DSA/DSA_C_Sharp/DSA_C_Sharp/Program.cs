using DSA_C_Sharp.LinearData_Structure;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSA_C_Sharp.Associat_Data_structure;
using DSA_C_Sharp.Algorithm;

namespace DSA_C_Sharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Linear data structure types.");
             Console.WriteLine(
                 "1.Array" +
                 "2.List" +
                 "3.LinkedLis" +
                 "4.Stack" +
                 "5.Queue" +
                 "6.priorityQueue");*/

            /*  Console.WriteLine("Linear data structure - Array");
              ArrayDSA arrayDSA = new ArrayDSA();
              arrayDSA.JaggedArray();*/

            /* Console.WriteLine("Linear data structure - LinkedList");
             LinkedListData listDSA = new LinkedListData();
             listDSA.LinkedListEx();*/

            /* Console.WriteLine("Linear Data structure - Stack");
             StackData stackData = new StackData();
             stackData.StackEx();*/

            /* Console.WriteLine("Linear Data structure - Queue");
             QueueDataStructure queueData = new QueueDataStructure();
             queueData.QueueDataEx();*/

            /*   Console.WriteLine("Linear Data structure - Priority Queue");
               PriorityQueueDataStructure priorityQueueData = new PriorityQueueDataStructure();
               priorityQueueData.PriorityQueueEx();*/

            //Console.WriteLine("Associate data structure ");
            //Console.WriteLine("1.Dictionary , 2.SortedList 3.HashTable");

            //Console.WriteLine("1.Dictionary and SortedDictionary:");
            //DistionaryDSA dis_Dsa = new DistionaryDSA();
            //dis_Dsa.DisctionaryEx();


            //Console.WriteLine("2.Sorted List");
            //SortedListDSA sortedListDSA = new SortedListDSA();
            //sortedListDSA.SortedListEx();

            Console.WriteLine("Linear Search Algorithm:");
            BinarySearch linearSearchAlg = new BinarySearch();
            linearSearchAlg.InputFun();


        }
    }
}
