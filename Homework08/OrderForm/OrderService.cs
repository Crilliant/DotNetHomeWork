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
         public List<Order> OrderList = new List<Order>();
         
        public void AddOdder(Order o)
        {
            //order 可以添加inValid()判定
            if (o == null) { throw new ApplicationException("null order!"); }
            if(!o.IsValid()) { throw new ApplicationException("invalid order!"); }
            if (OrderList.Contains(o))
                throw new ArgumentException($"Order {o.ID} exists.");//applicationException
            OrderList.Add(o);
        }

        //根据订单号查询order
        public Order GetByID(int orderID)
        {
            return OrderList.Where(order => order.ID == orderID).FirstOrDefault();//转化为Order，返回第一个
        }
        //列出所有订单
        public List<Order> QueryAll()
        {
            return OrderList.OrderBy(o => o.TotalPrice).ToList<Order>();
        }
        public List<Order> QueryAllWithoutSort()
        {
            return OrderList.ToList<Order>();
        }

        //根据用户姓名查询Order, 查询结果按照订单总金额排序从小到大返回
        public List<Order> Query (String customerName)
        {            
            var find = from o in OrderList
                       where o.customer.Name == customerName
                       orderby o.TotalPrice
                       select o;
            return find.ToList();
        }
        //按天查询订单
        public List<Order> Query (DateTime data)
        {
            var find = from o in OrderList
                       where o.DealTime.Date == data.Date
                       orderby o.TotalPrice
                       select o;
            return find.ToList();
        }
           

        //删除某个id的订单
        public void DeleteByID(int id)
        {
            if (GetByID(id) == null)
                throw new ArgumentNullException($"cannot find order {id}");
            OrderList.RemoveAll(x=>x.ID==id);
        }

        //修改 order
        public void Updata(Order o)
        {
            if (o == null) { throw new ApplicationException("null order!"); }
            if (!o.IsValid()) { throw new ApplicationException("invalid order!"); }
            Order orderInList =GetByID(o.ID);
            if(orderInList == null) { throw new ApplicationException($"the order {o.ID} does not exist!"); }
            OrderList.Remove(orderInList);
            OrderList.Add(o);
        }

        //OrderService提供排序方法对保存的订单进行排序。默认按照订单号排序，也可以使用Lambda表达式进行自定义排序。
        public void SortedDictionary(Func<Order, Order, int> func=null)
        {
            if(func==null)
                OrderList.Sort((o1,o2) => o1.ID - o2.ID);
            else
                OrderList.Sort((o1,o2) => func(o1,o2));
        }
        public void Export(string filename)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                xmlSerializer.Serialize(fs, OrderList);
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
                OrderList = list;//Add()
        }


    }
}
