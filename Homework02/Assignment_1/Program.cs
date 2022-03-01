//assignment 1
using System;
using System.Collections.Generic;

namespace Assignment_1
{
    class Program
    {
        List<int> GetPrimFact(int n)
        {
            List<int> ans = new List<int>();
            Assignment_3.Prim prim = new Assignment_3.Prim();
            prim.Eratosthenes(n);
            foreach(int item in prim.PrimTable)
            {
                if (n % item == 0)
                    ans.Add(item);
            }
            return ans;
        }
        static void Main(string[] args)
        {
            int n = 134;
            Program test = new Program();
            List<int> primFact = test.GetPrimFact(n);
            foreach (int i in primFact)
                Console.Write($"{i}\t");
        }
    }
}
