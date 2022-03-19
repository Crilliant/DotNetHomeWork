using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement
{
    internal class Product
    {
        private static int TotalID = 0;
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime CreateTime { get; set; }
        public Product(string name)
        {
            this.Name = name;
            ID = ++TotalID;
            CreateTime = DateTime.Now;
        }
        public override bool Equals(object obj)
        {
            Product product = obj as Product;
            return product != null &&product.ID == ID;
        }
        public override int GetHashCode()
        {
            return ID;
        }
        public override string ToString()
        {
            return $"[Product {ID}] : {Name}";
        }
    }
}
