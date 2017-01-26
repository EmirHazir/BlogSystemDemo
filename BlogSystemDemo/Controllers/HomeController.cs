using BlogSystemDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper.QueryableExtensions;

namespace BlogSystemDemo.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            var post = this.Data.Posts.All().First();
            var postVM = Mapper.Map<PostViewModel>(post);
            
            //var posts = this.Data.Posts
            //     .All()
            //     .ProjectTo<PostViewModel>()
            //     //.Select(x=>new PostViewModel() {
            //     //    Author = x.Author.UserName,
            //     //    Content = x.Content,
            //     //    CreatedDate = x.CreatedDate, //if you stay on null that you can put here DateTime.Now
            //     //    Title = x.Title
            //     //})
            //     .ToList();
                
            return View(new List<PostViewModel>());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}