// See https://aka.ms/new-console-template for more information


using Demo_oop.demo;
using Demo_oop.entity;
using OOP_trung.dao;


//product demo
Console.WriteLine("Product demo");
ProductDemo productDemo = new ProductDemo();
productDemo.CreateProductTest();
if (productDemo.product != null)
    productDemo.PrintProduct(productDemo.product);

//database demo
DatabaseDemo databaseDemo = new DatabaseDemo();
databaseDemo.PrintTableTest();



//categoryDAO
Console.WriteLine("CategoryDao Test");
Category category = new Category { Id = 12, Name = "categoryDAO_Test" };
CategoryDAO categoryDao = new CategoryDAO();
Console.WriteLine(categoryDao.Insert(category));
