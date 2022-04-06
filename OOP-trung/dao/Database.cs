using Demo_oop.entity;
using OOP_trung.entity;
using System.Text.Json;
namespace Demo_oop.dao
{

    public class Database
    {
        private static Database? instants = null;
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
        public void InsertTable(string name, BaseObj row)
        {
            if (name == "product")
            {
                Product _row = (Product)row;
                Product product = new Product
                {
                    Id = _row.Id,
                    Name = _row.Name,
                    CategoryId = _row.CategoryId
                };
                productTable.Add(product);
            }
            else if (name == "category")
            {
                Category _row = (Category)row;
                Category category = new Category()
                {
                    Id = _row.Id,
                    Name = _row.Name
                };
                categoryTable.Add(category);
            }
            else if (name == "accessotion")
            {
                Accessotion _row = (Accessotion)row;
                Accessotion accessotion = new Accessotion
                {
                    Id = _row.Id,
                    Name = _row.Name
                };
                accessoryTable.Add(accessotion);
            }
        }
        public void SelectTable(string name, string where)
        {
            if (name == "product")
            {
                foreach (var pro in productTable)
                {
                    if (pro.Name == where)
                    {
                        Console.WriteLine("id: " + pro.Id + "; name: " + pro.Name + "; categoryId: " + pro.CategoryId);
                    }
                }
                
            }
            else if (name == "category")
            {
                foreach (var cate in categoryTable)
                {
                    if (cate.Name == where)
                    {
                        Console.WriteLine("id: " + cate.Id + "; name: " + cate.Name);
                    }
                }
            }
            else if (name == "accessotion")
            {
                foreach (var acc in categoryTable)
                {
                    if (acc.Name == where)
                    {
                        Console.WriteLine("id: " + acc.Id + "; name: " + acc.Name);
                    }
                }
            }
        }

        public void UpdateTable(string name, BaseObj row)
        {
            if (name == "product")
            {
                Product _row = (Product)row;
                foreach(var pro in productTable)
                {
                    if(pro.Id == _row.Id)
                    {
                        pro.Id = _row.Id;
                        pro.Name = _row.Name;
                        pro.CategoryId = _row.CategoryId;
                    }
                }
            }
            else if (name == "category")
            {
                Category _row = (Category)row;
                foreach (var cate in productTable)
                {
                    if (cate.Id == _row.Id)
                    {
                        cate.Id = _row.Id;
                        cate.Name = _row.Name;
                    }
                }
            }
            else if (name == "accessotion")
            {
                Accessotion _row = (Accessotion)row;
                foreach (var acc in productTable)
                {
                    if (acc.Id == _row.Id)
                    {
                        acc.Id = _row.Id;
                        acc.Name = _row.Name;
                    }
                }
            }
        }


        public void DeleteTable(string name, int id)
        {
            
            if (name == "product")
            {
                var proTable = productTable;
                foreach (Product p in proTable)
                {
                    if (p.Id == id)
                    {
                        productTable = productTable.Where(pro => pro.Id != id).ToList();
                    }
                }
            }
            else if (name == "category")
            {
                var cateTable = categoryTable;
                foreach (Category c in cateTable)
                {
                    if (c.Id == id)
                    {
                        categoryTable = categoryTable.Where(cate => cate.Id != id).ToList();
                    }
                }
            }
            else if (name == "accessotion")
            {
                var accessTable = accessoryTable;
                foreach (Accessotion acc in accessTable)
                {
                    if (acc.Id == id)
                    {
                        accessoryTable = accessoryTable.Where(acc => acc.Id != id).ToList();
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

        public void UpdateTableById(int id, BaseObj row)
        {
            string typeObj = row.GetType().Name.ToLower();
            if(typeObj == "product")
            {
                foreach(var pro in productTable)
                {
                    if(pro.Id == id)
                    {
                        pro.Name = row.Name;
                        pro.CategoryId = ((Product)row).CategoryId;
                    }
                }
            }
            else if (typeObj == "category")
            {
                foreach (var cate in categoryTable)
                {
                    if (cate.Id == id)
                    {
                        cate.Name = row.Name;
                    }
                }
            }
            else if (typeObj == "accessotion")
            {
                foreach (var acc in accessoryTable)
                {
                    if (acc.Id == id)
                    {
                        acc.Name = row.Name;
                    }
                }
            }
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