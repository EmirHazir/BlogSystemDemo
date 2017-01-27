using BlogSystemDemo.Data;
using BlogSystemDemo.Data.Repositories;
using BlogSystemDemo.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSystemDemo.Services
{
    public class BaseService<T> : IService<T> where T : class
    {
        private IRepository<T> repository;
        public BaseService(IBlogSystemDemoData data)
        {
            this.Data = data;
            this.repository = data.GetRepository<T>();
        }
        protected IBlogSystemDemoData Data { get; private set; }

        public virtual IQueryable<T> GetAll()
        {
            return this.repository.All();
        }
        public virtual T Find (object id)
        {
            return this.repository.Find(id);
        }

        public virtual void Add(T entity)
        {
            this.repository.Add(entity);
        }

        public virtual void Update(T entity)
        {
            this.repository.Update(entity);
        }

        public virtual void Delete(object id)
        {
            this.repository.Delete(id);
        }

        public virtual void SaveChanges()
        {
            this.repository.SaveChanges();
        }
    }
}
