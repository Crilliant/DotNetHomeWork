using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OrderManagement
{
    internal class OrderDetails
    {
        public int ID { get; }//产品id，为主键；初始化后无法改变
        public string ProductName { get; set; }
        public int Number { get; set; }//产品数量
        public double SinglePrice { get; set; }
        public double Discount { get; set; }
        public OrderDetails(int id,string name,int num,double singlePrice)
        {
            ID = id;
            ProductName = name;
            Number = num;
            this.SinglePrice = singlePrice;
        }
        public double TotalPrice{ get { return SinglePrice * Number * Discount; } }
        public override string ToString()
        {
            return $"Product : {ProductName} \t" +
                $"Number : {Number} \t" +
                $"Discount : {Discount} \t" +
                $"Total Price :{TotalPrice}";
        }
        public override bool Equals(object obj)
        {
            OrderDetails other = obj as OrderDetails;
            
            return other!=null && this.ID == other.ID;

        }
        public override int GetHashCode()
        {
            return ID;
        }
    }
}
