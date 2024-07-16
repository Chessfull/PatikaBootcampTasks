using System;

namespace Practises
{
    internal class WhilePractises
    {
        public void Task()
        {
            /*
            1 -> Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.
            2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.
            3 -> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.
            4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.
            5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.*/

            //1.
            byte i = 0;
            while (i < 10)
            {

                Console.WriteLine("I believe myself! I can do it! I can be impactful software developer!");
                i++;
            }
            //2.
            i = 0;
            Console.WriteLine("Numbers between 1-20: ");
            while (i <= 20)
            {
                Console.WriteLine(i);
                i++;
            }
            //3.
            i = 0;
            Console.WriteLine("Even bumbers between 1-20: ");
            while (i <= 20)
            {
                Console.WriteLine(i);
                i += 2;
            }
            //4.
            i = 50;
            int resultSample = 0;
            Console.WriteLine("Sum of numbers bumbers between 50-150: ");
            while (i <= 150)
            {
                resultSample += i;
                i++;
            }
            Console.WriteLine(resultSample);
            //5.
            i = 0;
            int evenSum = 0;
            int oddSum = 0;
            Console.WriteLine("Sum of numbers even & odd numbers between 1-120 below: ");
            while (i <= 120)
            {
                if (i % 2 == 0)
                {
                    evenSum += i;
                }
                else
                {
                    oddSum += i;
                }
                i++;
            }
            Console.WriteLine($"Sum of odds between 0-120 (inclusive): {oddSum}");
            Console.WriteLine($"Sum of evens between 0-120 (inclusive): {evenSum}");
        }
    }
}
