using BlogSystemDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSystemDemo.Services.Contracts
{
   public interface IUserService : IService<ApplicationUser>
    {
#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
        IQueryable<ApplicationUser> GetAll();
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword
    }
}
