using System;
using System.Collections.Generic;
using System.Text;

namespace HesapMakinesiApp
{
    public class Math
    {
        public double Calc(double sayi1, double sayi2, string islem)
        {
            double sonuc = 0;
            switch (islem)
            {
                case "+":
                    sonuc = sayi1 + sayi2;
                    break;
                 case "-":
                    sonuc = sayi1 - sayi2;
                    break;
                case "*":
                    sonuc = sayi1 * sayi2;
                    break;

                case "/":
                    sonuc = sayi1 / sayi2;
                    break;

                default: 

                    sonuc = 0;

                    break;

            }

            return sonuc;
        }

    }
}
