using System;

namespace Practises
{
    internal class DoWhilePractises
    {
        public void Task()
        {
            /*
            Bu pratikte aynı sorunun cevabını hem while hem de do-while ile kodlamanız ve örnek girdilerde ikisi arasındaki farkı irdelemeniz bekleniyor.
            Kullanıcının girdiği bir limit değerine kadar 0'dan bir sayaç çalıştırıp artırarak, ekrana " Ben bir Patika'lıyım " yazdırınız.
            ( Sayacınız 0'dan başlayarak 1'er 1'er artacak, koşulunuz ( Sayac <= Limit ) )
            Örnek inputlar : 10 ve -5
            Uygulama testi sonrası while ve do-while arasındaki farkı yorum satırı olarak kodunuzun altına ekleyiniz.*/
            
            //Defines and userInput
            string textVar = "Ben bir Patikalıyım!";
            Console.WriteLine("Please give us number that you want repeat and see times as {0}",textVar);
            int userInput=Convert.ToInt32(Console.ReadLine());
            int i = 0;

            //Do While version:
            Console.WriteLine("With 'do while': ");
            do {
                Console.WriteLine(textVar);
                i++;
            } while(i<userInput);

            //While version:
            Console.WriteLine("With 'while': ");
            i = 0;
            while (i < userInput)
            {
                Console.WriteLine(textVar);
                i++;
            }
            //Conclusion: With sample input like '-5' difference between 'do while' and 'while' loop is more obvious. 
            //Do While loop 'always works at least once'. Because firstly 'do' then 'condition'.
        }
    }
}
