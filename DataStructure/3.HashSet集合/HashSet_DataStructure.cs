using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.HashSet集合
{
    /// <summary>
    /// HashSet<T>集合：hash分布、元素间没有关系、动态增加容量、去重（如统计用户、多次提交之生效一次）也可以取得交叉并补集(效率比List高)
    /// </summary>
    /// ‌HashSet<T>;是.NET中的一个集合类，用于存储不重复的元素。‌ 
    /// 它通过内部使用哈希表来实现，提供了高性能的集合操作，如添加、删除和查找元素。
    /// HashSet<T>不允许重复元素，并且元素的顺序是不确定的，这使得它在需要快速查找和去重时非常有用‌。
    /// HashSet<T>的基本用法包括以下几个步骤：
    /// 添加元素使用Add(item)
    /// 删除元素使用Remove(item)
    /// 查找元素是否存在使用Contains(item)
    internal class HashSet_DataStructure
    {
        public void Main()
        {
            //HashSet<int> hashSet = [1, 2, 3];
            HashSet<int> hashSet = new HashSet<int>();
            hashSet.Add(1);
            hashSet.Add(2);
            hashSet.Add(3);

            hashSet.Remove(1);

            //if (hashSet.Contains(2))
            if (hashSet.TryGetValue(2, out int v))
            {
                Console.WriteLine("包含元素: " + v);
            }

            foreach (var item in hashSet)
            {
                Console.WriteLine("元素: " + item);
            }
        }
    }
}
