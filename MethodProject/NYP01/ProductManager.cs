using System;
using System.Collections.Generic;
using System.Text;

namespace NYP01
{
    internal class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName+"ürününüz başarıyla eklendi"); 
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName+"ürününüz başarıyla güncellendi");
        }

        public void TestMethod(int number1)
        {
            number1 = 499;
        }

        public bool Insertlog()
        {
            return true;
        }

        public void IslemYap(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);
        }

        public int IslemYapWithReturn(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
    }
}
