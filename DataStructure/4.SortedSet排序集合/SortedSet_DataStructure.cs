using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.SortedSet排序集合
{
    /// <summary>
    /// SortedSet<T>排序集合：和HashSet 相比是排序的，有去重和排序的特性可以做如：直播打赏排行
    /// </summary>
    /// SortedSet<T>;是.NET中的一个排序的无重复数据集合，其内部实现基于红黑树。‌ 
    /// SortedSet<T>适用于需要快速检索和排序数据的场景，能够在插入、删除和搜索元素时保持数据的排序状态‌。
    /// SortedSet<T> 提供了一些常用的方法和属性，包括：
    ///     Add‌：添加元素到集合中。
    ///     Remove‌：从集合中移除元素。
    ///     Count‌：获取集合中元素的数量。
    ///     Max‌ 和 ‌Min‌：分别获取集合中的最大和最小元素。
    ///     Comparer‌：获取用于确定集合中元素顺序的IComparer<T>;。
    ///     IsReadOnly‌：指示集合是否为只读‌
    internal class SortedSet_DataStructure
    {
        public void Main()
        {
            //SortedSet<int> sortedSet = [1, 5, 2, 4, 3];
            SortedSet<int> sortedSet = new SortedSet<int>();
            sortedSet.Add(1);
            sortedSet.Add(5);
            sortedSet.Add(2);
            sortedSet.Add(4);
            sortedSet.Add(3);

            Console.WriteLine($"元素数量Count=:{sortedSet.Count} ");
            Console.WriteLine($"最大元素Max=:{sortedSet.Max} ");
            Console.WriteLine($"最小元素min=:{sortedSet.Min} ");

            sortedSet.Remove(1);

            foreach (var item in sortedSet)
            {
                Console.WriteLine($"元素:{item} ");
            }
        }
    }
}
