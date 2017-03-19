using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProductSearch.Models;

namespace ProductSearch.Controllers
{
    public class HomeController : Controller
    {
        private Venomous_Entities _db = new Venomous_Entities();
        // GET: Rajat
        //public ActionResult Index()
        //{
        //    List<productsByRajat> productList = _db.productsByRajats.ToList();
        //    return View(productList);
        //}

        public ActionResult Index(string searchstring)
        {
            var c = from application in _db.products_base
            select application;
            if (!string.IsNullOrWhiteSpace(searchstring))
            {
                List<string> s = searchstring.Split(' ').ToList();
                c = from p in c where s.Any(val => p.productName.Contains(val) || p.productDescription.Contains(val)) select p;
            }
            return View(c);
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