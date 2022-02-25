using BookShop.Entites.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookShop.Associate.DTO
{
    public class BookDTO : BaseDTO
    {
        [Required(ErrorMessage = "Please check your values")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please check your values")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please check your values")]
        public string Details { get; set; }

        [Required(ErrorMessage = "Please check your values")]
        public string TheAuthor { get; set; }

        [Required(ErrorMessage = "Please check your values")]
        public string CompiledBy { get; set; }

        public string AboutTheAuthor { get; set; }

        public string Reviews { get; set; }

        [Required(ErrorMessage = "Please check your values")]
        public string Private { get; set; }

        public string Image { get; set; }

        public List<Category> Category { get; set; }

        public List<SubCategory> SubCategory { get; set; }
        
        public List<BookShops> BookShops { get; set; }
        
    }
}
