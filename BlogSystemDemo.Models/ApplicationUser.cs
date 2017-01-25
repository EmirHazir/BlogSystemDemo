using Microsoft.AspNet.Identity; //UserManager
using Microsoft.AspNet.Identity.EntityFramework; //IdentityUser  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims; //ClaimsIdentity
using System.Text;
using System.Threading.Tasks;

namespace BlogSystemDemo.Models
{
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }
}
