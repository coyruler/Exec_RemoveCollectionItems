using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{/// 在集合中移除多個項目
    internal class Program
    {
        static void Main(string[] args)
        {
            // 在集合中移除多個項目
            int[] source = { 3, 5, 7, 9, 11, 13 };
            int[] target = { 7, 11, 99 };
            // TODO result應該是{3,5,9,13}
            var result = source.Except(target).ToList();
            
            string list = string.Join(", ", result);
            string msg = $"{{ 3,5,7,9,11,13}} 移除 {{ 7, 11, 99 }} 的結果為 {list}";
            Console.WriteLine(msg);
        }
    }
}
