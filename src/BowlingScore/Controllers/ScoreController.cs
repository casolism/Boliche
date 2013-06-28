using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BowlingScore.Models;

namespace BowlingScore.Controllers
{
    public class ScoreController : Controller
    {
        //
        // GET: /Score/
        internal static BowlingModel juego;
        public ActionResult Index()
        {
            inicilizaJuego();
            return View(juego);
        }

        private static void inicilizaJuego()
        {
            juego = new BowlingModel();
            juego.Jugador = 1;
            juego.Turno = 1;
            juego.Oportunidad = 1;
        }

        public ActionResult RegistraChuza()
        {
            juego.ActualizaScore(10);
            return View("Index",juego);
            
        }

        public ActionResult RegistraTiro()
        {
            string scoreNumber = Request.Form["txtPinos"];
            juego.ActualizaScore(int.Parse(scoreNumber));
            return View("Index",juego);            
        }
    }
}
