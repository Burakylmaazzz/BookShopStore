using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookShop.Entites.Entity.Concrete
{
   public class Book : BaseEntity
    {
        [Required,Display(Name ="Book Name")]
        public string Name { get; set; }

        [Required, Display(Name = "Book Name")]
        public string Description { get; set; }

        [Required, Display(Name = "Book Details")]
        public string Details { get; set; }

        [Required, Display(Name = "Book The Author")]
        public string TheAuthor { get; set; }

        [Required, Display(Name = "Book Compiled By")]

        public string CompiledBy { get; set; }

        public string AboutTheAuthor { get; set; }

        public string Reviews { get; set; }

        [Required]
        public string Private { get; set; }

        public string Image{ get; set; }

        public List<Category> Category { get; set; }
      
        public List<SubCategory> SubCategory { get; set; }

        public List<BookShops> BookShops { get; set; }


    }
}
