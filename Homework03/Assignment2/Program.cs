//Assignment2
//随机创建10个形状对象，计算这些对象的面积之和。 尝试使用简单工厂设计模式来创建对象。

using System;
using Assignment1;
using System.Collections.Generic;

namespace Assignment2
{
    public class Factory
    {
        private static int shapeNum = 3;//可生成的形状种类
        public Factory(int max,int min)
        {
            maxLength = max;
            minLength = min;
        }

        //形状最大边长默认为20，最小边长默认为1；
        public static int maxLength{ get;set;} = 20;
        public static int minLength { get; set; } = 1;
        Rectangle CreateRctangle()
        {
            Random random = new Random();
            int width = random.Next(minLength,maxLength);
            int height = random.Next(minLength, maxLength);
            return new Rectangle(width, height);
        }
        Square CreateSquare()
        {
            Random random = new Random();
            int side = random.Next(minLength, maxLength);
            return new Square(side);
        }
        Triangle CreateTriangle()
        {
            Random random = new Random();
            while (true)
            {
                int l1 = random.Next(minLength, maxLength), 
                    l2 = random.Next(minLength, maxLength),
                    l3 = random.Next(minLength, maxLength);
                if (l1 <= 0 || l2 <= 0 || l3 <= 0)
                    continue;
                else if (l1 + l2 <= l3 || l1 + l3 <= l2 || l2 + l3 <= l1)
                    continue;
                else
                    return new Triangle(l1, l2, l3);;
            }            
        }
        public object CreateRandShape()
        {
            Random random = new Random();
            int type=random.Next(1,shapeNum);
            switch (type)
            {
                case 0:
                    return CreateRctangle();
                case 1: 
                    return CreateSquare();
                default://2
                    return CreateTriangle();                
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Object> shapesList = new List<Object>();
            Console.WriteLine("How many shapes do you want?");//10
            int amount;
            Factory factory = new Factory(10,1);//最大边长为10

            try
            {              
                int.TryParse(Console.ReadLine(), out amount);
            }catch(Exception e)
            {
                throw new Exception("Invalid input.");
            }

            //创建shape列表
            for(int i=0; i < amount; i++)
            {
                shapesList.Add(factory.CreateRandShape());
            }

            double areaSum = 0;
            Console.WriteLine("We have created these shapes:");
            foreach(Shape shape in shapesList)
            {
                Console.WriteLine($"{shape.GetType()}");
                areaSum += shape.GetArea();
            }
            Console.WriteLine("The sum of their area is {0}", areaSum);


        }
    }
}
