using System;
using System.Collections.Generic;

namespace OrderManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            Product apple, banana, cat;
            Customer Ada, Rick;
            Order order1, order2, order3;
            OrderService service;
            apple = new Product("apple", 1.5f);
            banana = new Product("banana", 2.3f);
            cat = new Product("cat", 50);
            Ada = new Customer("Ada");
            Rick = new Customer("Rick");
            service = new OrderService();

            service = new OrderService();
            List<OrderDetails> details1 = new List<OrderDetails>();
            List<OrderDetails> details2 = new List<OrderDetails>();
            List<OrderDetails> details3 = new List<OrderDetails>();
            try
            {
                
                details1.Add(new OrderDetails(apple, 2, 1));
                order1 = new Order(details1, Ada);
                service.AddOdder(order1);
               
            }
            catch (Exception ex)
            {
                Console.WriteLine("1" + ex.Message);
            }

            try
            {
                details2.Add(new OrderDetails(apple, 8, 0.88));
                details2.Add(new OrderDetails(banana, 10, 0.6));
                order2 = new Order(details2, Rick);
                service.AddOdder(order2);
            }
            catch (Exception ex)
            {
                Console.WriteLine ("2" + ex.Message);
            }

            try
            {
                details3.Add(new OrderDetails(cat, 1, 1));
                order3 = new Order(details3, Rick);
                service.AddOdder(order3);
            }
            catch(Exception ex)
            {
                Console.WriteLine ($"3" + ex.Message);
            }

            //Order o = service.GetByID(1);
            //Console.WriteLine(o.ToString());
            service.SortedDictionary();
            int[] expect = new int[] { 3, 2, 1 };
            int i = 0;
            foreach (Order o in service.QueryAllWithoutSort())
            {
                Console.WriteLine($"{o.ID}, {expect[i]}\n");
                i++;
            }

        }
    }
}
