using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Demo_oop.entity;

namespace Demo_oop.demo
{
    public class ProductDemo
    {
        public Product? product { get; set; }
        public void CreateProductTest()
        {
            product = new Product() { Id = 1, Name="productTest", CategoryId = 1 };
        }
        public void PrintProduct(Product product)
        {
            Console.WriteLine("id: " + product.Id + "; name: " + product.Name + "; categoryId: " + product.CategoryId);
        }
    }
}