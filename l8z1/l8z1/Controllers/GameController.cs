using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace l8z1.Controllers
{
    public class GameController : Controller
    {
        static Random rnd = new Random();
        private static int valueToGuess { get; set; }
        public static int numerProby { get; set; }
        public static int n { get; set; }
        public IActionResult Set(int number)
        {
            HttpContext.Session.SetInt32("n", number);
            n = number;
            return View("MyPage");
        }
        public IActionResult Draw()
        {
            HttpContext.Session.SetInt32("counter", 0);
            int randValue = rnd.Next(0, (int)HttpContext.Session.GetInt32("n"));
            HttpContext.Session.SetInt32("randValue", randValue);
            HttpContext.Session.SetString("history", "");
            return View("MyPage");
        }
        public IActionResult Guess(int guess)
        {
            ViewBag.Choice = guess;
            int randValue = (int)HttpContext.Session.GetInt32("randValue");

            string historyOfGuesses = HttpContext.Session.GetString("history");
            historyOfGuesses = historyOfGuesses + " " + guess;
            HttpContext.Session.SetString("history", historyOfGuesses);
            ViewBag.History = historyOfGuesses;

            int counter = (int)HttpContext.Session.GetInt32("counter");
            counter++;
            HttpContext.Session.SetInt32("counter", counter);
            ViewBag.Round = counter;
            if (guess > HttpContext.Session.GetInt32("n"))
            {
                numerProby++;
                ViewBag.Style = "out_of_range";
                setValuesToView();
                ViewBag.Message = "Guessed number is out of range";
            }
            else if (guess > randValue)
            {
                numerProby++;
                setValuesToView();
                ViewBag.Style = "too_small";
                ViewBag.Message = "The number you are trying to guess is lesser than " + guess; 
            }
            else if (guess < randValue)
            {
                numerProby++;
                setValuesToView();
                ViewBag.Style = "too_big";
                ViewBag.Message = "The number you are trying to guess is greater than " + guess;
            }
            else if (guess == randValue)
            {
                numerProby++;
                ViewBag.Style = "guessed";
                setValuesToView();
                ViewBag.Message = "You guessed correctly!";
                numerProby = 0;
            }
            return View("MyPage");
        }

        private void setValuesToView()
        {
            ViewBag.Range = n;
            ViewBag.Counter = numerProby;
        }
    }
}
