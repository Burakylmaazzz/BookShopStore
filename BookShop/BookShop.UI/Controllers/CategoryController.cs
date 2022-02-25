using BoohShop.Business.Services.Abstraction;
using BookShop.Associate.DTO;
using BookShop.Entites.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BookShop.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;

        }

        [HttpGet]
        public IActionResult GetCategoryList()
        {


            return Ok(_categoryService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetCategoryList(int id)
        {
            var category = _categoryService.GetByID(id);
            if (category != null)
            {
                return Ok(category);

            }
            return NotFound($"Category with Id :{id} was not found");

        }


        [HttpPost]
        public IActionResult AddCategory(CategoryDTO categoryDTO)
        {
            if (ModelState.IsValid)
            {
                Category category = new Category();
                category.Name = categoryDTO.Name;
                category.IsActive = categoryDTO.IsActive;

                _categoryService.Add(category);

                return NotFound($"You have added a new category");
            }

            else
            {
                return Ok(categoryDTO);
            }
        }


        [HttpPut("{id}")]
        public IActionResult UpdateCategory(int id, Category category)
        {

            var updatectgry = _categoryService.GetByID(id);
            if (updatectgry != null)
            {
                category.CategoryID = updatectgry.CategoryID;
                _categoryService.Update(category);
                return NotFound($"Your category {id} number has been updated.");
            }


            return Ok(category);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCatepory(int? id)
        {
            var entity = _categoryService.GetByID((int)id);

            if (entity != null)
            {
                _categoryService.Delete(entity);
            }


            return NotFound($"Your category {id} deletion has been successfully processed.");
        }

    }
}