using BoohShop.Business.Services.Abstraction;
using BookShop.Associate.DTO;
using BookShop.Entites.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BookShop.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubCategoryController : ControllerBase
    {
        private ISubCategoryService _subcategoryService;

        public SubCategoryController(ISubCategoryService subcategoryService)
        {
            _subcategoryService = subcategoryService;

        }

        [HttpGet]
        public IActionResult GetSubCategoryList()
        {


            return Ok(_subcategoryService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetSubCategoryList(int id)
        {
            var subcategory = _subcategoryService.GetByID(id);
            if (subcategory != null)
            {
                return Ok(subcategory);

            }
            return NotFound($"SubCategory with Id :{id} was not found");

        }


        [HttpPost]
        public IActionResult AddSubCategory(SubCategoryDTO subcategoryDTO)
        {
            if (ModelState.IsValid)
            {
                SubCategory subcategory = new SubCategory();
                subcategory.SubCategoryID = subcategoryDTO.SubCategoryID;
                subcategory.Value = subcategoryDTO.Value;
                subcategory.Category = subcategoryDTO.Category;


                _subcategoryService.Add(subcategory);

                return NotFound($"You have added a new SubCategory");
            }

            else
            {
                return Ok(subcategoryDTO);
            }
        }


        [HttpPatch("{id}")]
        public IActionResult UpdateSubCategory(int id, SubCategory subcategory)
        {

            var subcategoryupdate = _subcategoryService.GetByID(id);
            if (subcategoryupdate != null)
            {
                subcategory.SubCategoryID = subcategoryupdate.SubCategoryID;
                _subcategoryService.Update(subcategory);
                return NotFound($"Your category {id} number has been updated.");
            }


            return Ok(subcategory);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteSubCategory(int? id)
        {
            var entity = _subcategoryService.GetByID((int)id);

            if (entity != null)
            {
                _subcategoryService.Delete(entity);
            }


            return NotFound($"Your category {id} deletion has been successfully processed.");
        }
    }
}