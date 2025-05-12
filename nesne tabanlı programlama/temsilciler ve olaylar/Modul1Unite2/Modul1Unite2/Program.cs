using System;

namespace DelegateOrnek
{
    class Program
    {
        // 1. Temsilci tanımı (Delegate)
        public delegate void MetotTemsilcisi(ref string[] dizi);

        static void Main(string[] args)
        {
            // 2. Sıralanmamış dizi
            string[] kelimeler = { "Portakal", "Elma", "Armut", "Muz", "Kiraz" };

            Console.WriteLine("Sıralanmamış Dizi:");
            Yazdir(ref kelimeler);

            // 3. Temsilcinin örneğini oluştur
            MetotTemsilcisi temsilci;

            // 4. Tekli çağrım: A-Z sıralama
            temsilci = AzSirala;
            temsilci(ref kelimeler);

            // 5. Tekli çağrım: Z-A sıralama
            temsilci = ZaSirala;
            temsilci(ref kelimeler);

            // 6. Çoklu çağrım: A-Z ve ardından Z-A
            temsilci = AzSirala;
            temsilci += ZaSirala;
            temsilci(ref kelimeler); // Çoklu çağrım

            Console.ReadLine();
        }

        // Metot 1: A-Z sıralama
        static void AzSirala(ref string[] dizi)
        {
            Array.Sort(dizi);
            Console.WriteLine("A-Z Sıralı Dizi:");
            Yazdir(ref dizi);
        }

        // Metot 2: Z-A sıralama
        static void ZaSirala(ref string[] dizi)
        {
            Array.Sort(dizi);
            Array.Reverse(dizi);
            Console.WriteLine("Z-A Sıralı Dizi:");
            Yazdir(ref dizi);
        }

        // Metot 3: Diziyi yazdıran yardımcı metot
        static void Yazdir(ref string[] dizi)
        {
            foreach (string kelime in dizi)
            {
                Console.WriteLine("- " + kelime);
            }
            Console.WriteLine();
        }
    }
}
