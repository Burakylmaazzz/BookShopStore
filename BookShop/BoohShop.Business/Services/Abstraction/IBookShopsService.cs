using BookShop.Entites.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoohShop.Business.Services.Abstraction
{
   public interface IBookShopsService
    {
        List<BookShops> GetAll();

        BookShops GetByID(int id);

        void Add(BookShops bookShops);

        void Update(BookShops bookShops);

        void Delete(BookShops bookShops);
    }
}
