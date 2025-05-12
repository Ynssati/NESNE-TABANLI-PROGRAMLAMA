using System;

namespace SinifOrnegi
{
    class Program
    {
        // Bisiklet sınıfı Program sınıfının içinde tanımlanmıştır
        class Bisiklet
        {
            public int vites;
            public int hiz;
            public int VitesSayisi;

            // Varsayılan kurucu
            public Bisiklet()
            {
                vites = 1;
                hiz = 0;
                VitesSayisi = 5;
            }

            // Parametreli kurucu
            public Bisiklet(int vitesSayisi)
            {
                vites = 1;
                hiz = 0;
                VitesSayisi = vitesSayisi;
            }

            public void VitesDegistir(int yeniVites)
            {
                vites = yeniVites;
            }

            public void Hizlan(int artis)
            {
                hiz += artis;
            }

            public void FrenYap(int azalis)
            {
                hiz -= azalis;
                if (hiz < 0)
                    hiz = 0;
            }

            public void BilgileriYaz()
            {
                Console.WriteLine($"Vites: {vites}, Hız: {hiz}, Vites Sayısı: {VitesSayisi}");
            }
        }

        static void Main(string[] args)
        {
            // Varsayılan kurucu ile bisiklet1 nesnesi
            Bisiklet bisiklet1 = new Bisiklet();
            bisiklet1.VitesDegistir(3);
            bisiklet1.Hizlan(20);
            bisiklet1.FrenYap(5);
            bisiklet1.BilgileriYaz();

            // Parametreli kurucu ile bisiklet2 nesnesi
            Bisiklet bisiklet2 = new Bisiklet(7);
            bisiklet2.VitesDegistir(4);
            bisiklet2.Hizlan(30);
            bisiklet2.FrenYap(10);
            bisiklet2.BilgileriYaz();

            // Metot kullanmadan alan değerlerini değiştirme
            bisiklet1.hiz = 100;
            bisiklet1.vites = 10;
            bisiklet1.BilgileriYaz();

            Console.ReadLine();
        }
    }
}
