using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Hash散列
{
    /// <summary>
    /// SortedList 排序集合
    /// </summary>
    /// ‌SortedList是.NET中的一个类，用于存储键值对，并且键是排序的。‌ 
    /// SortedList类代表了一系列按照键来排序的键/值对，这些键值对可以通过键和索引来访问。
    /// 它结合了数组和哈希表的特点，允许通过键快速访问元素，同时保持元素的排序顺序‌。
    /// SortedList的主要方法和属性包括‌：
    /// Add(key, value)‌: 将带有指定键和值的元素添加到SortedList中。如果键已存在，则会抛出异常。
    /// ‌Clear()‌: 从SortedList中删除所有元素。
    /// ContainsKey(key)‌: 确定SortedList是否包含特定键。
    /// ContainsValue(value)‌: 确定SortedList是否包含特定值。
    /// ‌GetByIndex(index)‌: 获取SortedList的指定索引处的值。索引是从零开始的。
    /// GetKey(index)‌: 获取SortedList的指定索引处的键。
    /// ‌GetKeyList()‌ 和 ‌GetValueList()‌: 分别获取SortedList中的键和值的集合。
    /// ‌Item[key]‌: 通过键来获取或设置与SortedList中的特定键相关联的值。
    /// ‌Capacity‌: 获取或设置SortedList的容量，随着元素的添加，容量会自动增加，但也可以显式设置以优化性能‌
    internal class SortedList_DataStructure
    {
        public void Main()
        {
            SortedList mySL = new SortedList();
            mySL.Add("First", "Hello");
            Console.WriteLine("The key at index 0 is " + mySL.GetKey(0)); // 输出 "First"
            Console.WriteLine("The value at index 0 is " + mySL.GetByIndex(0)); // 输出 "Hello"
        }
    }
}
