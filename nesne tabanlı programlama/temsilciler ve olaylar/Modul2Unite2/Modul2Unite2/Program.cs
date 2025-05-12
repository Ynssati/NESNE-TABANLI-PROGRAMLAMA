using System;
using System.Collections.Generic;
using System.Threading;

namespace Uygulama
{
    class Urun
    {
        public string Ad { get; set; }
        public decimal Fiyat { get; set; }

        public Urun(string ad, decimal fiyat)
        {
            Ad = ad;
            Fiyat = fiyat;
        }
    }

    class Sepet
    {
        public List<Urun> Urunler { get; private set; } = new List<Urun>();

        public event EventHandler UrunEklendi;

        public void UrunEkle(Urun urun)
        {
            Urunler.Add(urun);
            UrunEklendi?.Invoke(this, EventArgs.Empty);
        }

        public decimal ToplamTutar()
        {
            decimal toplam = 0;
            foreach (var urun in Urunler)
                toplam += urun.Fiyat;
            return toplam;
        }
    }

    class Makine
    {
        public event EventHandler SicaklikArtti;
        private bool calisiyor = true;
        private Random rnd = new Random();

        public void Calistir()
        {
            while (calisiyor)
            {
                int sicaklik = rnd.Next(900, 1100);
                Console.WriteLine($"[Makine] Anlık Sıcaklık: {sicaklik}°C");
                if (sicaklik > 1000)
                {
                    SicaklikArtti?.Invoke(this, EventArgs.Empty);
                }
                Thread.Sleep(1000);
            }
        }

        public void Kapat()
        {
            calisiyor = false;
            Console.WriteLine("[Makine] Makine kapatıldı.");
        }
    }

    class Program
    {
        static void Main()
        {
            // Ürün ve Sepet işlemleri
            Sepet sepet = new Sepet();
            sepet.UrunEklendi += (sender, args) =>
            {
                Console.WriteLine($"[Sepet] Toplam Tutar: {((Sepet)sender).ToplamTutar():C}");
            };

            Console.WriteLine("=== Ürün Ekleme İşlemi ===");
            while (true)
            {
                Console.Write("Ürün adı girin (çıkmak için 'q'): ");
                string ad = Console.ReadLine();
                if (ad.ToLower() == "q") break;

                Console.Write("Fiyat girin: ");
                if (decimal.TryParse(Console.ReadLine(), out decimal fiyat))
                {
                    sepet.UrunEkle(new Urun(ad, fiyat));
                }
                else
                {
                    Console.WriteLine("Geçersiz fiyat girdiniz!");
                }
            }

            Console.WriteLine("\n=== Sepet İşlemi Tamamlandı ===\n");

            // Makine sıcaklık işlemi
            Console.WriteLine("=== Makine Sıcaklık Kontrolü Başlatılıyor ===");

            Makine makine = new Makine();
            makine.SicaklikArtti += (sender, args) =>
            {
                Console.WriteLine("[UYARI] Sıcaklık 1000°C üzerine çıktı! Makine kapatılıyor...");
                ((Makine)sender).Kapat();
            };

            makine.Calistir();

            Console.WriteLine("\nProgram sona erdi.");
        }
    }
}
