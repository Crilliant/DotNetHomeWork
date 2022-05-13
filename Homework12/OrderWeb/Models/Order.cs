using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OrderWeb.Models
{
    public class Order
    //对应多个OderDetails,
    {
        private static int TotalID = 0;
        List<OrderDetails> details=new List<OrderDetails>();//集合建议都初始化
        public int ID { get; set; }
        public DateTime DealTime { get; }
        public Customer customer { get; set; }
        public double Price { get; set; }
        public bool IsValid()
        {
            return ID != 0 && customer != null && details.Count > 0;
        }
        public double TotalPrice
        {
            get { return details.Sum(x => x.TotalPrice); }
            //get=>details.sum()
        }
        public Order(List<OrderDetails> od, Customer customer)
        {
            this.customer = customer;
            DealTime = DateTime.Now;
            ID = ++TotalID;
            details = new List<OrderDetails>();
            foreach (OrderDetails i in od)
            {
                details.Add(i);
            }
        }
        public Order() { }

        public override bool Equals(object obj)
        {
            Order other = obj as Order;
            return other != null && this.ID == other.ID;
        }
        public override int GetHashCode()
        {
            return ID;
        }
        public override string ToString()
        {
            StringBuilder s = new StringBuilder($"========\nOderID : {ID}\nDealTime :\t{DealTime}\n");
            foreach (OrderDetails details in details)
            {
                s.Append(details.ToString());
            }
            s.Append($"\ntotal price : {TotalPrice}\tCustomer : {customer}");
            return s.ToString();
        }

        //增加条目
        public void AddDetail(OrderDetails detail)
        {
            if (details.Exists(x => x.Equals(detail)))//if(details.Contains(detail)
            {
                throw new ArgumentException($"Detail {detail} exists.");
            }
            details.Add(detail);
        }
    }
}
