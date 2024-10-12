using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.链表
{
    /// <summary>
    /// LinkedList<T>双向链表（针对每个内存节点可以操作如：贪吃蛇，令牌环）它允许在列表的开头和结尾添加或删除节点，同时也支持在指定节点的前后插入新节点。‌ 
    /// </summary>
    /// ‌属性‌：
    /// Count：获取链表中的节点数。
    /// First 和 Last：分别获取链表的第一个和最后一个节点。
    /// LinkedList类的主要方法包括：
    /// AddFirst(T value)：在链表的开头添加一个新节点。
    /// AddLast(T value)：在链表的结尾添加一个新节点。
    /// AddAfter(LinkedListNode<T> node, T value)：在指定节点之后添加一个新节点。
    /// AddBefore(LinkedListNode<T> node, T value)：在指定节点之前添加一个新节点。
    /// Remove(LinkedListNode<T> node)：移除指定的节点。
    /// RemoveFirst() 和 RemoveLast()：分别移除链表的第一个和最后一个节点。
    /// Contains(T value)：检查链表中是否包含某个值。
    /// Find(T value)：查找包含指定值的第一个节点。
    /// FindLast(T value)：查找包含指定值的最后一个节点。
    /// Clear()：移除链表中的所有节点‌
    internal class LinkedList_DataStructure
    {
        public void Main()
        {
            LinkedList<string> linkedList = new LinkedList<string>();
            linkedList.AddFirst("C/C++");
            linkedList.AddLast("Java");
            bool isContain = linkedList.Contains("Java"); // 返回 true
            LinkedListNode<string>? nodeC = linkedList.Find("C/C++"); // 获取节点
            linkedList.AddBefore(nodeC, "C#");
            linkedList.AddAfter(nodeC, "Python");
            foreach (var item in linkedList)
            {
                Console.WriteLine($"item = {item}");
            }
            linkedList.Remove("Java");
            linkedList.Remove(nodeC);
            linkedList.RemoveFirst();
            linkedList.RemoveLast();
            linkedList.Clear(); // 移除所有节点
        }
    }
}
