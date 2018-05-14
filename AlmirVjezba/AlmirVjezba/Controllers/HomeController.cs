using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AlmirVjezbaContext1.DAL;


namespace AlmirVjezba.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        MyContext Db = new MyContext();

        public ActionResult Index()
        {
            Db.User.Find(0);
            return View();
        }
    }
}