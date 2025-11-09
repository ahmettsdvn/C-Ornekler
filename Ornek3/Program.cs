using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ornek3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Class ve constructor kullanımı

            Araba araba1 = new Araba("Kırmızı", "Toyota", 2020); 
            Araba araba2 = new Araba();
            Araba araba3 = new Araba("Pembe");

            Console.WriteLine($"Araba 1: Renk={araba1.Renk}, Model={araba1.Model}, Yıl={araba1.Yil}");
            Console.WriteLine($"Araba 2: Renk={araba2.Renk}, Model={araba2.Model}, Yıl={araba2.Yil}");
            Console.WriteLine($"Araba 3: Renk={araba3.Renk}, Model={araba3.Model}, Yıl={araba3.Yil}");

            araba1.Renk = "Lacivert";
            Console.WriteLine($"Araba 1: Renk={araba1.Renk}, Model={araba1.Model}, Yıl={araba1.Yil}");

            araba2.Renk = "Siyah";
            araba2.Yil = 2015;
            araba2.Model = "Nissan Qashqai";
            Console.WriteLine($"Araba 2: Renk={araba2.Renk}, Model={araba2.Model}, Yıl={araba2.Yil}");


        }
    }

    public class Araba
    {
        public string Renk { get; set; }
        public string Model { get; set; }
        public int Yil { get; set; }

        //public Araba()
        //{
        //    // boşta olur
        //}

        // Default constructor
        public Araba()
        {
            Renk = "Beyaz";
            Model = "Ford";
            Yil = 2022;
        }

        // Constructor (parametreli)
        public Araba(string renk, string model, int yil)
        {
            Renk = renk;
            Model = model;
            Yil = yil;
        }

        // Constructor
        public Araba(string renk)
        {
            Renk = renk;
            Model = "Honda";
            Yil = 2021;
        }

        public void Calistir()
        {
            Console.WriteLine("Araba çalıştırıldı.");
        }
    }
}
