using System;

namespace kutulamaOrnegi
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int sayi = 42;
            Console.WriteLine("int değeri: " + sayi);

            object kutuluDeger = sayi;
            Console.WriteLine("Boxed değer (object): " + kutuluDeger);

           
            int cozulmusDeger = (int)kutuluDeger;
            Console.WriteLine("Unboxed değer (int): " + cozulmusDeger);

           
            if (kutuluDeger is int)
            {
                Console.WriteLine("kutuluDeger bir int türündedir.");
            }

            // as işleci ile dönüştürme (uygunsa)
            object metin = "Merhaba Dünya";
            string yazi = metin as string;

            if (yazi != null)
            {
                Console.WriteLine("as işleci sonucu: " + yazi);
            }

            // is işleci ile farklı tür kontrolü
            if (metin is string)
            {
                Console.WriteLine("metin değişkeni string türündedir.");
            }
        }
    }
}
