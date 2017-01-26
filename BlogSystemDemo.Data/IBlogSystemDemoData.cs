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


    }
}
