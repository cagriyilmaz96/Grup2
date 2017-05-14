using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Emlak_Sitesi_1.Models
{
    public class HomeController : Controller
    {
        // GET: Home 
        EmlakEntities1 db = new EmlakEntities1();
        public ActionResult Index()
        {
            ViewBag.ilan= db.ilans.Where(i => i.ilanID != 0).ToList();
            
            return View(ViewBag.ilan);

        }
        public ActionResult Details(int id)
        {
            ViewBag.ilan1 = db.ilans.Where(i => i.ilanID == id).ToList();

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}