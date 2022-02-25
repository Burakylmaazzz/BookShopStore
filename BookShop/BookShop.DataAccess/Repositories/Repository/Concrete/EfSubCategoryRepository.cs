using BookShop.DataAccess.Context;
using BookShop.DataAccess.Repositories.Repository.Abstraction;
using BookShop.Entites.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookShop.DataAccess.Repositories.Repository.Concrete
{
    public class EfSubCategoryRepository : EfEntityRepository<SubCategory, ProjectContext>, ISubCategoryRepository
    {
    }
}
