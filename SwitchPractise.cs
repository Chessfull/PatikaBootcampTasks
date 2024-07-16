using System;

namespace Practises
{
    internal class SwitchPractise
    {
        public void Task()
        {
            //Greeting
            Console.WriteLine("Welcome to dream grocer! Prices below!");
            Console.WriteLine("**************************************\nApple: 2 TL\nPear: 3 TL\nStrawberry:2 TL\nBanana: 3 TL\nOthers fruits: 4 TL");
            //User Input
            Console.Write("Which fruit do you want buy from list above?:");
            string userChoice = Console.ReadLine(); //This practice is not about error handling or single responsibility.
            //Price check and announce with 'switch'
            switch (userChoice)
            {
                case "Apple":
                    Console.WriteLine($"Switch Result:\nThe fruit price you choose {userChoice} is 2 Turkish Liras");
                    break;
                case "Pear":
                    Console.WriteLine($"Switch Result:\nThe fruit price you choose {userChoice} is 3 Turkish Liras");
                    break;
                case "Strawberry":
                    Console.WriteLine($"Switch Result:\nThe fruit price you choose {userChoice} is 2 Turkish Liras");
                    break;
                case "Banana":
                    Console.WriteLine($"Switch Result:\nThe fruit price you choose {userChoice} is 3 Turkish Liras");
                    break;
                default:
                    Console.WriteLine("Switch Result:\nOther fruit prices is 4 Turkish Liras");
                    break;
            }
            //Price check and announce with 'if/else'
            if (userChoice == "Apple")
            {
                Console.WriteLine($"IF Result:\nThe fruit price you choose {userChoice} is 2 Turkish Liras");
            }
            else if (userChoice == "Pear")
            {
                Console.WriteLine($"IF Result:\nThe fruit price you choose {userChoice} is 3 Turkish Liras");
            }
            else if (userChoice == "Strawberry")
            {
                Console.WriteLine($"IF Result:\nThe fruit price you choose {userChoice} is 3 Turkish Liras");
            }
            else if (userChoice == "Banana")
            {
                Console.WriteLine($"IF Result:\nThe fruit price you choose {userChoice} is 3 Turkish Liras");
            }
            else
            {
                Console.WriteLine("IF Result:\nOther fruit prices is 4 Turkish Liras");
            }

            //Task note: In these scenarios like above (fix and small data lists) 'switch' usage is better.
            //And also if possible combining with enum and switch is more better.
        }
    }
}
