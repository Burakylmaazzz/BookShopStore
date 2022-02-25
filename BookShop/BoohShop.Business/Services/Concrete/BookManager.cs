using BoohShop.Business.Services.Abstraction;
using BookShop.DataAccess.Repositories.Repository.Abstraction;
using BookShop.Entites.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoohShop.Business.Services.Concrete
{
    public class BookManager : IBookService
    {

        private IBookRepository _bookRepository;

        public BookManager(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }



        public void Add(Book book)
        {
            _bookRepository.Add(book);

        }

        public void Delete(Book book)
        {
            _bookRepository.Delete(book);

        }

        public List<Book> GetAll()
        {
           return _bookRepository.GetAll();

        }

        public Book GetByID(int id)
        {
            return _bookRepository.GetById(id);
        }

        public void Update(Book book)
        {
            var bookUpdate = GetByID(book.Id);
            bookUpdate.Name = book.Name;
            bookUpdate.Description = book.Description;
            bookUpdate.Details = book.Details;
            bookUpdate.TheAuthor = book.TheAuthor;
            bookUpdate.CompiledBy = book.CompiledBy;
            bookUpdate.AboutTheAuthor = book.AboutTheAuthor;
            bookUpdate.Reviews = book.Reviews;
            bookUpdate.Private = book.Private;
            bookUpdate.Image = book.Image;

            bookUpdate.Category = book.Category;
            bookUpdate.SubCategory = book.SubCategory;
            bookUpdate.BookShops = book.BookShops;


            _bookRepository.Update(bookUpdate);
        }
    }
}
