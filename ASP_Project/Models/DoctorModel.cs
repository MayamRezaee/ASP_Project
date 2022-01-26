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
            
            if (temp >= 38)
                return "Your body temperature is " + temp+ " degrees Celsius. It means you have fever, visit a doctor. ";
            else if (temp <= 35)
                return "Your body temperature is " + temp + " degrees Celsius. It means you have hypothermia, visit a doctor. ";
            else 
                return "Your body temperature is " + temp + " degrees Celsius. It looks that you have no fever or hypothermia.";
        }
    }
}
