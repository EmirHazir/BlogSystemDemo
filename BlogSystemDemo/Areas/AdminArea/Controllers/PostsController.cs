using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BlogSystemDemo.Data;
using BlogSystemDemo.Models;
using BlogSystemDemo.Controllers;
using BlogSystemDemo.Areas.AdminArea.ViewModels;
using BlogSystemDemo.Services.Contracts;

namespace BlogSystemDemo.Areas.AdminArea.Controllers
{
    public class PostsController : BaseController
    {
        private IPostService ipostService;
        private IUserService iuserService;
        public PostsController(IPostService postService, IUserService userService)
        {
            this.ipostService = postService;
            this.iuserService = userService;
        }

        // GET: AdminArea/Posts
        public ActionResult Index()
        {
            var posts = Mapper.Map<List<Post>,
             List<PostViewModel>>(ipostService.GetAll().ToList());
            return View(posts);
        }

        // GET: AdminArea/Posts/Create
        public ActionResult Create()
        {
            PostViewModel postVM = new PostViewModel();
            postVM.Users = new SelectList(this.iuserService.GetAll(), "Id", "UserName");

            return View(postVM);
        }

        // POST: AdminArea/Posts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PostViewModel post)
        {
            if (ModelState.IsValid)
            {
                var dbPost = Mapper.Map<Post>(post);
                this.ipostService.Add(dbPost);
                return RedirectToAction("Index");
            }

            ViewBag.AuthorId = new SelectList(iuserService.GetAll(), "Id", "Email", post.AuthorId);
            return View(post);
        }

        // GET: AdminArea/Posts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Post post = this.ipostService.Find(id);
            if (post == null)
            {
                return HttpNotFound();
            }

            PostViewModel postVM = Mapper.Map<PostViewModel>(post);
            postVM.Users = new SelectList(iuserService.GetAll(), "Id", "Email", post.AuthorId);
            return View(postVM);
        }

        // POST: AdminArea/Posts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Content,AuthorId,CreatedDate,IsDeleted")] Post post)
        {
            if (ModelState.IsValid)
            {
                this.ipostService.Update(post);
                this.ipostService.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AuthorId = new SelectList(iuserService.GetAll(), "Id", "Email", post.AuthorId);
            return View(post);
        }

        // GET: AdminArea/Posts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Post post = this.ipostService.Find(id);
            if (post == null)
            {
                return HttpNotFound();
            }
            return View(post);
        }

        // POST: AdminArea/Posts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Post post = ipostService.Find(id);
            this.ipostService.Delete(id);
            this.ipostService.SaveChanges();
            return RedirectToAction("Index");
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
