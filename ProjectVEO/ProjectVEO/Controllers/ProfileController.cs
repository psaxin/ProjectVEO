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
        
    
        public ActionResult Overview()
        {
            var model = new ProfileModel();
            model.currentTab = 1;
            return View(model);
        }
        public ActionResult Uploads()
        {
            var model = new ProfileModel();
            model.currentTab = 2;
            return View(model);
        }
        public ActionResult Downloads()
        {
            var model = new ProfileModel();
            model.currentTab = 3;
            return View(model);
        }
        public ActionResult Widgets()
        {
            var model = new ProfileModel();
            model.currentTab = 4;
            return View(model);
        }
        public ActionResult Account()
        {
            var model = new ProfileModel();
            model.currentTab = 5;
            return View(model);
        }
    }
}