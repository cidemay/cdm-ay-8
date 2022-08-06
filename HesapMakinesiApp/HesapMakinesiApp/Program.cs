using System;

namespace HesapMakinesiApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoşgeldiniz, lütfen 1.sayıyı yazınız:");
            double sayi1=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Lütfen 2.sayıyı yazınız:");
            double sayi2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine ("Lütfen yapmak istediğiniz işlemi seçiniz:('+', '-', '*', '/')");

            string islem = Console.ReadLine();

            Math math = new Math();
            double calcResult = math.Calc(sayi1, sayi2, islem);
            Console.WriteLine(string.Format("islem sonucu:{0}", calcResult));


        }
    }
}
