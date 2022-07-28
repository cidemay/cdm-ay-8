using System;
using System.Collections.Generic;
using System.Text;

namespace MethodProject
{
    public class CartManager
    {
        public void Insert(Product product)
        {
            Console.WriteLine("seçtiğiniz ürün başarıyla sepete eklendi:" + product.ProductName);
        }
        public void UrunEkle(string ProductName, string ProductDescription)
        {
            Console.WriteLine("seçtiğiniz ürün başarıyla sepete eklendi:" + ProductName);
        }
    }   




}
