using BoohShop.Business.Services.Abstraction;
using BookShop.Associate.DTO;
using BookShop.Entites.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BookShop.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookShopsController : ControllerBase
    {
        private IBookShopsService _bookShopsService;

        public BookShopsController(IBookShopsService bookShopsService)
        {
            _bookShopsService = bookShopsService;

        }

        [HttpGet]
        public IActionResult GetBookShopsList()
        {


            return Ok(_bookShopsService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetBookShopsList(int id)
        {
            var bookShops = _bookShopsService.GetByID(id);
            if (bookShops != null)
            {
                return Ok(bookShops);

            }
            return NotFound($"BookShops with Id :{id} was not found");

        }


        [HttpPost]
        public IActionResult AddBookShops(BookShopsDTO bookShopsDTO)
        {
            if (ModelState.IsValid)
            {
                BookShops bookShops = new BookShops();
                bookShops.Name = bookShopsDTO.Name;


                _bookShopsService.Add(bookShops);

                return NotFound($"You have added a new category");
            }

            else
            {
                return Ok(bookShopsDTO);
            }
        }


        [HttpPatch("{id}")]
        public IActionResult UpdateBookShops(int id, BookShops bookShops)
        {

            var bookShopsupdate = _bookShopsService.GetByID(id);
            if (bookShopsupdate != null)
            {
                bookShops.BookShopsID = bookShopsupdate.BookShopsID;
                bookShops.Name = bookShopsupdate.Name;
                _bookShopsService.Update(bookShops);
                return NotFound($"Your category {id} number has been updated.");
            }


            return Ok(bookShops);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBookShops(int? id)
        {
            var entity = _bookShopsService.GetByID((int)id);

            if (entity != null)
            {
                _bookShopsService.Delete(entity);
            }


            return NotFound($"Your category {id} deletion has been successfully processed.");
        }
    }
}