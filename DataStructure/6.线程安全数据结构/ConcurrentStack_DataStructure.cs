using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.线程安全数据结构
{
    /// <summary>
    /// ConcurrentStack<T> 线程安全版本的Stack<T>
    /// LIFO（后进先出）堆栈的线程安全实现
    /// </summary>
    /// ‌ConcurrentStack是.NET中用于多线程环境的一个线程安全的栈结构。‌ 它内部使用原子操作来实现线程安全，避免了传统锁机制可能带来的性能问题和死锁风险。
    /// 入栈（Push）和出栈（Pop）
    internal class ConcurrentStack_DataStructure
    {
        public void Main()
        {
            ConcurrentStack<int> stack = new ConcurrentStack<int>();

            // 入栈操作
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            // 出栈操作
            if (stack.TryPop(out int item))
            {
                Console.WriteLine($"Popped item: {item}");
            }

            Test1Async().GetAwaiter().GetResult();

            Test2Async().GetAwaiter().GetResult();
        }

        //-------------------------------------------
        //https://learn.microsoft.com/zh-cn/dotnet/api/system.collections.concurrent.concurrentstack-1?view=net-8.0

        /// <summary>
        /// 以下示例演示如何使用 ConcurrentStack<T> 推送和弹出单个项：
        /// </summary>
        public async Task Test1Async()
        {
            int items = 10000;

            ConcurrentStack<int> stack = new ConcurrentStack<int>();

            // Create an action to push items onto the stack 创建一个动作，将项目推到堆栈上
            Action pusher = () =>
            {
                for (int i = 0; i < items; i++)
                {
                    stack.Push(i);
                }
            };

            // Run the action once 运行该操作一次
            pusher();

            if (stack.TryPeek(out int result))
            {
                Console.WriteLine($"TryPeek() saw {result} on top of the stack.");
            }
            else
            {
                Console.WriteLine("Could not peek most recently added number.");
            }

            // Empty the stack 清空堆栈
            stack.Clear();

            if (stack.IsEmpty)
            {
                Console.WriteLine("Cleared the stack.");
            }

            // Create an action to push and pop items 创建推送和弹出项目的操作
            Action pushAndPop = () =>
            {
                Console.WriteLine($"Task started on {Task.CurrentId}");

                int item;
                for (int i = 0; i < items; i++)
                    stack.Push(i);
                for (int i = 0; i < items; i++)
                    stack.TryPop(out item);

                Console.WriteLine($"Task ended on {Task.CurrentId}");
            };

            // Spin up five concurrent tasks of the action 启动该动作的五个并发任务
            var tasks = new Task[5];
            for (int i = 0; i < tasks.Length; i++)
            {
                tasks[i] = Task.Factory.StartNew(pushAndPop);
            }

            // Wait for all the tasks to finish up 等待所有任务完成
            await Task.WhenAll(tasks);

            if (!stack.IsEmpty)
            {
                Console.WriteLine("Did not take all the items off the stack");
            }
        }

        /// <summary>
        /// 以下示例演示如何使用 ConcurrentStack<T> 推送和弹出项范围：
        /// </summary>
        public async Task Test2Async()
        {
            int numParallelTasks = 4;
            int numItems = 1000;
            var stack = new ConcurrentStack<int>();

            // Push a range of values onto the stack concurrently 同时将一系列值推送到堆栈上
            await Task.WhenAll(Enumerable.Range(0, numParallelTasks).Select(i => Task.Factory.StartNew((state) =>
            {
                // state = i * numItems
                int index = (int)state;
                int[] array = new int[numItems];
                for (int j = 0; j < numItems; j++)
                {
                    array[j] = index + j;
                }

                Console.WriteLine($"Pushing an array of ints from {array[0]} to {array[numItems - 1]}");
                stack.PushRange(array);
            }, i * numItems, CancellationToken.None, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default)).ToArray());

            int numTotalElements = 4 * numItems;
            int[] resultBuffer = new int[numTotalElements];
            await Task.WhenAll(Enumerable.Range(0, numParallelTasks).Select(i => Task.Factory.StartNew(obj =>
            {
                int index = (int)obj;
                int result = stack.TryPopRange(resultBuffer, index, numItems);

                Console.WriteLine($"TryPopRange expected {numItems}, got {result}.");
            }, i * numItems, CancellationToken.None, TaskCreationOptions.LongRunning, TaskScheduler.Default)).ToArray());

            for (int i = 0; i < numParallelTasks; i++)
            {
                // Create a sequence we expect to see from the stack taking the last number of the range we inserted
                // 从堆栈中创建一个我们期望看到的序列，取我们插入的范围的最后一个数字
                var expected = Enumerable.Range(resultBuffer[i * numItems + numItems - 1], numItems);

                // Take the range we inserted, reverse it, and compare to the expected sequence
                // 取我们插入的范围，反转它，并与预期的序列进行比较
                var areEqual = expected.SequenceEqual(resultBuffer.Skip(i * numItems).Take(numItems).Reverse());
                if (areEqual)
                {
                    Console.WriteLine($"Expected a range of {expected.First()} to {expected.Last()}. Got {resultBuffer[i * numItems + numItems - 1]} to {resultBuffer[i * numItems]}");
                }
                else
                {
                    Console.WriteLine($"Unexpected consecutive ranges.");
                }
            }
        }
    }
}
