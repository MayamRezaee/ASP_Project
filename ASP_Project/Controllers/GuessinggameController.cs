using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Project.Controllers
{
    public class GuessinggameController : Controller
    {
        public IActionResult GuessingGame()
        {
            return View();
        }

        //Overloading Action
        [HttpPost]
        public IActionResult GuessingGame(int? GuessNum) // a nullable int
        {
            //what happen if user insert an invalid input
            if(GuessNum == null) 
            {
                ViewBag.Message = "you should enter a number";
            }else //What happen if user's input is a number 
            { 
                ViewBag.Message = Models.GuessingGameModel.GuessingGame(GuessNum.Value);
            }
            return View();

        }

     
    }
}
