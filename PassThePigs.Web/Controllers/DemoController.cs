using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PassThePigs.Lib;
using PassThePigs.Web.Models;

namespace PassThePigs.Web.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        [HttpGet]
        public ActionResult Index()
        {
            DemoIndexViewModel model = new DemoIndexViewModel();
            model.Pig1 = new Pig();
            model.Pig2 = new Pig();

            model.Pig1.Roll();
            model.Pig2.Roll();

            return View(model);
        }
    }
}