using MethodProject;
using System;

namespace NYP01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. kullanım
            Product product = new Product();
            product.Id = 1;
            product.CategoryId = 1;
            product.ProductName = "makarna 500gr.";
            product.UnitPrice = 7.95;
            product.UnitInStock = 600;


            // 2.Kullanım

            Product product2 = new Product { Id=2, CategoryId=1, ProductName="çikolata", UnitPrice=3.99, UnitInStock=1000 }; ;

            CartManager cart = new CartManager();

            cart.UrunEkle("çilek", "yerli çilek", 12.95, 11278);


            ProductManager productManager = new ProductManager();
            productManager.Add(product);
            Console.WriteLine(product.ProductName);

            int number1 = 500;
            productManager.TestMethod(number1);
            Console.WriteLine(number1);

            //Burada IslemYap sonucunu kullanmak istesem

            productManager.IslemYap(9, 5);

            //Bu hesaplamayı burada ver desem

            int islemSonucu = productManager.IslemYapWithReturn(2, 6);
            Console.WriteLine(islemSonucu * 10);



         }
    }
}
