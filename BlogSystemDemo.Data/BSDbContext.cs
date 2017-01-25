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
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<TrackingSystemDbContext, Configuration>());
        }

        IDbSet<ApplicationUser> Users
        {
            get;
            set;
        }

        

        public static BSDbContext Create()
        {
            return new BSDbContext();
        }
    }
}
