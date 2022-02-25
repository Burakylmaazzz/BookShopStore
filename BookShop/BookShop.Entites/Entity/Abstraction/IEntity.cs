using BookShop.Entites.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookShop.Entites.Entity.Abstraction
{
    public interface IEntity
    {
        public int Id { get; set; }

        public DateTime AddDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeleteDate { get; set; }

        public Status Status { get; set; }
    }
}
