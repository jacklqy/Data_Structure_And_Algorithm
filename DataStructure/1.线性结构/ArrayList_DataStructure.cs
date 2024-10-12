using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DataStructure.线性结构
{
    /// <summary>
    /// ArrayList(不定长，这里面存放的是object，有类型安全的问题)
    /// </summary>
    /// <remarks>
    /// Add()：在集合的末尾添加一个元素。
    /// Remove()：移除集合中的指定元素。
    /// RemoveAt()：移除集合中指定索引处的元素。
    /// Insert()：在指定索引处插入一个元素。
    /// Clear()：移除集合中的所有元素。
    /// Contains()：检查集合中是否包含某个元素。
    /// CopyTo()：将集合中的元素复制到一个数组中。
    /// ToArray()：将集合中的元素转换为一个数组。
    /// </remarks>
    internal class ArrayList_DataStructure
    {
        public void Main()
        {
            ArrayList arrayList = ["Hello", 123];
            //ArrayList arrayList = new ArrayList();
            //arrayList.Add("Hello");
            //arrayList.Add(123);

            foreach (var item in arrayList)
            {
                Console.WriteLine(item.ToString());
            }    
        }
    }
}
