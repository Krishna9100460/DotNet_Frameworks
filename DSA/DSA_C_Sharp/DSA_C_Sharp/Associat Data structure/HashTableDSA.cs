using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_C_Sharp.Associat_Data_structure
{
    /// <summary>
    /// HASH TABLE DATA STRUCTURE - Complete Notes
    /// 
    /// DEFINITION:
    /// A HashTable is a data structure that implements an associative array - a structure that
    /// maps keys to values using a HASH FUNCTION. It's one of the most fundamental data structures
    /// in computer science, providing efficient insertion, deletion, and lookup operations.
    /// HashTable uses an array of linked lists or open addressing to handle hash collisions.
    /// 
    /// NOTE: HashTable in C# is a legacy, non-generic collection. Modern applications should use
    /// Dictionary<TKey, TValue> or ConcurrentDictionary<TKey, TValue> instead.
    /// 
    /// HOW IT WORKS:
    /// 1. Hash Function: Converts a key into an array index
    /// 2. Array Storage: Uses an array to store key-value pairs
    /// 3. Collision Resolution: Handles multiple keys hashing to same index
    /// 4. Dynamic Resizing: Automatically grows when load factor exceeds threshold
    /// 
    /// KEY CHARACTERISTICS:
    /// 1. Unordered: No guaranteed order of elements
    /// 2. Non-Generic: Accepts object type, requires casting
    /// 3. Non-Thread-Safe: Not safe for concurrent access (unlike ConcurrentDictionary)
    /// 4. Hash-Based: Uses hash function for O(1) average access
    /// 5. Collision Handling: Manages collisions through chaining or probing
    /// 6. Dynamic: Automatically resizes as capacity is reached
    /// 7. Legacy: Part of pre-generics .NET framework
    /// 
    /// HASH TABLE INTERNALS:
    /// 
    /// Hash Function: key -> index
    /// - Distributes keys uniformly across array
    /// - Example: hashValue = key.GetHashCode() % arraySize
    /// - Good hash functions minimize collisions
    /// 
    /// Collision Resolution Strategies:
    /// a) Chaining (Separate Chaining):
    ///    - Each array index contains a linked list
    ///    - Colliding elements stored in same bucket
    ///    - Time: O(1 + α) where α is load factor
    /// 
    /// b) Open Addressing:
    ///    - Linear Probing: Find next empty slot
    ///    - Quadratic Probing: Use quadratic steps
    ///    - Double Hashing: Use second hash function
    /// 
    /// Load Factor (α):
    /// - α = n / m (n = number of elements, m = array size)
    /// - When α exceeds threshold (typically 0.75), table is rehashed
    /// - Rehashing: Create larger array and reinsert all elements
    /// 
    /// ADVANTAGES:
    /// ✓ Fast Average Lookup: O(1) average case for get operations
    /// ✓ Fast Average Insertion: O(1) average case for add operations
    /// ✓ Fast Average Deletion: O(1) average case for remove operations
    /// ✓ Efficient Caching: Ideal for implementing cache systems
    /// ✓ Flexible Key Types: Can use any object as key
    /// ✓ No Key Ordering Overhead: Doesn't require maintaining order
    /// ✓ Sparse Data: Efficiently handles sparse data (mostly empty keys)
    /// ✓ Common Use Case: Well-suited for real-world key-value mappings
    /// 
    /// DISADVANTAGES:
    /// ✗ Poor Worst-Case Performance: O(n) when many collisions occur
    /// ✗ Hash Function Dependent: Performance depends on hash function quality
    /// ✗ Memory Overhead: Extra space for hash table structure and collisions
    /// ✗ Unordered: Cannot iterate in any meaningful order
    /// ✗ Not Thread-Safe: Requires external synchronization for concurrent access
    /// ✗ Hash Collisions: Multiple keys can hash to same index
    /// ✗ Rehashing Cost: Expensive operation when table grows
    /// ✗ Non-Generic (Legacy): C# HashTable is non-generic, requires casting
    /// ✗ Complex Implementation: Requires understanding collision resolution
    /// ✗ Difficult Testing: Hard to predict behavior due to hash randomization
    /// 
    /// TIME COMPLEXITY:
    /// - Average Case:
    ///   * Lookup (Get): O(1)
    ///   * Insertion (Add): O(1)
    ///   * Deletion (Remove): O(1)
    ///   * Iteration: O(n)
    /// 
    /// - Worst Case (poor hash function / many collisions):
    ///   * Lookup: O(n)
    ///   * Insertion: O(n)
    ///   * Deletion: O(n)
    ///   * Iteration: O(n)
    /// 
    /// - Rehashing: O(n) - One-time cost when capacity exceeded
    /// 
    /// SPACE COMPLEXITY: O(n + m) where n = elements, m = hash table size
    /// 
    /// COMMON METHODS (C# HashTable):
    /// - Add(key, value): Insert a key-value pair
    /// - Remove(key): Delete an entry by key
    /// - Contains(key): Check if key exists
    /// - ContainsKey(key): Check if key exists (more specific)
    /// - ContainsValue(value): Check if value exists
    /// - Clear(): Remove all entries
    /// - Keys: Get all keys collection
    /// - Values: Get all values collection 
    /// - Count: Get number of elements
    /// - Synchronized(hashtable): Create thread-safe wrapper
    /// 
    /// COMPARISON WITH SIMILAR DATA STRUCTURES:
    /// 
    /// HashTable vs Dictionary<K, V>:
    /// - HashTable: Non-generic, legacy, not recommended for new code
    /// - Dictionary: Generic, type-safe, preferred modern approach
    /// - Performance: Similar O(1) average case
    /// - HashTable requires casting; Dictionary doesn't
    /// 
    /// HashTable vs SortedDictionary:
    /// - HashTable: Unordered, O(1) average lookup
    /// - SortedDictionary: Ordered by key, O(log n) lookup
    /// - Use HashTable for unordered data
    /// - Use SortedDictionary when ordering needed
    /// 
    /// HashTable vs ConcurrentDictionary:
    /// - HashTable: Single-threaded, not thread-safe
    /// - ConcurrentDictionary: Thread-safe, designed for multi-threading
    /// - Use HashTable only for single-threaded scenarios
    /// - Use ConcurrentDictionary for multi-threaded applications
    /// 
    /// USE CASES:
    /// 1. Symbol Tables: Compiler symbol tables for variable/function names
    /// 2. Caching: Store computed results for quick retrieval
    /// 3. Indexing: Create indexes for fast lookups
    /// 4. Frequency Counting: Count occurrences of elements
    /// 5. Lookup Tables: Quick reference data lookups
    /// 6. Database Indexing: In-memory database index structures
    /// 7. String Interning: Store and reuse string objects
    /// 8. Object Pooling: Manage reusable object instances
    /// 9. Session Management: Store user session data
    /// 10. Configuration Storage: Store application settings and configs
    /// 
    /// REAL-WORLD EXAMPLES:
    /// 1. Browser Cache: URL -> Web page content mapping
    /// 2. Phone Directory: Phone number -> Contact name
    /// 3. Dictionary: Word -> Definition
    /// 4. Library System: Book ISBN -> Book details
    /// 5. User Database: User ID -> User profile
    /// 
    /// HASH FUNCTION DESIGN PRINCIPLES:
    /// 1. Uniformity: Distribute keys evenly across buckets
    /// 2. Efficiency: Compute hash quickly
    /// 3. Consistency: Same key always produces same hash
    /// 4. Avalanche Effect: Small key change produces different hash
    /// 5. Few Collisions: Minimize hash collisions
    /// 
    /// HANDLING COLLISIONS:
    /// 1. Chaining: Store all colliding elements in linked list at that bucket
    /// 2. Linear Probing: Find next empty slot sequentially
    /// 3. Quadratic Probing: Skip ahead quadratically
    /// 4. Double Hashing: Use second hash function
    /// 5. Cuckoo Hashing: Move existing element when collision occurs
    /// 
    /// COMMON ISSUES AND SOLUTIONS:
    /// 
    /// Issue 1: Poor Hash Distribution
    /// - Solution: Use better hash function or custom IHashCodeProvider
    /// 
    /// Issue 2: Many Collisions
    /// - Solution: Increase table size (rehash)
    /// - Solution: Use better hash function
    /// 
    /// Issue 3: High Memory Usage
    /// - Solution: Adjust initial capacity
    /// - Solution: Consider alternative data structures
    /// 
    /// Issue 4: Not Thread-Safe
    /// - Solution: Use ConcurrentDictionary for multi-threaded code
    /// - Solution: Use lock statement for synchronization
    /// 
    /// MIGRATION FROM HASHTABLE (Legacy):
    /// 
    /// Old Code:
    /// HashTable ht = new HashTable();
    /// ht.Add("key", "value");
    /// string value = (string)ht["key"]; // Requires casting!
    /// 
    /// New Code:
    /// Dictionary<string, string> dict = new Dictionary<string, string>();
    /// dict.Add("key", "value");
    /// string value = dict["key"]; // Type-safe, no casting
    /// 
    /// PERFORMANCE CHARACTERISTICS:
    /// - Best Case: O(1) for all operations
    /// - Average Case: O(1) for get/add/remove with good hash function
    /// - Worst Case: O(n) with poor hash function or many collisions
    /// - Load Factor Impact: Performance degrades as load factor increases
    /// 
    /// WHEN TO USE HASHTABLE:
    /// ✓ Legacy code maintenance (C# < 2.0)
    /// ✓ Interoperability with legacy systems
    /// ✗ NOT for new code - use Dictionary instead
    /// 
    /// WHEN TO USE ALTERNATIVES:
    /// - Use Dictionary<TKey, TValue>: Modern generic version (preferred)
    /// - Use SortedDictionary: When ordering by key is needed
    /// - Use ConcurrentDictionary: Multi-threaded applications
    /// - Use List<KeyValuePair>: When order preservation matters
    /// 
    /// DEBUGGING TIPS:
    /// 1. Monitor Load Factor: As it approaches 1.0, performance degrades
    /// 2. Profile Hash Distribution: Ensure even distribution of keys
    /// 3. Watch Rehashing: Large rehashes can cause performance spikes
    /// 4. Track Collision Rate: High collisions indicate poor hash function
    /// 5. Use Debugging Tools: Visual Studio debugger to inspect hash table state
    /// 
    /// CONCLUSION:
    /// HashTable is a foundational data structure that provides efficient average-case
    /// performance for key-value operations. However, in modern C#/.NET applications,
    /// use Dictionary<TKey, TValue> instead, which provides the same performance benefits
    /// with type safety and a cleaner API.
    /// </summary>
    public class HashTableDSA
    {

    }
}
