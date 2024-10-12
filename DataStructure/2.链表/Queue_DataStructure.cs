using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.链表
{
    /// <summary>
    /// Queue<T>队列(先进先出，如多线程日志，边删除边打印等）
    /// </summary>
    /// Queue类的主要优点包括：
    /// 动态容量调整‌：根据需要动态调整容量，以适应不同的使用场景。
    /// 高效的添加和移除操作‌：添加元素到队列末尾和从队列前端移除元素的操作非常高效，时间复杂度为O(1)。
    /// 灵活的数据类型‌：如果不使用泛型，默认元素类型为object，使用泛型时可以指定具体的类型，如Queue<int>、Queue<string> 等‌
    /// Queue类的主要方法包括：
    /// Enqueue(object obj)‌：将一个元素添加到队列的末尾。
    /// Dequeue()‌：从队列的前端移除一个元素，并返回该元素。
    /// Count‌：获取队列中元素的数量。
    /// Clear()‌：移除队列中的所有元素。
    /// Contains(object obj)‌：检查队列是否包含一个指定的元素。
    /// ToArray()‌：将队列中的元素复制到一个新数组中‌
    internal class Queue_DataStructure
    {
        public void Main()
        {
            Queue<int> numbers = new Queue<int>();
            numbers.Enqueue(1);
            numbers.Enqueue(2);
            numbers.Enqueue(3);
            Console.WriteLine("队列中的元素数量: " + numbers.Count); // 输出: 队列中的元素数量: 3
            Console.WriteLine("从队列前端移除的元素: " + numbers.Dequeue()); // 输出: 从队列前端移除的元素: 1
            Console.WriteLine("队列中的元素数量: " + numbers.Count); // 输出: 队列中的元素数量: 2
        }
    }
}
