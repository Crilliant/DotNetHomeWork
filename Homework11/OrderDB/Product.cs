using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OrderForm
{
    public class Product
    {
        [Key]
        public int ID { get; set; }//primary key
        private static int TotalID = 0;
        
        public string Name { get; set; }
        public float singlePrice { get; set; }
        public DateTime CreateTime { get; set; }
        public Product(string name,float price)
        {
            CreateTime = DateTime.Now;
            ID = ++TotalID;
            Name = name;
            singlePrice = price; 
            AddProduct(this);
            
        }
        private void AddProduct(Product product)
        {
            using (var context = new OrderContext())
            {
                context.Products.Add(product);
            }
        }
        public Product() {
            CreateTime = DateTime.Now;
            ID = ++TotalID;
            AddProduct(this);
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
            return $"[Product {ID}] : {Name}\t[SinglePrice] : {singlePrice}";
        }
    }
}
