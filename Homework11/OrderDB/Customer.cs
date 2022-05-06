using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OrderForm
{
    public class Customer
    {
        [Key]
        public int ID { get; set; }//primary key
        private static int TotalID=0;
        
        public string Name { get; set; }
        public DateTime CreateTime { get; set; }
        public Customer(string name)
        {
            CreateTime = DateTime.Now;
            ID = ++TotalID;
            Name = name;
            AddCustomer(this);
            
        }
        public Customer()
        {
            CreateTime = DateTime.Now;
            ID = ++TotalID;
            AddCustomer(this);
        }
        private void AddCustomer(Customer customer)
        {
            using (var context = new OrderContext())
            {
                context.Customers.Add(customer);
            }
        }
        public override bool Equals(object obj)
        {
            Customer customer = obj as Customer;
            return customer != null && customer.ID == ID ;
        }
        public override int GetHashCode()
        {
            return ID;
        }
        public override string ToString()
        {
            return $"[Customer {ID}] : {Name}";
        }

    }
}
