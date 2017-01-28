using BlogSystemDemo.Common.Mapping;
using BlogSystemDemo.Models;
//using Microsoft.AspNet.Identity.EntityFramework; // sil çalışmazsa
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogSystemDemo.ViewModels
{
    public class ApplicationUserViewModel :IMapFrom<ApplicationUser>//,IMapTo<IdentityUser>
    {
        [Display(Name ="Ekleyen Admin")]

        public int UserId { get; set; } // bu amına koyduğuma servis yazmam lazım 
        public string UserName { get; set; }

        private DateTime _createOnSystem = DateTime.Now;
        public DateTime CreateOnSystem {
            get { return  CreateOnSystem; } set { _createOnSystem = CreateOnSystem; } }
        public string Email { get; set; }
    }
}
