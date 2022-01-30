using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ASP_Project.Controllers
{
    public class DoctorController : Controller
    {

        public IActionResult CheckTemperature()
        {
            return View();
        }

        //Check Temperature 
        [HttpPost]
        public IActionResult CheckTemperature(int temp)
        {
            
            ViewBag.Message = Models.DoctorModel.CheckTemp(temp);
            return View();

        }
    }
}
