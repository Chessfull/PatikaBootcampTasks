using System;

namespace Practises
{
    internal class MethodPractises
    {
        //1.
        public void FavouriteLyrics()
        {
            Console.WriteLine("Lyric from song: 'It was a big-big world, but we thought we were bigger'");
        }
        
        //2.
        public void RemainFromDivTwo()
        {
            Random randomNumber = new Random();
            int num = randomNumber.Next();
            Console.WriteLine("Random number is:{0} Remain from division by 2 : {1}",num,num % 2);
        }
        
        //3.
        public int Multipy(int number1, int number2)
        {
            return number1 * number2;

        }

        //4.
        public void Greeting(string name, string surName)
        {
            Console.WriteLine($"Welcome {name} {surName} !");
        }

        /* Task:
        1-Geriye Değer Döndürmeyen Bir void metot.
        Ekrana sevdiğiniz bir şarkı sözünü yazdırsın. 
        2-Geriye Tamsayı Döndüren Bir metot
        Rastgele bir sayı üretip bu sayının 2'ye bölümünden kalanı geriye döndürsün.
        3-Parametre Alan ve Geriye Değer Döndüren Bir Metot
        Parametre olarak aldığı iki sayının çarpımını geriye dönsün.
        4-Parametre Alan ve Geriye Değer Döndürmeyen bir Metot
        Parametre olarak isim ve soyisim bilgilerini alıp " Hoş Geldiniz {isim} {soyisim} " şeklinde ekrana bassın.
         */
    }
}
