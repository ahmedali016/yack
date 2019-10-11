using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using yackeenTask.Models;

namespace yackeenTask.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            yackEntities ye = new yackEntities();
            var list = ye.Articls;
            ViewBag.categ = (ye.Category.Select(a => new ViewModels.viewCategory { categoryId = a.Id, categoryName = a.categoryName })).ToList();
            return View(list);
        }

        public ActionResult Article(int id)
        {
            yackEntities ye = new yackEntities();
            var articl = ye.Articls.Where(c => c.Id == id).FirstOrDefault();
            ViewBag.categ = (ye.Category.Select(a => new ViewModels.viewCategory { categoryId = a.Id, categoryName = a.categoryName })).ToList();
            return View(articl);
        }

        [HttpPost]
        public ActionResult Article(string cName,string cMessage,string cid)
        {
            yackEntities ye = new yackEntities();
            int id; int.TryParse(cid,out id);
            if (id>0 && cName != string.Empty && cMessage !=string.Empty)
            {
                ye.VisitorComments.Add(new VisitorComments { articleId = id, commentDate = DateTime.Now, visitorName = cName, comment = cMessage });
                ye.SaveChanges();
            }           
            var articl = ye.Articls.Where(c => c.Id == id).FirstOrDefault();
            ViewBag.categ = (ye.Category.Select(a => new ViewModels.viewCategory { categoryId = a.Id, categoryName = a.categoryName })).ToList();
            return View(articl);
        }
        
        public ActionResult Blog(int id)
        {            
            yackEntities ye = new yackEntities();
            var list = ye.Articls.Where(c => c.categoryId == id);
            ViewBag.categ = (ye.Category.Select(a => new ViewModels.viewCategory { categoryId = a.Id, categoryName = a.categoryName })).ToList();
            return View(list);
        }

        public ActionResult _Category()
        {
            
            return View();
        }
    }
}