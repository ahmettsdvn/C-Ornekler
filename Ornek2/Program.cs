using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // dizi tanımlayalım.

            int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] sayilar1 = new int[10];

            sayilar1[0] = 1;
            sayilar1[1] = 2;
            sayilar1[2] = 3;
            // ...

            // sayilar1 dizisinde ilk 3 elemanı tanımladık.
            // geri kalan elemanlar için 0 atar (int'in default değeri)

            int[] sayilar2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // dizinin elemanlarına erişim
            var eleman = sayilar[0]; // 1. elemana erişim. Yani 0.indis

            // dizinin elemanlarını ekrana yazdıralım.
            Console.WriteLine("Dizinin elemanı:" + eleman);

            // tüm elemanları ekrana yazdıralım.
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine("Dizinin " + i + ". elemanı: " + sayilar[i]);
            }

            // foreach döngüsü ile dizi elemanlarını yazdıralım.
            foreach (var item in sayilar)
            {
                Console.WriteLine("Dizinin elemanı: " + item);
            }

            // sayilar1 dizisinin elemanlarını yazalım
            Console.WriteLine("sayilar1 dizisinin elemanları:");
            Console.WriteLine("-------------------------");
            foreach (var item in sayilar1)
            {
                Console.WriteLine("sayilar1 dizisinin elemanı: " + item);
            }

            // bir dizinin elemanlarını konoldan alalım
            int[] sayilar3 = new int[5];
            for (int i = 0; i <= sayilar3.Length - 1; i++)
            {
                Console.Write("Lütfen dizinin " + i + ". elemanını giriniz: ");
                sayilar3[i] = Convert.ToInt32(Console.ReadLine());
            }

            // SAYİLAR3 YAZDIR
            Console.WriteLine("sayilar3 dizisinin elemanları:");
            foreach (var item in sayilar3)
            {
                Console.WriteLine("sayilar3 dizisinin elemanı: " + item);

            }

            // Liste tanımı
            List<int> sayiListesi = new List<int>(); // boş liste tanımı
            List<int> sayiListesi2 = new List<int>() { 1, 2, 3, 4, 5 }; // elemanlı liste tanımı
            var liste = new { A = 1, B = 2 };

            // listeye eleman ekleme
            sayiListesi.Add(10);
            sayiListesi.Add(20);


            // listenin elemanlarını yazdıralım

            Console.WriteLine("sayiListesi elemanları:");
            foreach (var item in sayiListesi)
            {
                Console.WriteLine("sayiListesi elemanı: " + item); // 10,20
            }

            Console.ReadLine();
        }
    }
}