using BookShop.Entites.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoohShop.Business.Services.Abstraction
{
    public interface ICategoryService
    {
        List<Category> GetAll();

        Category GetByID(int id);

        void Add(Category category);

        void Update(Category category);

        void Delete(Category category);
    }
}
