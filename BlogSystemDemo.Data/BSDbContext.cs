namespace BlogSystemDemo.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Data.Entity;
    //using BlogSystemDemo.Data.Migrations;
    using BlogSystemDemo.Models;

    public class BSDbContext : IdentityDbContext
    {
        public BSDbContext()
            : base("BSConnection")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<SystemDbContext, Configuration>());
        }

        public IDbSet<ApplicationUser> Users
        {
            get;
            set;
        }

        public IDbSet<Post> Posts
        {
            get;
            set;
        }


    
        public static BSDbContext Create()
        {
            return new BSDbContext();
        }

        //public System.Data.Entity.DbSet<BlogSystemDemo.Models.Post> Posts { get; set; }
        //public System.Data.Entity.DbSet<BlogSystemDemo.Models.ApplicationUser> IdentityUsers { get; set; }
    }
}
