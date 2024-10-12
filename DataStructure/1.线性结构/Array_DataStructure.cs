using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.线性结构
{
    /// <summary>
    /// Array数组（定长）
    /// </summary>
    internal class Array_DataStructure
    {
        public void Main()
        {
            int[] numbers = { 3, 1, 4, 1, 5, 9, 2, 6 };
            // numbers 现在按升序排列：1, 1, 2, 3, 4, 5, 6, 9
            Array.Sort(numbers);
            
            foreach (var item in numbers)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
