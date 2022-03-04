//Assignment 3
//用“埃氏筛法”求2~ 100以内的素数。2~ 100以内的数，先去掉2的倍数，再去掉3的倍数，再去掉4的倍数，以此类推...最后剩下的就是素数
using System;
using System.Collections.Generic;

namespace Assignment_3
{
    public class Prim
    {
        public List<int> PrimTable = new List<int>();

        //将PrimTabel设置为2~max的素数
        public void Eratosthenes(int max)
        {
            PrimTable.Clear();

            List<bool> primCheck = new List<bool>();
            for (int i = 0; i < max; i++)
            {
                primCheck.Add(true);
            }
            for (int i = 2; i < max; i++)
            {
                for (int j = i * i; j < max; j += i)
                {
                    primCheck[j] = false;
                }
            }
            for (int i = 2; i < max; i++)
            {
                if (primCheck[i])
                {
                    PrimTable.Add(i);
                }
            }
        }


        static void Main(string[] args)
        {
            Prim test = new Prim();
            const int n = 100;
            test.Eratosthenes(n);

            foreach (int i in test.PrimTable)
                Console.Write($"{i}\t");

        }
    }
}