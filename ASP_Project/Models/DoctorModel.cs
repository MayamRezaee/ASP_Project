using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Project.Models
{
    public class DoctorModel
    {
        public static string CheckTemp(int temp)
        {
            // What happen if user input is more or equal to 38
            if (temp >= 38)
                return "Your body temperature is " + temp+ " degrees Celsius. It means you have fever, visit a doctor. ";
            // What happen if user input is less or equal to 35
            else if (temp <= 35)
                return "Your body temperature is " + temp + " degrees Celsius. It means you have hypothermia, visit a doctor. ";
            // What happen if user input is between 35-38
            else
                return "Your body temperature is " + temp + " degrees Celsius. It looks that you have no fever or hypothermia.";
        }
    }
}
