using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement
{
    public class Customer
    {
        private static int TotalID=0;
        public int ID { get;set; }
        public string Name { get; set; }
        public DateTime CreateTime { get; set; }
        public Customer(string name)
        {
            this.Name = name;
            ID = ++TotalID;
            CreateTime = DateTime.Now;
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
