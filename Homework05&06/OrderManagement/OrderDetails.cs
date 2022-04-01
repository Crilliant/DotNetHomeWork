using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OrderManagement
{
    public class OrderDetails
    {
        public Product Product { get; set; } 
        public int Number { get; set; }//产品数量
        public double Discount { get; set; }
        public OrderDetails(Product product,int num,double discount)
        {
            this.Product = product;
            Number = num;
            this.Discount = discount;
        }
        public OrderDetails()
        {

        }

        public double TotalPrice{ get { return Product.singlePrice * Number * Discount; } }
        public override string ToString()
        {
            //判断orderDetails是否为空
            return $"Product : {Product.Name} \t" +
                $"Number : {Number} \t" +
                $"Discount : {Discount} \t" +
                $"Total Price :{TotalPrice}";
        }
        public override bool Equals(object obj)
        {
            OrderDetails other = obj as OrderDetails;
            
            return other!=null && this.Number == other.Number 
                && this.Discount == other.Discount
                && this.Product==other.Product;

        }
        public override int GetHashCode()
        {
            if(this.Product==null)throw new ArgumentNullException(nameof(Product));
            return this.Product.GetHashCode() * this.Number;
        }
    }
}
