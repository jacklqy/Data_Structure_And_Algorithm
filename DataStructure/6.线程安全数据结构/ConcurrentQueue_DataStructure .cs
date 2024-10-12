using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.线程安全数据结构
{
    /// <summary>
    /// ConcurrentQueue<T> 线程安全版本的Queue<T> 
    /// FIFO（先进先出）队列的线程安全实现
    /// </summary>
    /// ‌ConcurrentQueue<T>;是.Net Framework 4.0中System.Collections.Concurrent命名空间下的一个线程安全队列，它是一个高效的线程安全的队列，支持多线程并发操作。
    /// 基本用法‌：
    /// Enqueue(T item)‌：将对象添加到队列的结尾。
    /// TryDequeue(out T result)‌：尝试移除并返回队列开头处的对象。
    /// TryPeek(out T result)‌：尝试返回队列开头处的对象但不移除。
    internal class ConcurrentQueue_DataStructure
    {
        public void Main()
        {
            ConcurrentQueue<int> queue = new ConcurrentQueue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            if (queue.TryPeek(out int x))
            {
                Console.WriteLine($"TryPeek:{x} ");
            }

            if (queue.TryDequeue(out int y))
            {
                Console.WriteLine($"TryDequeue:{y} ");
            }

            Test();
        }

        //------------------------------------
        //https://learn.microsoft.com/zh-cn/dotnet/api/system.collections.concurrent.concurrentqueue-1?view=net-8.0

        /// <summary>
        /// 以下示例演示如何使用 ConcurrentQueue<T> 排队和取消排队项：
        /// </summary>
        public void Test()
        {
            // Construct a ConcurrentQueue.
            ConcurrentQueue<int> cq = new ConcurrentQueue<int>();

            // Populate the queue.
            for (int i = 0; i < 10000; i++)
            {
                cq.Enqueue(i);
            }

            // Peek at the first element.
            int result;
            if (!cq.TryPeek(out result))
            {
                Console.WriteLine("CQ: TryPeek failed when it should have succeeded");
            }
            else if (result != 0)
            {
                Console.WriteLine("CQ: Expected TryPeek result of 0, got {0}", result);
            }

            int outerSum = 0;
            // An action to consume the ConcurrentQueue.使用ConcurrentQueue的操作。
            Action action = () =>
            {
                int localSum = 0;
                int localValue;
                while (cq.TryDequeue(out localValue))
                {
                    localSum += localValue;
                }
               
                Interlocked.Add(ref outerSum, localSum);
            };

            // Start 4 concurrent consuming actions.启动4个并发消费操作。
            Parallel.Invoke(action, action, action, action);

            Console.WriteLine("outerSum = {0}, should be 49995000", outerSum);
        }

        //例如，假设我们有一个共享变量count，我们希望在多个线程中安全地增加它的值：
        static int count = 0;
        static void IncreaseCount(int increment)
        {
            //Interlocked.Add(ref int target, int valueToAdd)
            //target是要增加的变量的引用，valueToAdd是要增加的值。该方法返回更新后的值。
            Interlocked.Add(ref count, increment);
        }
    }
}
