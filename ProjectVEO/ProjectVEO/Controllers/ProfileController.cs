using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectVEO.Models;
namespace ProjectVEO.Controllers
{
    public class ProfileController : Controller
    {
        
        public ActionResult Account()
        {
            return View();
        }
        public ActionResult Overview()
        {
            //var model = new ProfileModel();
            //model.currentTab = 1;
            return View();
        }
        public ActionResult Uploads()
        {
            return View();
        }
        public ActionResult Downloads()
        {
            return View();
        }
        public ActionResult Widgets()
        {
            return View();
        }
    }
}