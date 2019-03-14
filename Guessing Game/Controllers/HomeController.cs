using System;
using System.Web.Mvc;
using System.Collections;

namespace Guessing_Game.Controllers
{
    public class HomeController : Controller
    {

        public class Globals
        {
            public static Random rnd = new Random();
            public static ArrayList randomNumbers = new ArrayList();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult newRandomNumber()
        {   
            Globals.randomNumbers.Add(Globals.rnd.Next(1, 101));
            int sessionID = Globals.randomNumbers.Count - 1;
            return new JsonResult() { Data = sessionID };
        }

        public ActionResult verifyGuess(int input, int sessionID)
        {
            string hint = "Please enter a number between 1 and 100";
            int randomNumber = Convert.ToInt32(Globals.randomNumbers[sessionID]);

            if (input < 101 && input > 0)
            {
                hint = (input > randomNumber) ? "Lower" 
                        : (input < randomNumber) ? "Higher" 
                        : "Equal";
            }
            return new JsonResult() { Data = hint };
        }
    }
}