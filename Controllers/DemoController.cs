using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EF.Models;
namespace EF.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        DataClasses1DataContext da = new DataClasses1DataContext();
        public List<Product>ls(int count)
        {
            return da.Products.OrderByDescending(a => a.Productname).Take(count).ToList();
        }
        public ActionResult Index()
        {
            var t = ls(5);
            return View(t);
        }
        public ActionResult chude()
        {
            List<Product> ds = da.Products.ToList();
            return PartialView(ds);
        }
        public ActionResult detail(int id)
        {
            Product s = da.Products.FirstOrDefault(t => t.Id == id);
            return View(s);
        }   
        public ActionResult hienthitheocd(int id)
        {
            List<Product> p = da.Products.Where(t => t.Id == id).ToList();
            return View("Index",p);
        }
    }
}