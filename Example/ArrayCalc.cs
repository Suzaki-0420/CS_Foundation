using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example
{
    public class ArrayCalc
    {

        /// <summary>
        /// 配列が保持する値の合計を計算して返す
        /// </summary>
        /// <param name="values">整数配列</param>
        /// <returns>合計</returns>
        public int Summarize(int[] values)
        {
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"values[{i}]={values[i]}");
                sum += values[i];
            }
            Console.WriteLine("終了");
            return sum;
        }
    }
    
}