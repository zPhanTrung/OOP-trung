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
        public void InsertTableTest()
        {
            Database.Instants().InsertTable("product",
                new Dictionary<string, string>() { { "id", "11" }, { "name", "newProduct" } });
            Database.Instants().InsertTable("category",
                new Dictionary<string, string>() { { "id", "11" }, { "name", "newCategory" } });
            Database.Instants().InsertTable("accessotion",
                new Dictionary<string, string>() { { "id", "11" }, { "name", "newAccessotion" } });
        }
        public void UdpateTableTest()
        {
            Database.Instants().UpdateTable("product",
                new Dictionary<string, string>() { { "id", "1" }, { "nameColumn", "name" },{ "value", "product_updated" } });
            Database.Instants().UpdateTableById(4, 
                new Dictionary<string, string>(){ { "table","product" },{"name","update_by_id" } });
        }
        public void SelectTableTest()
        {
            Database.Instants().SelectTable("product",
                new Dictionary<string, string>() { { "value", "5" }, { "operator", "gt" }, { "name", "id" } });
        }
        public void DeleteTableTest()
        {
            Database.Instants().DeleteTable("product", 
                new Dictionary<string, string>() { { "id", "3"} });
        }
        public void TruncateTableTest()
        {
            Database.Instants().TruncateTable();
        }

        public void InitDatabase()
        {
            var instant = Database.Instants();
            instant.InsertTable("product", new Dictionary<string, string>() { { "id", "1" }, { "name", "product_1" } });
            instant.InsertTable("product", new Dictionary<string, string>() { { "id", "2" }, { "name", "product_2" } });
            instant.InsertTable("product", new Dictionary<string, string>() { { "id", "3" }, { "name", "product_3" } });
            instant.InsertTable("product", new Dictionary<string, string>() { { "id", "4" }, { "name", "product_4" } });
            instant.InsertTable("product", new Dictionary<string, string>() { { "id", "5" }, { "name", "product_5" } });
            instant.InsertTable("product", new Dictionary<string, string>() { { "id", "6" }, { "name", "product_6" } });
            instant.InsertTable("product", new Dictionary<string, string>() { { "id", "7" }, { "name", "product_7" } });
            instant.InsertTable("product", new Dictionary<string, string>() { { "id", "8" }, { "name", "product_8" } });
            instant.InsertTable("product", new Dictionary<string, string>() { { "id", "9" }, { "name", "product_9" } });
            instant.InsertTable("product", new Dictionary<string, string>() { { "id", "10" }, { "name", "product_10" } });

            instant.InsertTable("category", new Dictionary<string, string>() { { "id", "1" }, { "name", "category_1" } });
            instant.InsertTable("category", new Dictionary<string, string>() { { "id", "2" }, { "name", "category_2" } });
            instant.InsertTable("category", new Dictionary<string, string>() { { "id", "3" }, { "name", "category_3" } });
            instant.InsertTable("category", new Dictionary<string, string>() { { "id", "4" }, { "name", "category_4" } });
            instant.InsertTable("category", new Dictionary<string, string>() { { "id", "5" }, { "name", "category_5" } });
            instant.InsertTable("category", new Dictionary<string, string>() { { "id", "6" }, { "name", "category_6" } });
            instant.InsertTable("category", new Dictionary<string, string>() { { "id", "7" }, { "name", "category_7" } });
            instant.InsertTable("category", new Dictionary<string, string>() { { "id", "8" }, { "name", "category_8" } });
            instant.InsertTable("category", new Dictionary<string, string>() { { "id", "9" }, { "name", "category_9" } });
            instant.InsertTable("category", new Dictionary<string, string>() { { "id", "10" }, { "name", "category_10" } });

            instant.InsertTable("accessotion", new Dictionary<string, string>() { { "id", "1" }, { "name", "accessotion_1" } });
            instant.InsertTable("accessotion", new Dictionary<string, string>() { { "id", "2" }, { "name", "accessotion_2" } });
            instant.InsertTable("accessotion", new Dictionary<string, string>() { { "id", "3" }, { "name", "accessotion_3" } });
            instant.InsertTable("accessotion", new Dictionary<string, string>() { { "id", "4" }, { "name", "accessotion_4" } });
            instant.InsertTable("accessotion", new Dictionary<string, string>() { { "id", "5" }, { "name", "accessotion_5" } });
            instant.InsertTable("accessotion", new Dictionary<string, string>() { { "id", "6" }, { "name", "accessotion_6" } });
            instant.InsertTable("accessotion", new Dictionary<string, string>() { { "id", "7" }, { "name", "accessotion_7" } });
            instant.InsertTable("accessotion", new Dictionary<string, string>() { { "id", "8" }, { "name", "accessotion_8" } });
            instant.InsertTable("accessotion", new Dictionary<string, string>() { { "id", "9" }, { "name", "accessotion_9" } });
            instant.InsertTable("accessotion", new Dictionary<string, string>() { { "id", "10" }, { "name", "accessotion_10" } });


        }
        public void PrintTableTest()
        {
            InitDatabase();
            UdpateTableTest();
            DeleteTableTest();
            //TruncateTableTest();

            var products = Database.Instants().GetProductTalbe();
            var categorys = Database.Instants().GetCategoryTalbe();
            var accessotions = Database.Instants().GetAccessotionTalbe();

            Console.WriteLine("product table");
            foreach (var item in products)
            {
                
                Console.Write(item.id + "   ");
                Console.WriteLine(item.name);
            }

            Console.WriteLine("category table");
            foreach (var item in categorys)
            {
                
                Console.Write(item.id + "   ");
                Console.WriteLine(item.name);
            }

            Console.WriteLine("accessotion table");
            foreach (var item in accessotions)
            {
                Console.Write(item.id + "   ");
                Console.WriteLine(item.name);
            }


        }
    }
}