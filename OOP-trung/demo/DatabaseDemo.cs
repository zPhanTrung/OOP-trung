using Demo_oop.dao;
using Demo_oop.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo_oop.demo
{
    public class DatabaseDemo
    {
        Database instants = Database.Instants();
        public void InsertTableTest()
        {
            instants.InsertTable("product", new Product { Id = 11, Name = "product_insertTest", CategoryId = 10 });
            instants.InsertTable("category", new Category { Id = 11, Name = "product_insertTest" });
            instants.InsertTable("accessotion", new Accessotion { Id = 11, Name = "product_insertTest" });
        }
        public void UdpateTableTest()
        {
            instants.UpdateTable("product", new Product { Id=5, Name="upudateTableTest", CategoryId=1});
            instants.UpdateTable("category", new Category { Id = 5, Name = "upudateTableTest" });
            instants.UpdateTable("accessotion", new Accessotion { Id = 5, Name = "upudateTableTest" });
            instants.UpdateTableById(9, new Product { Name = "updateById", CategoryId = 8 });
            instants.UpdateTableById(9, new Category { Name = "updateById"});
            instants.UpdateTableById(9, new Accessotion { Name = "updateById"});
        }
        public void SelectTableTest()
        {
            
        }
        public void DeleteTableTest()
        {
            instants.DeleteTable("product", 4);
            instants.DeleteTable("category", 4);
            instants.DeleteTable("accessotion", 4);
        }
        public void TruncateTableTest()
        {
            Database.Instants().TruncateTable();
        }

        public void InitDatabase()
        {
            instants.InsertTable("product", new Product{Id=1, Name="product_1", CategoryId=1});
            instants.InsertTable("product", new Product{Id=2, Name="product_2", CategoryId=2});
            instants.InsertTable("product", new Product{Id=3, Name="product_3", CategoryId=3});
            instants.InsertTable("product", new Product{Id=4, Name="product_4", CategoryId=4});
            instants.InsertTable("product", new Product{Id=5, Name="product_5", CategoryId=5});
            instants.InsertTable("product", new Product{Id=6, Name="product_6", CategoryId=2});
            instants.InsertTable("product", new Product{Id=7, Name="product_7", CategoryId=6});
            instants.InsertTable("product", new Product{Id=8, Name="product_8", CategoryId=7});
            instants.InsertTable("product", new Product{Id=9, Name="product_9", CategoryId=8});
            instants.InsertTable("product", new Product{Id=10, Name="product_10", CategoryId=9});

            instants.InsertTable("category", new Category{Id=1, Name="category_1"});
            instants.InsertTable("category", new Category{Id=2, Name="category_2"});
            instants.InsertTable("category", new Category{Id=3, Name="category_3"});
            instants.InsertTable("category", new Category{Id=4, Name="category_4"});
            instants.InsertTable("category", new Category{Id=5, Name="category_5"});
            instants.InsertTable("category", new Category{Id=6, Name="category_6"});
            instants.InsertTable("category", new Category{Id=7, Name="category_7"});
            instants.InsertTable("category", new Category{Id=8, Name="category_8"});
            instants.InsertTable("category", new Category{Id=9, Name="category_9"});
            instants.InsertTable("category", new Category{Id=10, Name="category_10"});

            instants.InsertTable("accessotion", new Accessotion{Id=1, Name="accessotion_1"});
            instants.InsertTable("accessotion", new Accessotion{Id=2, Name="accessotion_2"} );
            instants.InsertTable("accessotion", new Accessotion{Id=3, Name="accessotion_3"} );
            instants.InsertTable("accessotion", new Accessotion{Id=4, Name="accessotion_4"} );
            instants.InsertTable("accessotion", new Accessotion{Id=5, Name="accessotion_5"} );
            instants.InsertTable("accessotion", new Accessotion{Id=6, Name="accessotion_6"} );
            instants.InsertTable("accessotion", new Accessotion{Id=7, Name="accessotion_7"} );
            instants.InsertTable("accessotion", new Accessotion{Id=8, Name="accessotion_8"} );
            instants.InsertTable("accessotion", new Accessotion{Id=9, Name="accessotion_9"} );
            instants.InsertTable("accessotion", new Accessotion{Id=10, Name="accessotion_10"});
        }
        public void PrintTableTest()
        {
            InitDatabase();
            InsertTableTest();
            UdpateTableTest();
            DeleteTableTest();
            //TruncateTableTest();

            var products = instants.GetProductTalbe();
            var categorys = instants.GetCategoryTalbe();
            var accessotions = instants.GetAccessotionTalbe();

            Console.WriteLine("product table");
            foreach (var pro in products)
                Console.WriteLine("id: " + pro.Id + "; name: " + pro.Name + "; categoryId: " + pro.CategoryId);

            Console.WriteLine("category table");
            foreach (var cate in categorys)
               Console.WriteLine("id: " + cate.Id + "; name: " + cate.Name);

            Console.WriteLine("accessotion table");
            foreach (var acc in accessotions)
                Console.WriteLine("id: " + acc.Id + "; name: " + acc.Name);

        }
    }
}