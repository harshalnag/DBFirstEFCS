using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DBFirstMVC.Models;


namespace DBFirstMVC.Controllers
{
    public class BlogController : Controller
    {
        //
        // GET: /Blog/

        public ActionResult Index()
        {
            using (var db = new BlogDataEntities())
            {
                return View(db.Blogs.ToList());
            }

        }

        //
        // GET: /Blog/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Blog/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Blog/Create

        [HttpPost]
        public ActionResult Create(Blog blog)
        {
            try
            {
                using (var db = new BlogDataEntities())
                {
                    db.Blogs.Add(blog);
                    db.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        //
        // GET: /Blog/Edit/5

        public ActionResult Edit(int id)
        {
            using (var db = new BlogDataEntities())
            {
                return View(db.Blogs.Find(id));
            }

        }

        //
        // POST: /Blog/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, Blog blog)
        {
            try
            {
                using (var db = new BlogDataEntities())
                {
                    db.Entry(blog).State = System.Data.EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch
            {
                return View();
            }
        }



        //
        // GET: /Blog/Delete/5

        public ActionResult Delete(int id)
        {
            using (var db = new BlogDataEntities())
            {
                return View(db.Blogs.Find(id));
            }
        }

        [HttpPost]
        public ActionResult Delete(int id, Blog blog)
        {
            try
            {
                using (var db = new BlogDataEntities())
                {
                    db.Entry(blog).State = System.Data.EntityState.Deleted;
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
