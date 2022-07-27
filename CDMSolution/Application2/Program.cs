using System;

namespace Application2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ogrenciNumaralari = new int[] { 10012809, 10012935, 10013645 };

            foreach(var ogrenciNo in ogrenciNumaralari)
            {
                Console.WriteLine(ogrenciNo);
            }

        }
    }
}
