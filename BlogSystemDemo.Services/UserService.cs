using BlogSystemDemo.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogSystemDemo.Models;
using BlogSystemDemo.Data;

namespace BlogSystemDemo.Services
{
    public class UserService :BaseService<ApplicationUser>, IUserService
    {
        public UserService(IBlogSystemDemoData data) : base(data)
        {
        }
    }
}
