using System;

namespace Practises
{
    internal class ForLoopPractises
    {
        public void Task()
        {
            /*1 -> Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.
            2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.
            3 -> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.
            4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.
            5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız. */

            //1.
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("I believe myself! I can do it! I can be impactful software developer!");
            }
            //2.
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine("Numbers between 1-20 : {0}",i);
            }
            //3.
            for (int i = 0; i <= 20; i+=2)
            {
                Console.WriteLine("Even numbers between 1-20 (inclusive): {0}",i);
            }
            //4.
            int sumSample = 0;
            for (int i = 50; i <= 150; i ++)
            {
                sumSample += i;
            }
            Console.WriteLine("Sum of numbers between 50 and 150 (inclusive): {0} ",sumSample);
            //5.
            int oddSum = 0;
            int evenSum = 0;
            for (int i = 0; i <= 120; i ++)
            {
                if (i % 2 == 0)
                {
                    evenSum += i;
                }
                else { 
                    oddSum += i;
                }
            }
            Console.WriteLine($"Sum of odds between 0-120 (inclusive): {oddSum}");
            Console.WriteLine($"Sum of evens between 0-120 (inclusive): {evenSum}");
            //Inclusive >>> both number included between range like 0 and 120 are included...
        }
    }
}

