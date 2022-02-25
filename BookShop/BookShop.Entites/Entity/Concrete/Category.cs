using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookShop.Entites.Entity.Concrete
{
    public class Category
    {
        public int CategoryID{ get; set; }
        
        [Required, StringLength(100),Display(Name="Category Name")]
        public string Name { get; set; }
               
        public bool IsActive { get; set; }

    }
}
