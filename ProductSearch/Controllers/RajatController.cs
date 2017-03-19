using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProductSearch.Models;

namespace ProductSearch.Controllers
{
    public class RajatController : Controller
    {
        productsByRajat db = new productsByRajat();
        // GET: Rajat
        public ActionResult Index()
        {
            List<char> productList = db.productName.ToList();
            return View(productList);
        }
    }
}