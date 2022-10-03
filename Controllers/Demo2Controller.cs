using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EF.Models;
namespace EF.Controllers
{
    public class Demo2Controller : Controller
    {
        // GET: Demo2
        public ActionResult Index()
        {
            DataClasses2DataContext da = new DataClasses2DataContext();
            var all = from t in da.TA1s select t;
            return View();
        }

    }
}