﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BookShop.DataAccess.Repositories.KernelRepository
{
    public interface IEntityRepository<T>
    {
        T GetById(int id);

        T GetOne(Expression<Func<T, bool>> expression);

        List<T> GetAll(Expression<Func<T, bool>> expression = null);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
