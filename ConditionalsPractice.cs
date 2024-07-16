using System;

namespace Practises
{
    internal class ConditionalsPractice
    {
        //I called this method in my main structre in my 'Practises' folder.
        public void Task()
        {
            Console.Write("Please write your number that you want know position of '10' and is even/odd?:");
            var userValue = int.Parse(Console.ReadLine()); 
            //position to 10
            if (userValue == 10)
            {
                Console.WriteLine("Your input is equal to 10.");
            }
            else if (userValue < 10) {
                Console.WriteLine("Your input is less than 10.");
            }
            else
            {
                Console.WriteLine("Your input is grater to 10.");
            }
            //checking even/odd
            if (userValue % 2 == 0)
            {
                Console.WriteLine("And also your number is even.");
            }
            else {
                Console.WriteLine("And also your number is odd.");
            }
            //Note: This practice is not about error handling and single responsibility, just focusing two things above
        }
    }
}
