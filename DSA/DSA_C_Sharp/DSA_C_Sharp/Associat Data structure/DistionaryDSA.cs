using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_C_Sharp.Associat_Data_structure
{
    /// <summary>
    /// DICTIONARY DATA STRUCTURE - Complete Notes
    /// 
    /// DEFINITION:
    /// A Dictionary is an unordered collection of key-value pairs where each key is unique
    /// and associated with a value. It implements the IDictionary interface and provides
    /// O(1) average case time complexity for lookup, insertion, and deletion operations.
    /// 
    /// KEY CHARACTERISTICS:
    /// 1. Keys are UNIQUE - No duplicate keys allowed
    /// 2. Key-Value Pairs - Each key maps to exactly one value
    /// 3. Unordered - Maintains no guaranteed order (unlike SortedDictionary)
    /// 4. Hash-Based - Uses hash function for fast lookups
    /// 5. Generic - Type-safe key and value types
    /// 6. Dictionary always start from key as index.
    /// 
    /// ADVANTAGES:
    /// ✓ Fast Lookup: O(1) average case time complexity for access operations
    /// ✓ Efficient Insertion/Deletion: O(1) average case for add/remove operations
    /// ✓ Unique Keys: Automatically prevents duplicate keys
    /// ✓ Type-Safe: Generic implementation provides compile-time type checking
    /// ✓ Flexible Key-Value Types: Can use any object type as key or value
    /// ✓ Built-in Methods: Rich API with ContainsKey, TryGetValue, Clear, etc.
    /// ✓ Memory Efficient: Sparse storage - only stores present elements
    /// ✓ Fast Iteration: Efficient traversal through keys, values, or pairs
    /// 
    /// DISADVANTAGES:
    /// ✗ Unordered: Elements don't maintain insertion order (use List<KeyValuePair> if order matters)
    /// ✗ Hash Collisions: Poor hash function can degrade performance
    /// ✗ Memory Overhead: Requires extra memory for hash table structure
    /// ✗ Not Sorted: Cannot efficiently retrieve elements in sorted order
    /// ✗ NullReferenceException Risk: Null keys can cause issues if not handled
    /// ✗ Thread-Unsafe: Not thread-safe for concurrent access (use ConcurrentDictionary for threading)
    /// ✗ Worst-Case Performance: O(n) in case of excessive hash collisions
    /// 
    /// TIME COMPLEXITY:
    /// - Lookup (Get): O(1) average, O(n) worst case
    /// - Insertion (Add): O(1) average, O(n) worst case
    /// - Deletion (Remove): O(1) average, O(n) worst case
    /// - Iteration: O(n) where n is number of elements
    /// 
    /// SPACE COMPLEXITY: O(n) where n is the number of key-value pairs
    /// 
    /// COMMON METHODS:
    /// - Add(key, value): Insert a new key-value pair
    /// - Remove(key): Delete an entry by key
    /// - ContainsKey(key): Check if key exists
    /// - TryGetValue(key, out value): Safe retrieval
    /// - Clear(): Remove all entries
    /// - Keys: Get all keys collection
    /// - Values: Get all values collection
    /// 
    /// USE CASES:
    /// 1. Caching: Store computed results for quick retrieval
    /// 2. Counting: Frequency of elements (e.g., word count in text)
    /// 3. Mapping: Associate related data (e.g., student ID to name)
    /// 4. Indexing: Fast lookup by unique identifier
    /// 5. Configuration: Store key-value application settings
    /// 6. Database: In-memory database operations
    /// 
    /// ALTERNATIVES:
    /// - SortedDictionary: Maintains sorted order by key (slower insertion/deletion)
    /// - ConcurrentDictionary: Thread-safe version for multi-threaded scenarios
    /// - List<KeyValuePair<K, V>>: When order preservation is important
    /// - SortedList: Optimized for sequential access
    /// </summary>
    public class DistionaryDSA
    {

        public void DisctionaryEx()
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(4, "Sudha");
            dic.Add(5, "Krishna");
            dic.Add(-1, "Krishna");
            dic.Add(0, "buddi");
            dic.Add(1, "jowsy");
            dic.Add(2, "Prasad");
            dic.Add(3, "Addanki");
            //dic.Add(3, "addanki");//Not allowed the duplicate key
            dic.Add(-2, "Sudha");
            dic.Add(-3, "Krishna");

            Console.WriteLine("Dictionary output :");
            /* Console.WriteLine("Using For loop :");
             for (int i = 1; i < dic.Count - 1; i++)
             {
                 Console.WriteLine($"Key: {dic[i].IndexOf(dic[i])}, Value: {dic[i]}");
             }*/

            Console.WriteLine("Using ForeachLoop");
            foreach (var item in dic)
            {
                Console.WriteLine($"Key: {item.Key} , Value: {item.Value}");
            }

            dic.Remove(1);
            Console.WriteLine("After Remove(1) ");
            foreach (var item in dic)
            {
                Console.WriteLine($"Key: {item.Key} , Value: {item.Value}");
            }

            SortedDictionary<int, string> sD = new SortedDictionary<int, string>();
            sD.Add(3, "Addanki");
            sD.Add(4, "Sudha");
            sD.Add(5, "Krishn5a");
            sD.Add(-1, "Krishna");
            sD.Add(0, "buddi");
            sD.Add(1, "jowsy");
            sD.Add(2, "Prasad");


            Console.WriteLine("SortedDictionary output :");
            /*   Console.WriteLine("Using For loop :");
               for (int i = 1; i < dic.Count - 1; i++)
               {
                   Console.WriteLine($"Key: {dic[i].IndexOf(dic[i])}, Value: {dic[i]}");
               }*/

            Console.WriteLine("Using ForeachLoop");
            foreach (var item in sD)
            {
                Console.WriteLine($"Key: {item.Key} , Value: {item.Value}");
            }

            sD.Remove(1);
            Console.WriteLine(" SortedDictionary After Remove(1) ");
            foreach (var item in sD)
            {
                Console.WriteLine($"Key: {item.Key} , Value: {item.Value}");
            }

            ConcurrentDictionary<int, string> cd = new ConcurrentDictionary<int, string>();
        }
    }
}
