using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AndroidIssueTest.Models;

namespace AndroidIssueTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult BasketDetail()
        {
            List<BasketItem> items = new List<BasketItem> 
            {
                new BasketItem { BasketItemID = 123, Description = "An Item", Amount = 10 }
            };

            return View(items);
        }

        public ActionResult Remove(int basketItemID)
        {
            return RedirectToAction("Index");
        }
    }
}