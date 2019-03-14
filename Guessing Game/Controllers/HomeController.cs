using System;
using System.Web.Mvc;

namespace Guessing_Game.Controllers
{
    public class HomeController : Controller
    {

        public class Globals
        {
            public static Random rnd = new Random();
            public static int randomNumber = rnd.Next(1, 101);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult newRandomNumber()
        {   
            Globals.randomNumber = Globals.rnd.Next(1, 101);
            return new EmptyResult();
        }

        public ActionResult verifyGuess(int input)
        {
            string hint = "Please enter a number between 1 and 100";

            if (input < 101 && input > 0)
            {
                hint = (input > Globals.randomNumber) ? "Lower" 
                        : (input < Globals.randomNumber) ? "Higher" 
                        : "Equal";
            }
            return new JsonResult() { Data = hint };
        }
    }
}