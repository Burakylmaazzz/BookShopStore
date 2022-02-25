using BookShop.DataAccess.Context;
using BookShop.DataAccess.Repositories.Repository.Abstraction;
using BookShop.Entites.Entity.Concrete;

namespace BookShop.DataAccess.Repositories.Repository.Concrete
{
    public class EfCategoryRepository : EfEntityRepository<Category, ProjectContext>, ICategoryRepository
    {
       
    }
}
