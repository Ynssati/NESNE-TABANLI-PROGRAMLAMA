using System;

namespace StaticOrnegi
{
    class Program
    {
        // Nokta sınıfı Program sınıfının içinde tanımlanıyor.
        class Nokta
        {
            private int x, y;
            private static int noktaSayisi = 0;

            public Nokta()
            {
                this.x = 0;
                this.y = 0;
                noktaSayisi++;
            }

            public Nokta(int x, int y)
            {
                this.x = x;
                this.y = y;
                noktaSayisi++;
            }

            public static int NoktaSayisi()
            {
                return noktaSayisi;
            }
        }

        static void Main(string[] args)
        {
            // Üç adet nokta nesnesi oluşturuluyor
            Nokta nokta1 = new Nokta();
            Nokta nokta2 = new Nokta(5, 10);
            Nokta nokta3 = new Nokta(3, 7);

            // Kaç nokta oluşturulduğu yazdırılıyor
            Console.WriteLine("Toplam Nokta Sayısı: " + Nokta.NoktaSayisi());

            // Konsolun kapanmaması için bekletiliyor
            Console.ReadLine();
        }
    }
}
