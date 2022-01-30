using Microsoft.AspNetCore.Http;
using System;
using System.Linq;

namespace ASP_Project.Models
{
    public class GuessingGameModel
    {
        private static HttpContext _httpContext => new HttpContextAccessor().HttpContext;

        //Guessign game method
        public static string GuessingGame(int GuessNum)
        {
            
            int num = GetNumberFromSession();
            //Generating a random number by system if there is no number
            if (num == -1)
            {
                Random NumBetween1And100 = new Random();
                num = NumBetween1And100.Next(2, 100);
                SetNumberToSession(num);
            }


            int count = GetTryCountFromSession();
            if (count == -1)
            {
                count = 1;
                SetTryCountToSession(count);
            }
            else // increase count by 1 after each user input
            {
                count++;
                SetTryCountToSession(count);
            }

            if (GuessNum < num)
            {
                return $"You should enter a bigger number. You had { count}  wrong guesses unitl now.";
            }

            else if (GuessNum > num)
            {
                return $"Too big number, choose a smaller one.You had { count}  wrong guesses unitl now. ";
            }

            if (GuessNum == num) {
                DeleteNumberFromSession();
                DeleteTryCountFromSession();
                return "Congratulation, you are correct. After " + count + " tries could you guess the correct number, which was "+ num +".";
            }

            return "";
        }

        //Set session
        private static void SetNumberToSession(int value)
        {
            _httpContext.Session.SetString("GuessedNumberSession", Newtonsoft.Json.JsonConvert.SerializeObject(value));
        }

        //Get session 
        private static int GetNumberFromSession()
        {
            if (!_httpContext.Session.Keys.Contains("GuessedNumberSession"))
                return -1; 

            return Newtonsoft.Json.JsonConvert.DeserializeObject<int>(_httpContext.Session.GetString("GuessedNumberSession"));
        }

        //A set session for counting 
        private static void SetTryCountToSession(int value)
        {
            _httpContext.Session.SetString("TryCount", Newtonsoft.Json.JsonConvert.SerializeObject(value));
        }

        //A get session for counting 
        private static int GetTryCountFromSession()
        {
            if (!_httpContext.Session.Keys.Contains("TryCount"))
                return -1; //-1 is a contraction (gharardad)

            return Newtonsoft.Json.JsonConvert.DeserializeObject<int>(_httpContext.Session.GetString("TryCount"));
        }

        //Removing count session after users  correct guess
        public static void DeleteTryCountFromSession()
        {
            _httpContext.Session.Remove("TryCount");
        }

        //Removing GetNumberFromSession() after users correct guess.
        public static void DeleteNumberFromSession() {
            _httpContext.Session.Remove("GuessedNumberSession");
        }

    }
}
