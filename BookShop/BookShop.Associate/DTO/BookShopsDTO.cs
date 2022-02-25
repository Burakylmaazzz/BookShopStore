using BookShop.Entites.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookShop.Associate.DTO
{
    public class BookShopsDTO : BaseDTO
    {
        [Required,Display(Name = "Shop Name")]
        public string Name { get; set; }
        


    }
}
