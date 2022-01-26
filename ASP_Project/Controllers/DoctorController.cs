using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ASP_Project.Controllers
{
    public class DoctorController : Controller
    {
       /* public IActionResult Index()
        {
            return View();
        }*/

        public IActionResult CheckTemperature()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CheckTemperature(int temp)
        {
            //ViewBag.Message = "Your body temperature is, " + temp + " degrees Celsius"; 
            ViewBag.Message = Models.DoctorModel.CheckTemp(temp);
            return View();

        }
    }
}
