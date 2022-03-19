using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OrderManagement
{
    internal class OrderService
    {
        List<Order> orders;
        public OrderService()
        {
            orders = new List<Order>();
        }
        public void AddOdder(Order o)
        {
            if (orders.Contains(o))
                throw new ArgumentException($"Order {o.ID} exists.");
            orders.Add(o);
        }

        //根据订单号/用户姓名查询Order,使用LINQ语言实现各种查询功能，查询结果按照订单总金额排序返回
        public IEnumerable<Order>Query(string customerName=null)
        {            
                return from o in orders
                       where o.customer.Name == customerName
                       orderby o.TotalPrice
                       select o;           
        }
        public IEnumerable<Order>Query(DateTime data)
        {
            return from o in orders
                   where o.DealTime == data
                   orderby o.TotalPrice
                   select o;
        }
            

        //根据订单号查询order
        public Order Get(int orderID )
        {
            return orders.Where(order=>order.ID==orderID).FirstOrDefault();//转化为Order，返回第一个
        }
        //删除某个id的订单
        public void DeleteByID(int id)
        {
            if(!orders.Exists(s=>s.ID == id))
            {
                throw new ArgumentException($"Order {id} does not exist.");
            }
            orders.RemoveAt(id);
        }
        //修改

        //OrderService提供排序方法对保存的订单进行排序。默认按照订单号排序，也可以使用Lambda表达式进行自定义排序。
        public void SortedDictionary(Func<Order, Order, int> func=null)
        {
            if(func==null)
                orders.Sort((o1,o2) => { return o1.ID - o2.ID; });
            else
                orders.Sort((o1,o2) =>func(o1,o2));
        }

    }
}
