using BoohShop.Business.Services.Abstraction;
using BookShop.DataAccess.Repositories.Repository.Abstraction;
using BookShop.Entites.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoohShop.Business.Services.Concrete
{
    public class SubCategoryManager : ISubCategoryService
    {
        private ISubCategoryRepository _subCategoryRepository;

        public SubCategoryManager(ISubCategoryRepository subCategoryRepository)
        {
            _subCategoryRepository = subCategoryRepository;
        }

        public void Add(SubCategory subCategory)
        {
            _subCategoryRepository.Add(subCategory);

        }

        public void Delete(SubCategory subCategory)
        {
            _subCategoryRepository.Add(subCategory);

        }

        public List<SubCategory> GetAll()
        {
            return _subCategoryRepository.GetAll();

        }

        public SubCategory GetByID(int id)
        {
            return _subCategoryRepository.GetById(id);
        }

        public void Update(SubCategory subCategory)
        {
            var subcategoryupdate = GetByID(subCategory.SubCategoryID);
            subcategoryupdate.Value = subCategory.Value;
            subcategoryupdate.Category = subCategory.Category;
            _subCategoryRepository.Update(subcategoryupdate);
        }
    }
}
