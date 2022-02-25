using BoohShop.Business.Services.Abstraction;
using BookShop.Associate.DTO;
using BookShop.Entites.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BookShop.UI.Controllers
{
    [Route("api/[controller]")]

    [ApiController]
    public class BookController : ControllerBase
    {
        private IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;

        }

        [HttpGet]
        public IActionResult GetBookList()
        {


            return Ok(_bookService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetBookList(int id)
        {
            var book = _bookService.GetByID(id);
            if (book != null)
            {
                return Ok(book);

            }
            return NotFound($"Book with Id :{id} was not found");

        }


        [HttpPost]
        public IActionResult AddBook(BookDTO bookDTO)
        {
            if (ModelState.IsValid)
            {
                Book book = new Book();
                book.Name = bookDTO.Name;
                book.Description = bookDTO.Description;
                book.Details = bookDTO.Details;
                book.TheAuthor = bookDTO.TheAuthor;
                book.CompiledBy = bookDTO.CompiledBy;
                book.AboutTheAuthor = bookDTO.AboutTheAuthor;
                book.Reviews = bookDTO.Reviews;
                book.Private = bookDTO.Private;
                book.Image = bookDTO.Image;

                book.Category = bookDTO.Category;
                book.SubCategory = bookDTO.SubCategory;
                book.BookShops = bookDTO.BookShops;
                _bookService.Add(book);

                return NotFound($"You have added a new Book");
            }

            else
            {
                return Ok(bookDTO);
            }
        }


        [HttpPatch("{id}")]
        public IActionResult UpdateBook(int id, Book book)
        {

            var updateBook = _bookService.GetByID(id);
            if (updateBook != null)
            {
                book.Id = updateBook.Id;
                _bookService.Update(book);
                return NotFound($"Your book {id} number has been updated.");
            }


            return Ok(book);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int? id)
        {
            var entity = _bookService.GetByID((int)id);

            if (entity != null)
            {
                _bookService.Delete(entity);
            }


            return NotFound($"Your Book {id} deletion has been successfully processed.");
        }
    }
}