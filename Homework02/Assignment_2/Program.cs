//Assignment 2
//编程求一个整数数组的最大值、最小值、平均值和所有数组元素的和。

using System;
using System.Collections.Generic;
using System.Linq;
namespace Assignment_2
{
    class Program
    {
        List<int> array = new List<int>();
        int min, max, sum;
        void SetArray(List<int> nums)
        {
            if (nums == null)
                throw new NullReferenceException();
            if (!nums.Any())
                throw new ArgumentException();           

            foreach (int i in nums)
            {
                array.Add(i);
            }
        }
        void Parse()
        {
            min =max= array[0];
            foreach(int i in array)
            {
                if (i > max)
                    max = i;
                if (i < min)
                    min = i;
                sum += i;
            }
            
        }

        static void Main(string[] args)
        {
            Program test = new Program();
            List <int>nums=new List<int>{ 1,2,4,5,3,45};
            test.SetArray(nums);
            test.Parse();
            Console.Write($"max = {test.max};\tmin = {test.min};\nsum = {test.sum}\t");
            Console.WriteLine($"averge = {test.sum / test.array.Count()}");
        }
    }
}
