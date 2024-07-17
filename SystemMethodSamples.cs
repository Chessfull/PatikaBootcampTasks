using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practises
{
    internal class SystemMethodSamples
    {
        int number = -10;
        string text = "Mert";
        DateTime currentDate = DateTime.Now;

        public void MathMethods()
        {
            Console.WriteLine($"Absolute Value of {number} : " + Math.Abs(number));
            Console.WriteLine($"Square Root of {number} : " + Math.Sqrt(number));
            Console.WriteLine($"Power of 3, {number} : " + Math.Pow(number, 3));
            Console.WriteLine($"Min and max , {number} and {number + 5} : " + Math.Min(number, number + 5) + Math.Max(number, number + 5));
            Console.WriteLine($"Round of {number} : " + Math.Round((double)number));
            Console.WriteLine($"Floor and Ceiling of {number} : " + Math.Floor((double)number) + Math.Ceiling((double)number));
        }
        public void StringMethods()
        {
            string upperCaseText = text.ToUpper();
            string lowerCaseText = text.ToLower();
            string subText = text.Substring(3, 7); //>>> starting from 3 index to 7
            bool contains = text.Contains("e"); //>>> checking contains of 'e' in string
            string replacedText = text.Replace("Mert", "Topcu"); //>>> Replacing 'Mert' with 'Topcu'
            string[] seperating = text.Split(','); //>>> For seperating each value like 'M,E,R,T' with new list
            string trimmedText = text.Trim(); //>>> Clearing spaces in the beginning and end of string
        }
        public void DatetimeMethods()
        {
            DateTime currentTime = DateTime.Now; //Now as time
            DateTime today = DateTime.Today;
            DateTime futureDate = currentDate.AddDays(7); //Adding 7 days to today
            DateTime nextMonth = currentDate.AddMonths(1); //Adding 1 month to current month
            DateTime nextYear = currentDate.AddYears(1); //Adding 1 year to current year

            //For calculating differences between two dates
            DateTime startDate = new DateTime(2024, 6, 1);
            DateTime endDate = new DateTime(2024, 6, 10);
            TimeSpan difference = endDate.Subtract(startDate);

            //Casting string to DateTime
            string dateString = "2024-06-11";
            DateTime date = DateTime.Parse(dateString);

            //Casting DateTime to string
            DateTime cuırrentDate = DateTime.Now;
            string formattedDate = date.ToString("dd/MM/yyyy HH:mm:ss");
        }
    }
}
