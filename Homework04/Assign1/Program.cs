//1、为示例中的泛型链表类添加类似于List<T>类的ForEach(Action<T> action)方法。
//通过调用这个方法打印链表元素，求最大值、最小值和求和（使用lambda表达式实现）。

using System;

namespace Assign1
{
    public class GenericArray<T>
    {
        private T[] array;

        public GenericArray(int size)
        {
            array = new T[size];
        }

        public T getItem(int index)
        {
            return array[index];
        }

        public void setItem(int index, T value)
        {
            array[index] = value;
        }

        //调用 无返回值的T委托
        public void ForEach(Action<T> action)
        {
            foreach(var item in array)
            {
                action(item);
            }
        }
        public void ForEach(Func<T,T> f)
        {
            foreach (var item in array)
            {
                f(item);
            }
        }

    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            GenericArray<int> g = new GenericArray<int>(5);
            g.setItem(0, 0);
            g.setItem(1, 1);
            g.setItem(2, -3);
            g.setItem(3, 35);
            g.setItem(4, 4);

            Action<int> Print=n=>Console.WriteLine(n);
            g.ForEach(Print);

            int sum = 0,min=g.getItem(0),max=g.getItem(0);
            Func<int, int> GetSum = n => sum += n;
            Func<int, int> GetMin = n => min>n?min=n:min;
            Func<int, int> GetMax = n => max > n ? max : max = n;
            g.ForEach(GetSum);
            g.ForEach(GetMax);
            g.ForEach(GetMin);
            Console.WriteLine($"sum={sum},max={max},min={min}");
            

        }
    }
}
