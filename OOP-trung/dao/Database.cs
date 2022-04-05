using Demo_oop.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace Demo_oop.dao
{

    public class Database
    {
        private static Database instants = null;
        List<Product> productTable = new List<Product>();
        List<Category> categoryTable = new List<Category>();
        List<Accessotion> accessoryTable = new List<Accessotion>();


        //
        public static Database Instants()
        {
            if(instants == null)
            {
               instants = new Database();
                return instants;
            }
            return instants;
        }
        public void InsertTable(string name, Dictionary<string, string> row)
        {
            if (name == "product")
            {
                Product pro = new Product();
                pro.id = int.Parse(row["id"]);
                pro.name = row["name"];
                productTable.Add(pro);
            }
            else if (name == "category")
            {
                Category cate = new Category();
                cate.id = int.Parse(row["id"]);
                cate.name = row["name"];
                categoryTable.Add(cate);
            }
            else if (name == "accessotion")
            {
                Accessotion acc = new Accessotion();
                acc.id = int.Parse(row["id"]);
                acc.name = row["name"];
                accessoryTable.Add(acc);
            }
        }
        public void SelectTable(string name, Dictionary<string, string> where)
        {
           
            if (name == "product")
            {
                var res = SelectProductTable(where);
                foreach(var item in res)
                {
                    Console.WriteLine(item.id);
                    Console.WriteLine(item.name);
                }
                
            }
            else if (name == "category")
            {
                var res = SelectProductTable(where);
                foreach (var item in res)
                {
                    Console.WriteLine(item.id);
                    Console.WriteLine(item.name);
                }
            }
            else if (name == "accessotion")
            {
                var res = SelectProductTable(where);
                foreach (var item in res)
                {
                    Console.WriteLine(item.id);
                    Console.WriteLine(item.name);
                }
            }

        }

        public void UpdateTable(string name, Dictionary<string, string> row)
        {
            int id = int.Parse(row["id"]);
            string nameColumn = row["nameColumn"];
            string value = row["value"];

            if(name=="product")
            {
                foreach(Product p in productTable)
                {
                    if (p.id == id)
                    {
                        if(nameColumn=="name")
                        {
                            p.name = value;
                        }   
                    }
                }
            }
            else if(name=="category")
            {
                foreach (Category c in categoryTable)
                {
                    if (c.id == id)
                    {
                        if (nameColumn == "name")
                        {
                            c.name = value;
                        }  
                    }
                }
            }
            else if(name=="accessotion")
            {
                foreach (Accessotion a in accessoryTable)
                {
                    if (a.id == id)
                    {
                        if (nameColumn == "name")
                        {
                            a.name = value;
                        }
                    }
                }
            }
        }

        public void DeleteTable(string name, Dictionary<string, string> row)
        {
            int id = int.Parse(row["id"]);
            if (name == "product")
            {
                var arr = productTable;
                foreach (Product p in arr)
                {
                    if (p.id == id)
                    {
                        productTable = productTable.Where(s => s.id != id).ToList();
                    }
                }
            }
            else if (name == "category")
            {
                var arr = categoryTable;
                foreach (Category c in arr)
                {
                    if (c.id == id)
                    {
                        categoryTable = categoryTable.Where(s => s.id != id).ToList();
                    }
                }
            }
            else if (name == "accessotion")
            {
                var arr = accessoryTable;
                foreach (Accessotion a in arr)
                {
                    if (a.id == id)
                    {
                        accessoryTable = accessoryTable.Where(s => s.id != id).ToList();
                    }
                }
            }
        }

        public void TruncateTable()
        {
            productTable.Clear();
            categoryTable.Clear();
            accessoryTable.Clear();
        }

        public void UpdateTableById(int id, Dictionary<string, string> row)
        {
            foreach(var pro in productTable)
            {
                if (pro.id == id)
                {
                    foreach (string key in row.Keys)
                    {
                        if(row["table"] == "product")
                        {
                            foreach (string _key in row.Keys)
                            {
                                if (_key == "name")
                                {
                                    pro.name = row["name"];
                                }
                            }
                                
                        }
                        else if (row["table"] == "category")
                        {
                            foreach (string _key in row.Keys)
                            {
                                if (_key == "name")
                                {
                                    pro.name = row["name"];
                                }
                            }

                        }
                        else if (row["table"] == "accessotion")
                        {
                            foreach (string _key in row.Keys)
                            {
                                if (_key == "name")
                                {
                                    pro.name = row["name"];
                                }
                            }
                        }

                    }
                }
            }
            
        }


        private List<Product> SelectProductTable(Dictionary<string, string> where)
        {

            string _operator = where["operator"];
            string nameColumn = where["name"];
            string value = where["value"];
  
            List<Product> res = null;
            if (_operator == "lt")
            {
                if (nameColumn == "id")
                {
                    int i_value = int.Parse(value);
                    res = productTable.Where(s => s.id < i_value).ToList();
                }
            }
            else if(_operator =="gt")
            {
                if (nameColumn == "id")
                {
                    int i_value = int.Parse(value);
                    res = productTable.Where(s => s.id > i_value).ToList();
                }
            }
            else if(_operator=="eq")
            {
                if (nameColumn == "id")
                {
                    int i_value = int.Parse(value);
                    res = productTable.Where(s => s.id == i_value).ToList();
                }
                else if (nameColumn == "name")
                {
                    res = productTable.Where(s => s.name == value).ToList();
                }
            }
            else if(_operator == "contains")
            {
                if (nameColumn == "name")
                {
                    res = productTable.Where(s => s.name.Contains(value)).ToList();
                }
            }
            return res;
        }

        private List<Category> SelectCategoryTable(Dictionary<string, string> where)
        {

            string _operator = where["operator"];
            string nameColumn = where["name"];
            string value = where["value"];

            List<Category> res = null;
            if (_operator == "lt")
            {
                if (nameColumn == "id")
                {
                    int i_value = int.Parse(value);
                    res = categoryTable.Where(s => s.id < i_value).ToList();
                }
            }
            else if (_operator == "gt")
            {
                if (nameColumn == "id")
                {
                    int i_value = int.Parse(value);
                    res = categoryTable.Where(s => s.id > i_value).ToList();
                }
            }
            else if (_operator == "eq")
            {
                if (nameColumn == "id")
                {
                    int i_value = int.Parse(value);
                    res = categoryTable.Where(s => s.id == i_value).ToList();
                }
                else if (nameColumn == "name")
                {
                    res = categoryTable.Where(s => s.name == value).ToList();
                }
            }
            else if (_operator == "contains")
            {
                if (nameColumn == "name")
                {
                    res = categoryTable.Where(s => s.name.Contains(value)).ToList();
                }
            }
            return res;
        }
        private List<Accessotion> SelectAccessotionTable(Dictionary<string, string> where)
        {

            string _operator = where["operator"];
            string nameColumn = where["name"];
            string value = where["value"];

            List<Accessotion> res = null;
            if (_operator == "lt")
            {
                if (nameColumn == "id")
                {
                    int i_value = int.Parse(value);
                    res = accessoryTable.Where(s => s.id < i_value).ToList();
                }
            }
            else if (_operator == "gt")
            {
                if (nameColumn == "id")
                {
                    int i_value = int.Parse(value);
                    res = accessoryTable.Where(s => s.id > i_value).ToList();
                }
            }
            else if (_operator == "eq")
            {
                if (nameColumn == "id")
                {
                    int i_value = int.Parse(value);
                    res = accessoryTable.Where(s => s.id == i_value).ToList();
                }
                else if (nameColumn == "name")
                {
                    res = accessoryTable.Where(s => s.name == value).ToList();
                }
            }
            else if (_operator == "contains")
            {
                if (nameColumn == "name")
                {
                    res = accessoryTable.Where(s => s.name.Contains(value)).ToList();
                }
            }
            return res;
        }

        public List<Product> GetProductTalbe()
        {
            return productTable;
        }
        public List<Category> GetCategoryTalbe()
        {
            return categoryTable;
        }
        public List<Accessotion> GetAccessotionTalbe()
        {
            return accessoryTable;
        }

    }

}