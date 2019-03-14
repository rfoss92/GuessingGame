using System;
using System.Web.Mvc;
using System.Collections;
using Guessing_Game.Models;

namespace Guessing_Game.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NewRandomNumber()
        {
            RandomModel.AddNumber();
            var sessionId = RandomModel.GetSize();
            return new JsonResult() { Data = sessionId };
        }

        public ActionResult VerifyGuess(int input, int sessionId)
        {
            var hint = "Please enter a number between 1 and 100";
            var randomNumber = RandomModel.GetNumber(sessionId);

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