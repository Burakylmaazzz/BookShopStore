using System;
using System.Collections.Generic;
using System.Text;

namespace BookShop.Entites.Entity.Concrete
{
   public class SubCategory
    {
        public int SubCategoryID { get; set; }
        public string Value { get; set; }


        public List<Category> Category { get; set; }


    }
}
