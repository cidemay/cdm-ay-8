using System;

namespace ClassProject
{
    public class Program
    {
        static void Main(string[] args)
        {
           


            Personel personel1=new Personel();
            personel1.PersonelAdSoyad ="Çiğdem Ay";
            personel1.PersonelTC = 1234567834834;
            personel1.PersonelAdres = "Çiçek sok. No:71/C";
            personel1.PersonelDogumTarihi = new DateTime(1988, 12, 4);
            personel1.PersonelBasariOrtalama = 9.6;

            /*Console.WriteLine(personel1.PersonelAdSoyad + "" + personel1.PersonelAdres);*/ // comment line alalım 

            // array mantığı ile yaparsak;

            Personel[] personeller = new Personel[] { personel1 };

            foreach (var personel in personeller)
            {
                Console.WriteLine(personel.PersonelAdSoyad+""+personel.PersonelTC+""+personel.PersonelDogumTarihi);
            }

        }

        class Personel
        {
            public string PersonelAdSoyad { get; set; }

            public string PersonelTelefon { get; set; }

            public long PersonelTC { get; set; }

            public string PersonelAdres { get; set; }

            public DateTime PersonelDogumTarihi { get; set; }

            public double PersonelBasariOrtalama { get; set; }
        }
    }
}
