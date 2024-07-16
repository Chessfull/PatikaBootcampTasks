using System;

namespace Practises
{
    internal class SimpleInputPractises
    {
        public void Task() {
            /*Kullanıcıya T.C Kimlik Numarasını, adını, soyadını , telefon numarasını, 
                yaşını, ilk aldığı ürünün fiyatını, ikinci aldığını ürünün fiyatını soran
                ve bu değerleri kullanıcıdan sırasıyla alan bir uygulama kodlayınız. 
                Ek : Telefon Numarası ve Son aldığı ürün fiyatı verilerini saklamak için hangi 
                veri tiplerini kullandığınızı nedeniyle yorum satırı olarak ekleyiniz.
                 */

            //Input part from user
            Console.WriteLine("Please fill in the informations below.");

            Console.Write("Your Identity Number:");
            long userIdentity = Convert.ToInt64(Console.ReadLine());

            Console.Write("Your name:");
            string userName = Console.ReadLine();

            Console.Write("Your surname:");
            string userSurname = Console.ReadLine();

            Console.Write("Your phone:");
            long userPhoneNumber = Convert.ToInt64(Console.ReadLine()); //We defined phone number as 'long' cause of int32 max limit.

            Console.Write("Your age:");
            int userAge = Convert.ToInt32(Console.ReadLine());

            Console.Write("First product price you bought:");
            double firstProductPrice = Convert.ToDouble(Console.ReadLine());

            Console.Write("Second product price you bought:");
            double secondProductPrice = Convert.ToDouble(Console.ReadLine()); //We defined product prices as 'double' cause of possibility of .float

            //Discount calculation part
            double totalPurchase = firstProductPrice + secondProductPrice;
            float discount = 0.10f;
            double totalPayment = Math.Round(totalPurchase * discount);

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"Record created for {userName} {userSurname} whose identity number is {userIdentity}.");
            Console.WriteLine($"Notification was sent to his phone number {userPhoneNumber}.");
            Console.WriteLine($"After these purchases he gain 10 percent discount that is {totalPayment} TL.");
            // Note: Did not focus user input errors like 'qwdqwd' number inputs for this segment.
        }
    }
}
