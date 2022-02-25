using BoohShop.Business.Services.Abstraction;
using BookShop.DataAccess.Repositories.Repository.Abstraction;
using BookShop.Entites.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoohShop.Business.Services.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryRepository _categoryRepository;

        public CategoryManager(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        

        public void Add(Category category)
        {
            _categoryRepository.Add(category);
        }

        public void Delete(Category category)
        {
            _categoryRepository.Delete(category);
        }



        public List<Category> GetAll()
        {
            return _categoryRepository.GetAll();
        }

        public Category GetByID(int id)
        {
            return _categoryRepository.GetById(id);
        }

        public void Update(Category category)
        {

            var categoryupdate = GetByID(category.CategoryID);
            categoryupdate.Name = category.Name;
            categoryupdate.IsActive = category.IsActive;
            _categoryRepository.Update(categoryupdate);
        }
    }
}
