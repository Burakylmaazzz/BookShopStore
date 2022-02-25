using BookShop.Entites.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookShop.Associate.DTO
{
    public class SubCategoryDTO 
    {
        public int SubCategoryID { get; set; }
        public string Value { get; set; }

        public List<Category> Category { get; set; }

    }
}
