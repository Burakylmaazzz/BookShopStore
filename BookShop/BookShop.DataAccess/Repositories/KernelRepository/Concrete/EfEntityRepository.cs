﻿using BookShop.DataAccess.Repositories.KernelRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BookShop.DataAccess.Repositories.Repository
{
    public class EfEntityRepository<T, TContext> : IEntityRepository<T> where T : class where TContext : DbContext, new()
    {
        public void Add(T entity)
        {
            using (var context = new TContext())
            {
                context.Set<T>().Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (var context = new TContext())
            {
                context.Set<T>().Remove(entity);
                context.SaveChanges();
            }
        }

        public List<T> GetAll(Expression<Func<T, bool>> expression = null)
        {
            using (var context = new TContext())
            {
                return expression == null ? context.Set<T>().ToList() : context.Set<T>().Where(expression).ToList();
            }
        }

        public T GetById(int id)
        {
            using (var context = new  TContext())
            {
                return context.Set<T>().Find(id);
            }

        }

        public T GetOne(Expression<Func<T, bool>> expression)
        {
            using (var context = new TContext())
            {
                return context.Set<T>().Where(expression).FirstOrDefault();
            }
        }

        public void Update(T entity)
        {
            using (var context = new TContext())
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
