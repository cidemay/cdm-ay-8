using System;

namespace Application1
{
    public class Program
    {
        static void Main(string[] args)
        {
            string Hizmetler ="Hizmetler";

           Console.WriteLine(Hizmetler);

            bool isvalid_tcno = true;
            if (isvalid_tcno)
            {
                /*Kontrol sağlanırsa çalışacak kodlar*/
            }
            else if (true)
            {
                /*2.kontrol sağlanırsa çalışacak kodlar*/
            }
            else
            {
                /*Kontrol sağlanmazsa çalışacak kodlar*/
            }


            double dolarBugun = 8.64;
            double dolarDun = 8.60;

            if( dolarDun>dolarBugun)
            {
                Console.WriteLine("Düşüş butonu gösterelim.");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Yükseliş butonu gösterelim.");
            }
            else
            {
                Console.WriteLine("Eşitlik butonu gösterelim.");
            }





            double gecmeNotu = 60.51;
            Console.WriteLine("lütfen sınavdan aldığınız notu giriniz");
            double ogrenciNotu = Convert.ToDouble(Console.ReadLine());

            if(ogrenciNotu > gecmeNotu)
            {
                Console.WriteLine("Tebrikler, dersi başarıyla geçtiniz");
            }
            else if(ogrenciNotu < gecmeNotu)
            {
                Console.WriteLine("Maalesef dersten başarısız oldunuz");
            }
            else
            {
                Console.WriteLine("Dersten şartlı geçtiniz");
            }
        }
    }
}
