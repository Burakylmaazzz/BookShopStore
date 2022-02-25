using BookShop.Entites.Entity.Abstraction;
using BookShop.Entites.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookShop.Entites.Entity.Concrete
{
    public class BaseEntity : IEntity
    {
        public int Id { get; set; }

        private DateTime _addDate = DateTime.Now;
        public DateTime AddDate { get {return _addDate; } set { _addDate = value; } }

        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }

        private Status _status = Status.Active;
        public Status Status { get { return _status; } set {_status = value; } }
    }
}
