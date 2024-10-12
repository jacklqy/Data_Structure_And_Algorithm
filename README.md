# Data_Structure_And_Algorithm
数据结构与算法讲解... 

力扣(算法题网站)：https://leetcode.cn/

http://c.biancheng.net/data_structure/
![image](https://user-images.githubusercontent.com/26539681/147548189-f405f13f-57eb-4949-b98a-10804482f453.png)
![image](https://user-images.githubusercontent.com/26539681/147548147-d051704f-2b24-4043-9ae7-759e23ff544d.png)

```
 数据结构有几类：线性结构、链表、Hash散列

          1.线性结构：在内存中存放的顺序是连续的可以节约空间，可以通过索引查找，优点：查询数据很快、缺点:每次修改删除都有内存的移动会慢。

          2.链表：链表结构在内存中是不连续的，不可以通过索引查找，他在每块内存中除了存放值还存放了下块内存的索引，优点：增删快，缺点查询慢

          3.Hash散列：在内存会连续先开辟一块空间（会造成空间浪费）、它的读取，增删都快（少量数据），但由于是根据hash散列算法查找地址索引的，而且他前面分配的空间不够的话，会造成散列冲突，大数据量的情况下（散列冲突到导致替补收到查询地址）效率会急剧下降
```

在.net对应的数据结构类型有：

          1.线性结构：Array数组（定长）、arrayList(不定长，这里面存放的是object，有类型安全的问题)、List<T>(泛型)

          2.链表：LinkedList<T>双向链表（针对每个内存节点可以操作如：贪吃蛇，令牌环）

                        Queue<T>队列(先进先出，如多线程日志，边删除边打印等）

                        Stack<T>栈(先进后出)

          3.HashSet<T>集合：hash分布、元素间没有关系、动态增加容量、去重（如统计用户、多次提交之生效一次）也可以取得交叉并补集(效率比List高)

          4.SortedSet<T>排序集合：和HashSet 相比是排序的，有去重和排序的特性可以做如：直播打赏排行

          5.Hash散列：Hashtable ：体积可以动态增加 拿着key计算一个地址，然后放入key - value；object-装箱拆箱 如果不同的key得到相同的地址，第二个在前面地址上 + 1；查找的时候，如果地址对应数据的key不对，那就 + 1查找。。；浪费了空间，Hashtable是基于数组实现；查找个数据 一次定位； 增删 一次定位； 增删查改 都很快

                                Dictionary字典：泛型；key - value，增删查改 都很快；有序的

                                SortedDictionary 排序字典

                                SortedList 排序集合

           6.参考文章中的线程安全的数据结构
            ConcurrentQueue 线程安全版本的Queue
            ConcurrentStack线程安全版本的Stack
            ConcurrentBag线程安全的对象集合
            ConcurrentDictionary线程安全的Dictionary
            BlockingCollection


