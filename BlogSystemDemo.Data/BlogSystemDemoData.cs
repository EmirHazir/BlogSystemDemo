namespace BlogSystemDemo.Data
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using BlogSystemDemo.Data.Repositories;
    using BlogSystemDemo.Models;
    using BlogSystemDemo.Data;

    public class BlogSystemDemoData : IBlogSystemDemoData
    {
        private DbContext context;
        private Dictionary<Type, object> repositories;

        public BlogSystemDemoData()
            : this(new BSDbContext())
        {
        }

        public BlogSystemDemoData(DbContext context)
        {
            this.context = context;
            this.repositories = new Dictionary<Type, object>();
        }



        public IRepository<ApplicationUser> Users
        {
            get
            {
                return this.GetRepository<ApplicationUser>();
            }
        }

        public IRepository<Post> Posts
        {
            get
            {
                return this.GetRepository<Post>();
            }
        }




        private IRepository<T> GetRepository<T>() where T : class
        {
            var typeOfRepository = typeof(T);
            if (!this.repositories.ContainsKey(typeOfRepository))
            {
                var newRepository = Activator.CreateInstance(typeof(Repository<T>), context);
                this.repositories.Add(typeOfRepository, newRepository);
            }

            return (IRepository<T>) this.repositories[typeOfRepository];
        }

        public int SaveChanges()
        {
            return this.context.SaveChanges();
        }
    }
}
