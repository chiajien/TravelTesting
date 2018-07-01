using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using WebTesting.DA;
using WebTesting.Domain;
using WebTesting.Properties;

namespace WebTesting.Controllers
{
    public class HomeController : Controller
    {
        UserDOM user = new UserDOM();
        UserDA userDA = new UserDA();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            user = userDA.selectUserPassword("CJ");
            ViewBag.Message = user.Password;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}