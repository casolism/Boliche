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

        public ActionResult RegistraTiro()
        {
            ViewBag.Score = "X-";
            string scoreNumber = Request.Form["txtPinos"];
            ViewBag.Score1 = scoreNumber;
            return View("Index");            
        }

    }
}
