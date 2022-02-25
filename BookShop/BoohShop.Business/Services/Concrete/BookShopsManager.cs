using BoohShop.Business.Services.Abstraction;
using BookShop.DataAccess.Repositories.Repository.Abstraction;
using BookShop.Entites.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoohShop.Business.Services.Concrete
{
    public class BookShopsManager : IBookShopsService
    {
        private IBookShopsRepository _bookShopsRepository;

        public BookShopsManager(IBookShopsRepository bookShopsRepository)
        {
            _bookShopsRepository = bookShopsRepository;
        }

        public void Add(BookShops bookShops)
        {
            _bookShopsRepository.Add(bookShops);

        }

        public void Delete(BookShops bookShops)
        {
            _bookShopsRepository.Delete(bookShops);

        }

        public List<BookShops> GetAll()
        {
            return _bookShopsRepository.GetAll();

        }

        public BookShops GetByID(int id)
        {
            return _bookShopsRepository.GetById(id);
        }

        public void Update(BookShops bookShops)
        {
            var bookshopsupdate = GetByID(bookShops.Id);
            bookshopsupdate.Name = bookShops.Name;

            _bookShopsRepository.Update(bookshopsupdate);
        }
    }
}
