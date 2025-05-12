using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        // ArrayList koleksiyon sınıfı tanımlanıyor
        ArrayList sayi = new ArrayList();

        // 10 elemanlı dizi tanımlanıyor
        int[] num = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Dizideki elemanlar koleksiyona ekleniyor
        for (int i = 0; i < 10; i++)
        {
            sayi.Add(num[i]);
        }

        // Koleksiyondaki 2. eleman (indeks 2) siliniyor
        sayi.RemoveAt(2); // 3 numarası silinir

        // Koleksiyondaki 5. elemana (indeks 5) yeni değer atanıyor
        // Remove yerine Insert kullanılması veri kaymasına neden olur
        sayi[5] = 2345;

        // Koleksiyondaki mevcut elemanlar ekrana yazdırılıyor
        for (int i = 0; i < sayi.Count; i++)
        {
            Console.WriteLine(sayi[i]);
        }

        // Uygulamanın kapanmaması için bekletme
        Console.ReadLine();
    }
}
