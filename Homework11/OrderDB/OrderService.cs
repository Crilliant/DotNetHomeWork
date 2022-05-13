using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Xml.Serialization;
using System.IO;

namespace OrderForm
{
    [Serializable]
    public class OrderService
    {
        
        public void AddOdder(Order o)
        {
            //order 可以添加inValid()判定
            if (o == null) { throw new ApplicationException("null order!"); }
            if(!o.IsValid()) { throw new ApplicationException("invalid order:"+o.ToString()); }
           
            using (var context=new OrderContext())
            {
                //if (context.Orders.Contains(o))
                //{
                //    throw new ArgumentException($"Order {o.ID} exists.");//applicationException

                //}
                context.Orders.Add(o);
                context.SaveChanges();
            }
            
        }

        //根据订单号查询order
        public Order GetByID(int orderID)
        {
            using (var context = new OrderContext())
            {
                var order = context.Orders.FirstOrDefault(o => o.ID == orderID);
                return order;
            }

            
        }
        //列出所有订单
        public List<Order> QueryAll()
        {
            using(var context = new OrderContext())
            {
                return context.Orders.ToList();
            }
        }
        public List<Order> QueryAllWithoutSort()
        {
            using(var context = new OrderContext())
            {
                var orders = context.Orders.OrderBy(o=>o.ID);
                return orders.ToList();
            }
        }

        //根据用户姓名查询Order, 查询结果按照订单总金额排序从小到大返回
        public List<Order> Query (String customerName)
        {
            using (var context = new OrderContext())
            {
                var query = context.Orders
                    .Where(o => o.customer.Name == customerName)
                    .OrderBy(o => o.TotalPrice);
                return query.ToList();   
            }
        }
        //按天查询订单
        public List<Order> Query (DateTime data)
        {
            using (var context = new OrderContext())
            {
                var query = context.Orders
                    .Where(o => o.DealTime.Date == data.Date)
                    .OrderBy(o => o.TotalPrice);
                return query.ToList();
            }            
        }
           

        //删除某个id的订单
        public void DeleteByID(int id)
        {
            if (GetByID(id) == null)
                throw new ArgumentNullException($"cannot find order {id}");

            using (var context =new OrderContext())
            {
                var order=context.Orders.FirstOrDefault(o => o.ID == id);
                context.Orders.Remove(order);// todo:需要同时删除丁订单明细
                context.SaveChanges();
            }
            
            
        }

        //修改 order
        public void Updata(Order o)
        {
            if (o == null) { throw new ApplicationException("null order!"); }
            if (!o.IsValid()) { throw new ApplicationException("invalid order!"); }
            
            using(var context = new OrderContext())
            {
                var order=context.Orders.FirstOrDefault(od=>od.ID==o.ID);
                if (order == null) { throw new ApplicationException($"the order {o.ID} does not exist!"); }
                context.Orders.Remove(order);
                context.Orders.Add(o);
                context.SaveChanges();
            }
        }


        public void Export(string filename)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                using(var context=new OrderContext())
                {
                    var OrderList=context.Orders.ToList();
                    xmlSerializer.Serialize(fs, OrderList);
                }               
            }            
        }
        //应该考虑无效路径，导入失败需要收集
        public void Import(string filename)
        {

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            List<Order> list;
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                list = xmlSerializer.Deserialize(fs) as List<Order>;
            }
            if(list == null) 
                throw new FileLoadException("invalid path");
            else
            {
                using(var context= new OrderContext())
                {
                    context.Orders.RemoveRange(QueryAll());
                    
                    foreach (var o in list)
                    {
                        AddOdder(o);
                    }
                }
            }
        }


    }
}
