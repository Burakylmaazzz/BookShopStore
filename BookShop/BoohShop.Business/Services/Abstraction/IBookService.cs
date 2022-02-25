using BookShop.Entites.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoohShop.Business.Services.Abstraction
{
   public interface IBookService
    {
        List<Book> GetAll();

        Book GetByID(int id);

        void Add(Book book);

        void Update(Book book);

        void Delete(Book book);
    }
}
