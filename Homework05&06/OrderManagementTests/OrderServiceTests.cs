using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderManagement;
using System;
using System.Collections.Generic;
using System.Text;
using OrderManagement;

namespace OrderManagement.Tests
{
    [TestClass]
    public class OrderServiceTests
    {
        Product apple, banana, cat;
        Customer Ada, Rick;
        Order order1, order2, order3, order4;//ordr4 is null      
        OrderService service;

        [TestInitialize]
        public void InitialTest()
        {
            apple = new Product("apple", 1.5f);
            banana = new Product("banana", 2.3f);
            cat = new Product("cat", 50);
            Ada = new Customer("Ada");
            Rick = new Customer("Rick");
            service = new OrderService();

            List<OrderDetails> details1 = new List<OrderDetails>();//3
            details1.Add(new OrderDetails(apple, 2, 1));
            //details1.Add(new OrderDetails(banana, 4, 0.8));
            order1 = new Order(details1, Ada);

            List<OrderDetails> details2 = new List<OrderDetails>();//24.36
            details2.Add(new OrderDetails(apple, 8, 0.88));
            details2.Add(new OrderDetails(banana, 10, 0.6));
            order2 = new Order(details2, Rick);

            List<OrderDetails> details3 = new List<OrderDetails>();
            details3.Add(new OrderDetails(cat, 1, 1));
            order3 = new Order(details3, Rick);

            service = new OrderService();
            service.AddOdder(order1);
            service.AddOdder(order2);
            service.AddOdder(order3);
        }
        [TestMethod()]
        public void GetByIDTest()
        {
            Order o = service.GetByID(1);
            Assert.AreEqual(order1, o);
        }

        [TestMethod()]
        public void GetByIDTest1()
        {
            Assert.IsNull(service.GetByID(10));
        }
        [TestMethod()]
        public void QueryAllTest()
        {
           //不会写
        }

        [TestMethod()]
        public void QueryTest()
        {
            var test = service.Query("Ada");
            List<Order> expect = new List<Order> { order1 };
            CollectionAssert.AreEqual(test,expect);
            //Assert.AreEqual()不行？
        }

        [TestMethod()]
        public void QueryTest1()
        {           
            List<Order> expect = new List<Order>();
            expect.Add(order1);
            expect.Add(order2);
            expect.Add(order3);
            CollectionAssert.AreEquivalent(expect, service.Query(DateTime.Now));
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DeleteByIDTest()
        {
            service.DeleteByID(10);
        }

        [TestMethod()]
        [ExpectedException(typeof(ApplicationException))]
        public void UpdataTest1()
        {
            service.Updata(order4);//order4 is null
        }
        [TestMethod()]
        [ExpectedException(typeof(ApplicationException))]
        public void UpdataTest2()
        {
            order4 = new Order(new List<OrderDetails> { new OrderDetails(apple, 3, 1) }, null);
            service.Updata(order4);//invalid customer name
        }
        [TestMethod()]
        [ExpectedException(typeof(ApplicationException))]
        public void UpdataTest3()
        {
            order4 = new Order(new List<OrderDetails> { new OrderDetails(apple, 3, 1) }, Ada);
            service.Updata(order4);//invalid order id
        }
        [TestMethod()]
        public void UpdataTest4()
        {
            order4 = new Order(new List<OrderDetails> { new OrderDetails(apple, 3, 1) }, Ada);
            order4.ID = 2;
            service.Updata(order4);
            Assert.AreEqual(service.GetByID(2), order4);
        }
        [TestMethod()]
        public void SortedDictionaryTest()//按照价格排序订单
        {
            service.SortedDictionary();
            int []expect = new int[] { 1,2,3 };
            int i = 0;
            foreach(Order o in service.QueryAllWithoutSort())
            {                
                Assert.AreEqual((int)o.ID, expect[i]);
                i++;
            }
        }


    }
}