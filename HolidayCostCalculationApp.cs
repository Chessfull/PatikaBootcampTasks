using System;

namespace Practises
{
    internal class HolidayCostCalculationApp
    {
        public void Task()
        {
            //Greeting
            Console.WriteLine("Welcome to the holiday cost calculator Sir/Madam !\n");
            
            //Global variable defining
            string userChoice;
            int priceBodrum = 4000;
            int priceMarmaris = 3000;
            int priceCesme = 5000;
            int priceTotal = 0;
            bool choiceBoolean;
            int countPeople = 0;
            bool countPeopleError;
            string bodrumFacilities = "-Boat Tour\n-City Tour";
            string marmarisFacilities = "-Mountain Tour\n-Parachute Experience";
            string cesmeFacilities = "-Walking\n-Best Hotels";
            bool TransportationBoolean;
            string userTransportationChoose;
            string repeatAsking;

            //For 'asking calculation again possibility' all processes in 'do while' scope.
            do
            {
                //Taking location prefer, if out of alternatives repating with 'do while' as using 'choiceBoolean'.
                Console.WriteLine("You can see alternatives and start packing price of locations below:");
                Console.WriteLine("Bodrum - 4000 TL\nMarmaris - 3000 TL\nÇeşme - 5000 TL\n");
                Console.Write("Please make your choice:");
                userChoice = Console.ReadLine().ToLower();
                choiceBoolean = userChoice == "bodrum" || userChoice == "çeşme" || userChoice == "marmaris";
                while (!choiceBoolean)
                {
                    Console.Write("\nWrong or out of list. Please make your choice again: ");
                    userChoice = Console.ReadLine().ToLower();
                    choiceBoolean = userChoice == "bodrum" || userChoice == "çeşme" || userChoice == "marmaris";
                }
                
                //After taking right location, adding total price with switch management.
                switch (userChoice)
                {
                    case "bodrum":
                        priceTotal += priceBodrum;
                        break;
                    case "marmaris":
                        priceTotal += priceMarmaris;
                        break;
                    case "çeşme":
                        priceTotal += priceCesme;
                        break;
                    default:
                        break;
                }
                
                /*Taking person count for total price and giving total info as well.
                Doing this person count process with 'do while' for basic error handling like not integer input*/ 
                do
                {
                    Console.Write("\nCould you please say how many people is going holiday with you?:");
                    countPeopleError = int.TryParse(Console.ReadLine(), out countPeople); //Taking boolean with using 'TryParse' for basic error handling
                    //If user input is integer keep going
                    if (countPeopleError)
                    {
                        if (userChoice == "bodrum")
                        {
                            Console.WriteLine($"\nWell Done! You chose {userChoice} for holiday with {countPeople} person.Let me show facilities of {userChoice}:");
                            Console.WriteLine(bodrumFacilities);
                        }
                        else if (userChoice == "marmaris")
                        {
                            Console.WriteLine($"\nWell Done! You chose {userChoice} for holiday with {countPeople} person.Let me show facilities of {userChoice}:");
                            Console.WriteLine(marmarisFacilities);
                        }
                        else if (userChoice == "çeşme")
                        {
                            Console.WriteLine($"\nWell Done! You chose {userChoice} for holiday with {countPeople} person.Let me show facilities of {userChoice}:");
                            Console.WriteLine(cesmeFacilities);
                        }
                    }
                }while (!countPeopleError); //If user input is not integer go start with 'do while' block again
                
                //For checking right input for transportation choose with 'do while' similar above
                do
                {
                    Console.WriteLine("\nSo which transportation way do you prefer with prices below?\n1-Highway: round trip 1500 TL Per person\n2-Airline: round trip 4000 TL Per person.");
                    Console.Write("Choose (1 or 2 please) ");
                    userTransportationChoose = Console.ReadLine();
                    TransportationBoolean = (userTransportationChoose == "1" || userTransportationChoose == "2");//Checking user input 1 or 2
                } while (!TransportationBoolean);//if not 1 or 2 keep loop with do, if 1 or 2 go to if management below
                if (userTransportationChoose == "1")
                {
                    priceTotal += 1500 * countPeople;
                    Console.WriteLine($"\nAs final: You chose to go {userChoice} with {countPeople} person and Highway. Your total cost for this holiday: {priceTotal} TL ");
                }
                else if (userTransportationChoose == "2")
                {
                    priceTotal += 4000 * countPeople;
                    Console.WriteLine($"\nAs final: You chose to go {userChoice} with {countPeople} person and Highway. Your total cost for this holiday: {priceTotal} TL ");
                    
                }
                Console.Write("Do you want calculation of another holidays? (Yes or No please)");
                repeatAsking = Console.ReadLine().ToLower();
            } while (repeatAsking=="yes");//If user input is yes go to 'do loop that top of codes (start over)'

            Console.WriteLine("Thanks for the visiting us!");
        }
        /*Readme:
        Bu pratikte bir yardımcı seyehat uygulaması ile kullanıcılarımızın planlayacakları 3 günlük bir tatilde harcayacakları yaklaşık tutarı hesaplamalarına yardımcı oluyoruz.
        3 adet lokasyonumuz var:
        1 - Bodrum (Paket başlangıç fiyatı 4000 TL)
        2 - Marmaris (Paket başlangıç fiyatı 3000 TL)
        3 - Çeşme (Paket başlangıç fiyatı 5000 TL)
        Kullanıcımıza gitmek istediği lokasyonu sormalıyız. Bu noktada Büyük-Küçük harf duyarlılığını ortadan kaldırmalı eğer yukarıdaki 3 seçenek dışında bir lokasyon girilirse bir hata olduğunu söylemeli, girebileceği lokasyon isimlerini hatırlatmalı ve yeniden bir veri girmesini istemeliyiz.
        Kullanıcının girdiği veriyi bir değişkende tutalım.
        Kullanıcıya kaç kişi için tatil planlamak istediğini soralım.
        Kişi sayısını bir değişkende tutalım.
        Ardından gitmek istenilen lokasyon ve o lokasyonda tatili sırasında yapabilecekleri ile ilgili bir özet bilgiyi ekrana yazdırmalıyız.
        Kullanıcıya tatiline ne şekilde gitmek istediğini sorarak aşağıdaki seçenekleri gösterelim..
        2 seçeneğimiz var:
        1 - Kara yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL )
        2 - Hava yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)
        " Lütfen yukarıdaki seçeneklerden bir tanesini seçiniz diyerek cevabı kullanıcıdan "1" ya da "2" olarak alalım, farklı bir değer girilmesi durumunda bir hata olduğunu söyleyerek soruyu yeniden yöneltelim.
        Ardından gidilecek lokasyon, kişi sayısı ve ulaşım aracı seçenekleriyle bir toplam fiyat hesaplayıp bunu kullanıcıya sunalım.
        Kullanıcıya başka bir tatil planlamak isteyip istemediğini soralım, istiyorsa uygulama ilk aşamadan çalışmaya başlayabilir, kullanıcı istemiyorsa iyi günler dileyerek uygulamayı sonlandırabiliriz. 
         */
    }
}
