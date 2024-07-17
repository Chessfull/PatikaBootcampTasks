using Microsoft.Win32;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

//This is a practise file for finishing 'week 2 of Bootcamp' about 18 tasks. If you into to read instructions about tasks go bottom of page. Fyi:Instructions are Turkish.
namespace Practises
{
    internal class MixPractises
    {   
        public void SmallTalks()
        {
            //1.Task > Console App that writing small talks
            Console.WriteLine("Hello! ");
            Console.WriteLine("How are you today?");
            Console.WriteLine("Thanks for asking, I'm good.");
            Console.WriteLine("How about you?");
        }
        public void VariableIdentify()
        {
            //2.Task > Variable defining, getting value and printing
            string textSample;
            int numberSample;
            textSample = "Mert";
            numberSample = 10;
            Console.WriteLine(textSample,numberSample);
        }
        public void RandomNumber()
        {
            //3.Task > Random number creating
            Random random = new Random();
            int randomNumber = random.Next(55, 555);
            Console.WriteLine(randomNumber);
        }
        public void RandomNumberDiv()
        {
            //4.Task > Random number creating and remain from 3
            Random random = new Random();
            int randomNumber = random.Next(55, 555);
            Console.WriteLine(randomNumber%2);
        }
        public void AgeChecking()
        {
            //5.Task > Asking user age for 18 condition
            Console.WriteLine("May I ask your age?:");
            int userAge=Convert.ToInt16(Console.ReadLine());
            string overUnder= (userAge > 18) ? "+" : "-";
            Console.WriteLine(overUnder);
        }
        public void repeatinText()
        {
            //6.Task > 10 times repeating text
            for (int i = 0; i < 10; i++) {
                Console.WriteLine(" Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
            }
        }
        
        public void ChangeText()
        {
            //7.Task > Taking 2 text arguments and replace position each these
            Console.WriteLine("Your first text: ");
            string userInput1=Console.ReadLine();
            Console.WriteLine("Your second text: ");
            string userInput2=Console.ReadLine(); 
            Console.WriteLine($"Your texts before process: {userInput1} {userInput2}");
            string tempString = userInput1;
            userInput1=userInput2;
            userInput2 = tempString;
            Console.WriteLine($"Your texts after process: {userInput1} {userInput2}");
        }
        public void NotTurningValue()
        {
            //8.Task > Write a void method and print 'I m void method! I can't return any value'
            Console.WriteLine("I m void method! I can't return any value");
        }
        public int SumTwoNumbers(int number1, int number2)
        {
            //9.Task > Take 2 numbers and sum of these with return method
            return number1 + number2;
        }
        public string BooleanToString(bool userInput)
        {
            //10.Task > Take true or false value from user and cast string
            string inputText = (userInput) ? "True" : "False";
            return inputText;
        }
        public int AgeCompare(int userAge1, int userAge2, int userAge3)
        {
            //11.Task > Take age of 3 person and writeline oldest
            int firstCheck = userAge1 > userAge2 ? userAge1 : userAge2; //if 2 age is equal that we dont except, still one of can be oldest and return is true
            int lastCheck = firstCheck > userAge3 ? firstCheck : userAge3;
            return lastCheck;
        }
        public int LimitlessParameters(params int[] userNumbers) //params is the keyword for undefined parameters count
        {
            //12.Task > Take limitless number from user and print highest also return
            int highestNumber = userNumbers.Max();
            Console.WriteLine("Your highest number in your inputs :{0}",highestNumber);
            return highestNumber;
        }
        public void swapTexts(string userText1, string userText2)
        {
            //13.Task > Take 2 texts from user and change position with method
            Console.WriteLine($"Your texts before process: {userText1} {userText2}");
            string tempText=userText1;
            userText1 = userText2;
            userText2 = tempText;
            Console.WriteLine($"Your texts after process: {userText1} {userText2}");
        }
        public bool IsOddEven(int userNumber)
        {
            //14.Task > Take number from user and return odd or even with method as true/false
            bool oddOrEven = Convert.ToBoolean(userNumber % 2==0 ? "true" : "false");
            return oddOrEven;
        }
        public void CalculateDistance()
        {
            //15.Task > Take speed and time from user then calculate distance
            double userSpeed;
            double userHour;
            //Taking km/h from user
            Console.WriteLine("Please write your speed please as (km/h)");
            bool formatCheck1 = double.TryParse(Console.ReadLine(), out userSpeed);
            //Taking hour from user
            Console.WriteLine("Please write time as hour");
            bool formatCheck2 = double.TryParse(Console.ReadLine(), out userHour);
            if (formatCheck1 && formatCheck2) {
                Console.WriteLine($"Distance is: {userSpeed*userHour}");
            }
            else
            {
                Console.WriteLine("Wrong format.");
            }
        }
        public double CircleArea(double circleDiameter)
        {
            //16.Task > Calculation method that calculates area of circle
            double piNumber=3.14;
            double areaResult= piNumber * Math.Pow(circleDiameter, 2);
            Console.WriteLine("Area of circle: " + areaResult);
            return areaResult;
        }
        public void TextUpperLowerCase()
        {
            //17.Task > Make "Zaman bir GeRi SayIm" sentence bigger and lower case
            string text = "Zaman bir GeRi SayIm";
            Console.WriteLine("With Upper Case: "+text.ToUpper());
            Console.WriteLine("With Lower Case: " + text.ToLower());
        }
        public string trimText(string sampleText= "    Selamlar   ")
        {
            //18.Task > Deleting spaces start and end
            return sampleText.Trim();
        }
    }


    /*
        1 - Aşağıdaki çıktıyı yazan bir program.
        Merhaba
        Nasılsın ?
        İyiyim
        Sen nasılsın ?
        2 - Bir adet metinsel , bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız. Bunların değerlerini atayıp , ekrana yazdırınız.
        3 - Rastgele bir sayı üretip , ekrana yazdırınız.
        4 - Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.
        5 - Kullanıcıya yaşını sorup , 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.
        6 - Ekrana 10 defa " Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.
        7 - Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz.
        8 - Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız. Ekrana "Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" yazsın.
        9 - İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.
        10 - Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.
         11 - 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.
        12 - Kullanıcıdan sınırsız sayıda sayı alıp , bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.
        13- Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.
        14 - Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.
        15 - Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.
        16 - Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.
        17 - "Zaman bir GeRi SayIm" cümlesini alıp , hepsi büyük harf ve hepsi küçük harfle yazdırınız.
        18 - "    Selamlar   " metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.
     */
}
