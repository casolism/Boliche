using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BowlingScore.Controllers
{
    public class ScoreController : Controller
    {
        //
        // GET: /Score/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RegistraChuza()
        {
            ViewBag.Score = "X-";
            return View("Index");
        }

    }
}
