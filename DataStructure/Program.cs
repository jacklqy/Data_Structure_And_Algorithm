using DataStructure.线性结构;
using DataStructure.链表;
using DataStructure.HashSet集合;
using DataStructure.SortedSet排序集合;
using DataStructure.Hash散列;
using DataStructure.线程安全数据结构;

namespace DataStructure
{
    internal class Program
    {
        //******数据结构******
        //1.线性结构：
        //Array数组（定长）
        //arrayList(不定长，这里面存放的是object，有类型安全的问题)
        //List<T>(泛型)

        //2.链表：
        //LinkedList<T> 双向链表（针对每个内存节点可以操作如：贪吃蛇，令牌环）
        //Queue<T> 队列(先进先出，如多线程日志，边删除边打印等）
        //Stack<T> 栈(先进后出)

        //3.HashSet<T> 集合：hash分布、元素间没有关系、动态增加容量、去重（如统计用户、多次提交之生效一次）也可以取得交叉并补集(效率比List高)

        //4.SortedSet<T> 排序集合：和HashSet 相比是排序的，有去重和排序的特性可以做如：直播打赏排行

        //5.Hash散列：
        //Hashtable ：体积可以动态增加 拿着key计算一个地址，然后放入key - value；object-装箱拆箱 如果不同的key得到相同的地址，第二个在前面地址上 + 1；查找的时候，如果地址对应数据的key不对，那就 + 1查找。。；浪费了空间，Hashtable是基于数组实现；查找个数据 一次定位； 增删 一次定位； 增删查改 都很快
        //Dictionary字典：泛型；key - value，增删查改 都很快；有序的
        //SortedDictionary 排序字典
        //SortedList 排序集合

        // 6.线程安全的数据结构
        // ConcurrentQueue 线程安全版本的Queue
        // ConcurrentStack线程安全版本的Stack
        // ConcurrentBag线程安全的对象集合
        // ConcurrentDictionary线程安全的Dictionary
        // BlockingCollection
        static void Main(string[] args)
        {
            #region 1.线性结构

            //Array数组（定长）
            var array = new Array_DataStructure();
            array.Main();

            //ArrayList(不定长，这里面存放的是object，有类型安全的问题)
            var arrayList = new ArrayList_DataStructure();
            arrayList.Main();

            //List<T>(泛型)
            var list = new List_DataStructure();
            list.Main();

            #endregion

            #region 2.链表

            //LinkedList<T> 双向链表（针对每个内存节点可以操作如：贪吃蛇，令牌环）
            var linkedList = new LinkedList_DataStructure();
            linkedList.Main();

            //Queue<T> 队列(先进先出，如多线程日志，边删除边打印等）
            var queue = new Queue_DataStructure();
            queue.Main();

            //Stack<T> 栈(先进后出)
            var stack = new Stack_DataStructure();
            stack.Main();

            #endregion

            #region 3.HashSet集合

            //HashSet<T> 集合：hash分布、元素间没有关系、动态增加容量、去重（如统计用户、多次提交之生效一次）也可以取得交叉并补集(效率比List高)
            var hashSet = new HashSet_DataStructure();
            hashSet.Main();

            #endregion

            #region 4.SortedSet排序集合

            //SortedSet<T> 排序集合：和HashSet 相比是排序的，有去重和排序的特性可以做如：直播打赏排行
            var sortedSet = new SortedSet_DataStructure();
            sortedSet.Main();

            #endregion

            #region 5.Hash散列

            //Hashtable ：体积可以动态增加 拿着key计算一个地址，然后放入key - value；object-装箱拆箱 如果不同的key得到相同的地址，第二个在前面地址上 + 1；查找的时候，如果地址对应数据的key不对，那就 + 1查找。。；浪费了空间，Hashtable是基于数组实现；查找个数据 一次定位； 增删 一次定位； 增删查改 都很快
            var hashtable = new Hashtable_DataStructure();
            hashtable.Main();

            //Dictionary字典：泛型；key - value，增删查改 都很快；有序的
            var dictionary = new Dictionary_DataStructure();
            dictionary.Main();

            //SortedDictionary 排序字典
            var sortedDictionary = new SortedDictionary_DataStructure();
            sortedDictionary.Main();

            //SortedList 排序集合
            var sortedList = new SortedList_DataStructure();
            sortedList.Main();

            #endregion

            #region 6.线程安全数据结构

            //ConcurrentQueue 线程安全版本的Queue
            var concurrentQueue = new ConcurrentQueue_DataStructure();
            concurrentQueue.Main();

            //ConcurrentStack线程安全版本的Stack
            var concurrentStack = new ConcurrentStack_DataStructure();
            concurrentStack.Main();

            //ConcurrentBag线程安全的对象集合
            var concurrentBag = new ConcurrentBag_DataStructure();
            concurrentBag.Main();

            //ConcurrentDictionary线程安全的Dictionary
            var concurrentDictionary = new ConcurrentDictionary_DataStructure();
            concurrentDictionary.Main();

            //
            var blockingCollection = new BlockingCollection_DataStructure();
            blockingCollection.Main();
            #endregion
        }
    }
}
