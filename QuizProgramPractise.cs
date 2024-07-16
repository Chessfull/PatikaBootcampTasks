using System;

namespace Practises
{
    internal class QuizProgramPractise
    {
        public void Task()
        {
            //Task: 1 million prize quiz abot 3 question 2 answer choice, you should know 2 of 3 for winning.
            
            //Greeting
            Console.WriteLine("Welcome to the 1 million quiz show! You have 3 questions with 2 answer choice and if you know 2 of 3 you will win!\nLet's start!");
            
            //For tracking count of true
            byte countTrue=0;
            
            //Question and answer management
            string firstQuestion = "Biggest planet in solar system?\nA:Mercury B:Jupiter\nYour answer A or B:?";
            Console.WriteLine("Your first question is {0}",firstQuestion);
            string firstAnswer = Console.ReadLine();
            string secondQuestion = "Fastest animal in planet?\nA:Peregrine Falcon B:Slat\nYour answer A or B:?";
            Console.WriteLine("Your second question is {0}", secondQuestion);
            string secondAnswer = Console.ReadLine();
            secondAnswer = secondAnswer.ToUpper();
            firstAnswer = firstAnswer.ToUpper();
            string thirdQuestion = "Best bootcamp in developer industry?\nA:Patika+ B:Others together\nYour answer A or B:?";
            
            //Counting true
            if (firstAnswer == "B")
            {
                countTrue += 1; 
            }
            if (secondAnswer == "A")
            {
                countTrue += 1;
            }

            //Checking win if need third question or not
            if (countTrue == 2)
            {
                Console.WriteLine("You already won the prize in 2 question!!!");
                Environment.Exit(0);
            }

            //Checking true if need third question or zero chance
            if (countTrue == 0)
            {
                Console.WriteLine("Unfortunately your both answers is wrong and no need to see third one :( Next time please!");
                Environment.Exit(0);
            }
            //If still possible for winning asking third and check win or almost
            else
            {
                Console.WriteLine("Your third question is {0}", thirdQuestion);
                string thirdAnswer = Console.ReadLine();
                thirdAnswer = thirdAnswer.ToUpper();
                if (thirdAnswer == "A")
                {
                    Console.WriteLine("Cong !!! You won 1 million !!! Go use this for humanity not for pleasurity !!!");
                }
                else
                {
                    Console.WriteLine("Unfortunately almost! 1 of 3! Next time please!");
                }
            }

            //Note: This task is not about error handling, single responsibility. So not checking input, format exceptions etc...
        }
    }
}
