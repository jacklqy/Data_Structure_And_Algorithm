using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.链表
{
    /// <summary>
    /// Stack<T>栈(先进后出)
    /// </summary>
    /// ‌Stack是.NET中的一个类，代表了一个后进先出的对象集合。‌ 它主要用于存储数据，其中最后添加的元素会被首先移除。Stack类提供了Push、Pop和Peek等方法来操作数据。
    /// Stack的基本用法包括以下几个步骤：
    ///     实例化Stack对象‌：通过new Stack<T>()创建一个Stack对象，其中T是存储元素的类型。
    ///     添加元素‌：使用Push方法将元素添加到Stack的顶部。
    ///     移除元素‌：使用Pop方法移除并返回Stack顶部的元素。
    ///     查看顶部元素‌：使用Peek方法查看Stack顶部的元素但不移除它。
    /// 以下是一个简单的示例代码，演示如何在C#中使用Stack类：
    internal class Stack_DataStructure
    {
        public void Main()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine("顶部元素: " + stack.Peek()); // 输出: 3
            Console.WriteLine("移除元素: " + stack.Pop()); // 输出: 3
            Console.WriteLine("现在顶部元素: " + stack.Peek()); // 输出: 2
        }
    }
}
