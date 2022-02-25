using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookShop.Associate.DTO
{
    public class CategoryDTO 
    {
        public int CategoryID { get; set; }
        [Required(ErrorMessage = "Please check your values")]
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
