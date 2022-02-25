using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookShop.Entites.Entity.Concrete
{
   public class BookShops : BaseEntity
    {
        public int BookShopsID { get; set; }

        public string Name { get; set; }


    }
}
