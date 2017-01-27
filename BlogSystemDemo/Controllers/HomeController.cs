using BlogSystemDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper.QueryableExtensions;
using BlogSystemDemo.Models;
using static BlogSystemDemo.App_Start.NinjectWebCommon;
using BlogSystemDemo.Data;
using BlogSystemDemo.Services.Contracts;

namespace BlogSystemDemo.Controllers
{
    public class HomeController : BaseController
    {
        private IPostService ipostService;
        public HomeController(IPostService service)
        {
            this.ipostService = service;
        }


        public ActionResult Index()
        {
            var posts = Mapper.Map<List<Post>,
             List<PostViewModel>>(ipostService.GetAll().ToList());
        
            return View(posts);
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