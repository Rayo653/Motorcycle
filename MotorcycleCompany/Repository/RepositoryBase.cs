using Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected RepositoryContext Context;
        public RepositoryBase(RepositoryContext context) => this.Context = context;

       

        public IQueryable<T> FindAll(bool trackChanges) =>

            !trackChanges
                ? Context.Set<T>()
                    .AsNoTracking()
            : Context.Set<T>();


        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges)=>
            !trackChanges
                ? Context.Set<T>()
                .Where(expression)
                .AsNoTracking()
            : Context.Set<T>()
                .Where(expression);

        public void Update(T Entity) => Context.Set<T>().Update(Entity);
        public void Create(T Entity) => Context.Set<T>().Add(Entity);

        public void Delete(T Entity) => Context?.Set<T>().Remove(Entity);

    }
}
