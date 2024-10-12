using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.线程安全数据结构
{
    /// <summary>
    /// ConcurrentDictionary<TKey,TValue>线程安全的Dictionary<TKey,TValue>
    /// </summary>
    internal class ConcurrentDictionary_DataStructure
    {
        public void Main()
        {
            var dictionary = new ConcurrentDictionary<int, string>();

            //将新键添加到字典（如果字典中尚不存在）
            dictionary.TryAdd(1, "111");

            //更新字典中现有键的值（如果该键具有特定值）
            dictionary.TryUpdate(1, "222", "111");

            //获取字典中某个键的值，将值添加到字典，并在键不存在时返回它
            dictionary.GetOrAdd(1, "333");

            //将键/值对添加到字典，或者如果键已存在，请根据键的现有值更新键的值
            string newValue = dictionary.AddOrUpdate(0, key => "Zero", (key, oldValue) => "Zero");

            Test();
        }

        public void Test()
        {
            // We know how many items we want to insert into the ConcurrentDictionary.
            // So set the initial capacity to some prime number above that, to ensure that
            // the ConcurrentDictionary does not need to be resized while initializing it.
            int NUMITEMS = 64;
            int initialCapacity = 101;

            // The higher the concurrencyLevel, the higher the theoretical number of operations
            // that could be performed concurrently on the ConcurrentDictionary.  However, global
            // operations like resizing the dictionary take longer as the concurrencyLevel rises.
            // For the purposes of this example, we'll compromise at numCores * 2.
            int numProcs = Environment.ProcessorCount;
            int concurrencyLevel = numProcs * 2;

            // Construct the dictionary with the desired concurrencyLevel and initialCapacity
            ConcurrentDictionary<int, int> cd = new ConcurrentDictionary<int, int>(concurrencyLevel, initialCapacity);

            // Initialize the dictionary
            for (int i = 0; i < NUMITEMS; i++)
            {
                cd[i] = i * i;
            }

            Console.WriteLine("The square of 23 is {0} (should be {1})", cd[23], 23 * 23);
        }
    }
}
