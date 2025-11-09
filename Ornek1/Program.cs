using System;

namespace HelloWorldApp
{

    class Example
    {

        static void Main(string[] args)
        {
            // iki sayıyı toplayan bir fonksiyon yazalım.
            int sonuc = Topla(3, 5);

            Console.WriteLine("Toplam: " + sonuc);

            // kullanıcıdan iki sayı alıp toplayalım.
            Console.Write("Birinci sayıyı girin: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayıyı girin: ");
            int sayi2 = int.Parse(Console.ReadLine());
            int toplam = Topla(sayi1, sayi2);
            Console.WriteLine("Girilen sayıların toplamı: " + toplam);

            // Bir Listemiz olsun. Bu listeyi ekrana yazdıralım.

            var meyveler = new List<string>()
            {
                "Elma",
                "Muz",
                "Çilek",
                "Karpuz"
            };

            // listeyi yazdıralım

            // foreach döngüsü ile
            // for

            // foreach döngüsü ile

            Console.WriteLine("Meyveler Foreach Döngüsü ile:"); 
            Console.WriteLine("-------------------------");
            foreach (var item in meyveler)
            {
                Console.WriteLine("Meyve Adı: "+item);
            }

            // for döngüsü ile
            Console.WriteLine("Meyveler For Döngüsü ile:");
            Console.WriteLine("-------------------------");
            for (int i = 0; i < meyveler.Count; i++)
            {
                var item = meyveler[i];

                Console.WriteLine("Meyve Adı: " + item);

                //Console.WriteLine("Meyve Adı: " + meyveler[i]);
            }

            // while döngüsü ile
            Console.WriteLine("Meyveler While Döngüsü ile:");
            Console.WriteLine("-------------------------");
            int index = 0;
            while (index < meyveler.Count)
            {
                var item = meyveler[index];
                Console.WriteLine("Meyve Adı: " + item);
                index++;
            }

            // do while döngüsü ile
            Console.WriteLine("Meyveler Do While Döngüsü ile:");
            Console.WriteLine("-------------------------");
            index = 0;
            do
            {
                var item = meyveler[index];
                Console.WriteLine("Meyve Adı: " + item);
                index++;
            } while (index < meyveler.Count);


            int number = 5; // Başlangıç yine pozitif

            do
            {
                Console.WriteLine("DO-WHILE GÖVDE ÇALIŞTI. number = " + number);

                // Koşulu bozuyoruz → döngü hemen bitsin
                number = -1;

            } while (number > 0);

            Console.WriteLine("DO-WHILE: Döngü bitti.");

            Console.ReadKey();

        }

        /// <summary>
        /// iki sayıyı toplayan fonksiyon
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int Topla(int a, int b)
        {
            return a + b;
        }
    }
}