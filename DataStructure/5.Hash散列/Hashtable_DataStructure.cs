using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Hash散列
{
    /// <summary>
    /// Hashtable ：体积可以动态增加 拿着key计算一个地址，然后放入key - value；object-装箱拆箱 如果不同的key得到相同的地址，第二个在前面地址上 + 1；查找的时候，如果地址对应数据的key不对，那就 + 1查找。。；浪费了空间，Hashtable是基于数组实现；查找个数据 一次定位； 增删 一次定位； 增删查改 都很快
    /// </summary>
    /// 在.NET中，Hashtable是一个用于存储键值对的集合，其中键用于快速查找，且键是区分大小写的。‌ Hashtable中的键值对均为object类型，因此可以支持任何类型的键值对。
    /// ‌添加键值对‌：使用Add方法，例如HashtableObject.Add(key, value);
    /// ‌移除键值对‌：使用Remove方法，例如HashtableObject.Remove(key);
    /// 清空所有元素‌：使用Clear方法，例如HashtableObject.Clear();
    /// 判断是否包含某个键‌：使用ContainsKey方法，例如HashtableObject.ContainsKey(key);
    /// 判断是否包含某个值‌：使用ContainsValue方法，例如HashtableObject.ContainsValue(value);
    internal class Hashtable_DataStructure
    {
        public void Main()
        {
            Hashtable ht = new Hashtable(); // 创建一个Hashtable实例
            ht.Add("北京", "帝都"); // 添加键值对
            ht.Add("上海", "魔都");
            ht.Add("广州", "省会");
            ht.Add("深圳", "特区");
            ht.Add("key1", new Person { name = "jack", age = 18 });

            string capital = (string)ht["北京"]; // 通过键获取值
            Console.WriteLine(capital); // 输出: 帝都

            //遍历键
            foreach (int key in ht.Keys)
            {
                Console.WriteLine(key);
            }

            //遍历值
            foreach (string value in ht.Values)
            {
                Console.WriteLine(value);
            }
        }
    }

    public class Person
    {
        public string name;

        public int age;
    }
}
