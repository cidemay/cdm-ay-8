using System;

namespace BankProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            //yeni bir customer oluşturmak istiyorum.

            Customer customer = new Customer();

            customer.Code = 120355;

            customer.Name = "cigdem";

            customer.SurName = "Ay";

            customer.CreditNote = 2.76;

            customer.NationalIdentity = 123456;

            CustomerManager customerManager = new CustomerManager();

            int creditAmount = customerManager.CustomerCredit(customer);

            Console.WriteLine(customer.Code + "müşteri numarasına sahip" + customer.Name + customer.SurName + "banka müşterimiz bankamızdan" + Convert.ToDouble(creditAmount) + "TL tutarında kredi alabilir.");

            /*Hesaplanan kredi tutarının %7'si vergi
             Hesaplanan kredi tutarının %8'i dosya masrafı
            Hesaplanan kredi tutarının %2'si sigorta olarak tahsil edilir. Kalanı ise, hesaba geçecek tutardır.
             */

            double vergiTutari = creditAmount * 7 / 100;
            double dosyaMasrafi = creditAmount * 8 / 100;
            double sigortaTutari = creditAmount * 2 / 100;
            Console.WriteLine ("----Masraflar----");

            Console.WriteLine("VergiTutari(%7):" + vergiTutari + "TL");

            Console.WriteLine("DosyaMasrafi(%0.8)" + dosyaMasrafi + "TL");

            Console.WriteLine("SigortaMasrafi(%2)" + sigortaTutari + "TL");

            Console.WriteLine("---sonuc---");

            double totalAmount = Convert.ToDouble(creditAmount) - (vergiTutari + dosyaMasrafi + sigortaTutari);

            Console.WriteLine("masraflar düşürüldükten sonra hesabınıza aktarılacak tutar:" + totalAmount + "TL");











        }



    }
}
