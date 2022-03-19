using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OrderManagement
{
    internal class Order
    //对应多个OderDetails,
    {
        private static int TotalID = 0;
        public List<OrderDetails> details;
        public int ID { get; }
        public DateTime DealTime { get; }
        public Customer customer { get; set; }
        public double Price { get; set; }
        public double TotalPrice
        {
            get { return details.Sum(x => x.TotalPrice); }
        }
        //enum dealWays   {cash,card};  //付款方式
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
            s.Append($"total price : {TotalPrice}\tCustomer : {customer}");
            return s.ToString();
        }

        //增加条目
        public void AddDetail(OrderDetails detail)
        {
            if (details.Exists(x => x.Equals(detail)))
            {
                throw new ArgumentException($"Detail {detail.ID} exists.");
            }
            details.Add(detail);
        }
    }
}
