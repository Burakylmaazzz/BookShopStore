using BookShop.Entites.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoohShop.Business.Services.Abstraction
{
    public interface ISubCategoryService
    {
        List<SubCategory> GetAll();

        SubCategory GetByID(int id);

        void Add(SubCategory subCategory);

        void Update(SubCategory subCategory);

        void Delete(SubCategory subCategory);
    }
}
