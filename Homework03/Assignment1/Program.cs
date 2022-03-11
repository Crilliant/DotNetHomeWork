//编写面向对象程序实现长方形、正方形、三角形等形状的类。每个形状类都能计算面积、判断形状是否合法。
//请尝试合理使用接口/抽象类、属性来实现。

using System;

namespace Assignment1
{
    public interface Shape
    {
        bool IsValidShape();    
        double GetArea();   //使用属性更加合理 double Area{get;} string Info{get;}
    }
    public class Rectangle:Shape
    {
        private readonly int width, height;        
        public Rectangle(int width,int height)
        {
            if (width < 0 || height < 0)
                throw new ArgumentException("Invalid width or height.");
            this.width = width;
            this.height = height;
        }
        //public width{get;set;}//防止square
        public bool IsValidShape()
        {
            if(width>0&&height>0)
                return true;    
            return false;
        }
        public double GetArea()
        {
            if (!IsValidShape())
                throw new Exception("Invalid width or height.");
            return width*height;
        }
    }
    public class Square : Rectangle
    {
        private int side;
        public Square(int side):base(side,side)
        {
            if (side < 0) throw new ArgumentException("Invalid side.");
            this.side = side;
        }
        new public bool IsValidShape()
        {
            if(side>0)return true;
            else return false;  
        }
        new public double GetArea()
        {
            if(!IsValidShape())
                throw new ArgumentException("Invalid side.");

            return side *side;
        }
    }
    public class Triangle : Shape
    {
    //public double[]Egdes{get;set;}=new double[3]; //属性写成public，字段private       
    int line1,line2,line3;
        public Triangle(int l1, int  l2, int l3)
        {
            if (l1<=0||l2<=0||l3<=0||l1 + l2 <= l3 || l1 + l3 <= l2 || l2 + l3 <= l1)
                throw new ArgumentException("Invalid line length.");
            line1 = l1;
            line2 = l2;
            line3 = l3;
        }
        public bool IsValidShape (){
            if (line1 <= 0 || line2 <= 0 || line3 <= 0
                || line1 + line2 <= line3
                || line1 + line3 <= line2
                || line2 + line3 <= line1)
                return false;
            return true;    
        }
        public double GetArea()
        {
            //Heron's formula
            double s=(line1+line2+line3)/2;
            return Math.Sqrt(s * (s - line1) * (s - line2) * (s - line3));
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
