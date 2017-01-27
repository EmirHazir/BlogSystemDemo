using BlogSystemDemo.Common.Mapping;
using BlogSystemDemo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogSystemDemo.ViewModels
{
    public class ApplicationUserViewModel :IMapFrom<ApplicationUser>
    {
        [Display(Name ="Ekleyen Admin")]
        public string UserName { get; set; }
        public string Email { get; set; }
    }
}