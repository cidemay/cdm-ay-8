using System;

namespace MethodProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ProductName = "akıllı  kol saati";

            double ProductPrice = 277.69;

            string ProductDescription = "mi akıllı kol saati";

            Product urun1 = new Product();
            urun1.ProductName = "yogurt 1kg";
            urun1.ProductPrice = 15.98;
            urun1.ProductDescription = "tava yogurt";

            Product urun2 = new Product();
            urun2.ProductName = "toz şeker";
            urun2.ProductPrice = 20.99;
            urun2.ProductDescription = "kristal şeker";

            Product[] products = new Product[] {urun1,urun2};
            foreach (var urun in products)
            {
                Console.WriteLine(urun.ProductName);
                Console.WriteLine(urun.ProductPrice);
                Console.WriteLine(urun.ProductDescription);
                Console.WriteLine("----");
            }



        }
    }
}
