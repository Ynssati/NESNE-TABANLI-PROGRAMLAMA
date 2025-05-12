using System;

namespace refOrnegi
{
    class Program
    {
      
        static void DegerArtir(ref int sayi)
        {
            sayi = sayi + 1;
        }

        static void Main(string[] args)
        {
            int deger = 5; 
            DegerArtir(ref deger); 
            Console.WriteLine("Yeni değer: " + deger); 
            Console.ReadLine(); 
        }
    }
}
