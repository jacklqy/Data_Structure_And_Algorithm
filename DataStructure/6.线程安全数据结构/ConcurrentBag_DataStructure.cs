using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.线程安全数据结构
{
    /// <summary>
    /// ConcurrentBag线程安全的对象集合
    /// 无序元素集合的线程安全实现
    /// </summary>
    internal class ConcurrentBag_DataStructure
    {
        public void Main()
        {
            // Add to ConcurrentBag concurrently
            ConcurrentBag<int> cb = new ConcurrentBag<int>();
            List<Task> bagAddTasks = new List<Task>();
            for (int i = 0; i < 500; i++)
            {
                var numberToAdd = i;//
                bagAddTasks.Add(Task.Run(() => cb.Add(numberToAdd)));
            }

            // Wait for all tasks to complete
            Task.WaitAll(bagAddTasks.ToArray());

            // Consume the items in the bag
            List<Task> bagConsumeTasks = new List<Task>();
            int itemsInBag = 0;
            while (!cb.IsEmpty)
            {
                bagConsumeTasks.Add(Task.Run(() =>
                {
                    int item;
                    //尝试从 ConcurrentBag<T>中删除和返回对象。
                    if (cb.TryTake(out item))
                    {
                        Console.WriteLine(item);
                        //‌Interlocked.Increment方法‌用于在多线程环境中安全地将一个变量的值增加1
                        Interlocked.Increment(ref itemsInBag);
                    }
                }));
            }
            Task.WaitAll(bagConsumeTasks.ToArray());

            Console.WriteLine($"There were {itemsInBag} items in the bag");

            // Checks the bag for an item
            // The bag should be empty and this should not print anything
            //检查ConcurrentBag里是否有物品袋子应该是空的，这不应该打印任何东西
            int unexpectedItem;
            //尝试从 ConcurrentBag<T> 返回对象而不将其删除。
            if (cb.TryPeek(out unexpectedItem))
                Console.WriteLine("Found an item in the bag when it should be empty");
        }
    }
}
