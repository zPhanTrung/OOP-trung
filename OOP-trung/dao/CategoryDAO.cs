using Demo_oop.dao;
using Demo_oop.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_trung.dao
{
    internal class CategoryDAO
    {
        Database instants = Database.Instants();
        public bool Insert(Category category)
        {
            try
            {
                instants.InsertTable("category", category);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
