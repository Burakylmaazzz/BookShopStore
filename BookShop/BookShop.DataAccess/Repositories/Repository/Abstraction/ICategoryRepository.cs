using BookShop.DataAccess.Repositories.KernelRepository;
using BookShop.Entites.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BookShop.DataAccess.Repositories.Repository.Abstraction
{
    public interface ICategoryRepository : IEntityRepository<Category>
    {

      
    }
}
