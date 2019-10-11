using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using yackeenTask.Models;

namespace yackeenTask.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            yackEntities ye = new yackEntities();
            ViewBag.categ = ye.Category.Select(n => new SelectListItem
            {
                Value = n.Id.ToString(),
                Text = n.categoryName
            }).ToList();
            return View();
        }

        [HttpPost]
        public ActionResult Index(Articls article)
        {
            try
            {
                yackEntities ye = new yackEntities();
                ViewBag.categ = ye.Category.Select(n => new SelectListItem
                {
                    Value = n.Id.ToString(),
                    Text = n.categoryName
                }).ToList();
                ye.Articls.Add(new Articls { articleDate = DateTime.Now, categoryId = article.categoryId, articleDetails = article.articleDetails, subject = article.subject });
                ye.SaveChanges();
                return View();
            }
            catch (Exception)
            {

                return View();
            }
            
        }

        public ActionResult Category()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Category(Category categ)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    yackEntities ye = new yackEntities();
                    ye.Category.Add(new Models.Category { categoryName = categ.categoryName });
                    ye.SaveChanges();
                }
                catch (Exception)
                {

                    return View();
                }
                
                
            }
            return View();
        }
    }
}