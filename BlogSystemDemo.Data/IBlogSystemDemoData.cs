namespace BlogSystemDemo.Data
{
    using BlogSystemDemo.Data.Repositories;
    using BlogSystemDemo.Models;

    public interface IBlogSystemDemoData
    {
        IRepository<ApplicationUser> Users
        {
            get;
        }

        IRepository<Post> Posts
        {
            get;
        }

        IRepository<T> GetRepository<T>() where T : class;
        
        


    }
}
