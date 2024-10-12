using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Hash散列
{
    /// <summary>
    /// SortedDictionary 排序字典
    /// </summary>
    /// ‌SortedDictionary是.NET中的一个类，用于创建一个键值对集合，其中键是排序的。
    /// ‌SortedDictionary的特性包括‌：
    /// ‌   键的唯一性和排序‌：键是唯一的，且区分大小写，不能为null。插入和删除操作会自动保持键的排序状态。
    ///    性能‌：插入、删除和查找操作的平均时间复杂度为O(log n)，这使得它在处理大量数据时非常高效。
    /// ‌   动态容量调整‌：字典的容量会根据元素的增减动态调整，以保证操作的效率‌
    /// ‌添加元素‌：使用Add方法添加键值对，键会自动排序。
    /// ‌查找元素‌：使用IndexOfKey、GetItem等方法通过键查找值。
    /// ‌删除元素‌：使用Remove方法通过键删除元素。
    internal class SortedDictionary_DataStructure
    {
        public void Main()
        {
            SortedDictionary<string, int> scores = new SortedDictionary<string, int>();
            scores.Add("Alice", 90);
            scores.Add("Bob", 85);
            scores.Add("Charlie", 95);

            foreach (KeyValuePair<string, int> kvp in scores)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
