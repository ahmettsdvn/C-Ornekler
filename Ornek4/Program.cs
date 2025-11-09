using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sınıf, Kalıtım, Arayüz ve Polimorfizm Örneği");

            Tablet tablet = new Tablet();
            Telefon telefon = new Telefon();

            // burası da ürün sınıfından. Base sınıf
            // kalıtım
            tablet.Id = 1;
            tablet.Ad = "Iphad Mini";
            tablet.Fiyat = 17500;

            // burası tablet sınıfından
            tablet.EkranBoyutu = 8.3m;
            tablet.IslemciAdi = "A15 Bionic";

            // üründen
            telefon.Id = 2;
            telefon.Fiyat = 25000;
            telefon.Ad = "Samsung S23 Ultra";

            // telefondan
            telefon.KameraCozunurlugu = 200;
            telefon.CiftSimDestegi = true;

            // Telefon Bilgilerini Yazdır
            Console.WriteLine("Telefon Bilgileri:");
            Console.WriteLine($"Id: {telefon.Id}, " +
                $"Ad: {telefon.Ad}, " +
                $"Fiyat: {telefon.Fiyat}, " +
                $"Kamera Çözünürlüğü: {telefon.KameraCozunurlugu} " +
                $"MP, Çift Sim Desteği: {telefon.CiftSimKullaniminiDestekle()}");

            // Tablet Bilgilerini Yazdır
            Console.WriteLine("Tablet Bilgileri:");
            Console.WriteLine($"Id: {tablet.Id}, " +
                $"Ad: {tablet.Ad}, " +
                $"Fiyat: {tablet.Fiyat}, " +
                $"Ekran Boyutu: {tablet.getEkranBoyutu()} inç, " +
                $"İşlemci Adı: {tablet.IslemciAdi}, " +
                $"Kimin: {tablet.TabletKimin()}");

            // Polimorfizm

            Urun urun1 = new Tablet();
            Urun urun2 = new Telefon();

            // Ürün base bir sınıf

            urun1.Ad = "iPad Air";
            urun1.Fiyat = 20000;
            urun1.Id = 3;
            
            urun2.Ad = "iPhone 14 Pro Max";
            urun2.Fiyat = 30000;
            urun2.Id = 4;

            Tablet tablet1 = (Tablet)urun1; // urun 1 sınıfını tablet olarak cast ettik.
            tablet1.EkranBoyutu = 10.9m;
            tablet1.IslemciAdi = "A14 Bionic";

            //tablet1 bilgilerini yazdır
            Console.WriteLine("Tablet1 Bilgileri (Polimorfizm):");
            Console.WriteLine($"Id: {tablet1.Id}, " +
                $"Ad: {tablet1.Ad}, " +
                $"Fiyat: {tablet1.Fiyat}, " +
                $"Ekran Boyutu: {tablet1.getEkranBoyutu()} inç, " +
                $"İşlemci Adı: {tablet1.IslemciAdi}, " +
                $"Kimin: {tablet1.TabletKimin()}");

            Console.WriteLine("Ürün Fiyatı = "+ tablet1.getUrunFiyatı());

            IUrun urun3 = new Telefon();
            IUrun urun4 = new Tablet();

            // Ürün Fiyatını yazdır
            Console.WriteLine("Ürün3 Fiyatı = " + urun3.getUrunFiyatı());     


        }
    }

    /// <summary>
    /// Ürün Arayüzü
    /// </summary>
    public interface IUrun
    {
        /// <summary>
        /// Ürün Fiyatını Döner
        /// </summary>
        /// <returns></returns>
        decimal getUrunFiyatı();
    }

    /// <summary>
    /// Ürün Sınıfı
    /// </summary>
    public class Urun: IUrun
    {
        /// <summary>
        /// Ürün Id'si
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Ürün Adı
        /// </summary>
        public string Ad { get; set; }
        /// <summary>
        /// Ürün Fiyatı
        /// </summary>
        // Ürün Fiyatı Yorum satırı
        public decimal Fiyat { get; set; }

        public decimal getUrunFiyatı()
        {
            return Fiyat;
        }

        //public Urun(int id, string ad, decimal fiyat)
        //{
        //    Id = id;
        //    Ad = ad;
        //    Fiyat = fiyat;
        //}
    }

    /// <summary>
    /// Tablet Arayüzü
    /// </summary>
    public interface ITablet
    {
        /// <summary>
        /// Ekran Boyutunu Döner
        /// </summary>
        /// <returns></returns>
        int getEkranBoyutu();
    }

    /// <summary>
    /// Tablet Sınıfı
    /// </summary>
    public class Tablet: Urun, ITablet
    {
        /// <summary>
        /// Ekran Boyutu
        /// </summary>
        public decimal EkranBoyutu { get; set; }
        /// <summary>
        /// İşlemci Adı
        /// </summary>
        public string IslemciAdi { get; set; }

        public int getEkranBoyutu()
        {
            return (int)EkranBoyutu;
        }

        public string TabletKimin()
        {
            return "Bu tablet Apple markasına aittir.";
        }

        //public Tablet(int id, string ad, decimal fiyat, decimal ekranBoyutu, string islemciAdi)
        //    : base(id, ad, fiyat) // süper sınıfın yapıcı metodunu çağırıyoruz
        //{
        //    EkranBoyutu = ekranBoyutu;
        //    IslemciAdi = islemciAdi;
        //}
    }

    /// <summary>
    /// Telefon Arayüzü
    /// </summary>
    public interface ITlefon
    {
        /// <summary>
        /// Çift Sim Kullanımını Destekler mi?
        /// </summary>
        /// <returns></returns>
        bool CiftSimKullaniminiDestekle();
    }

    /// <summary>
    /// Telefon Sınıfı
    /// </summary>
    public class Telefon : Urun, ITlefon
    {
        //public Telefon(int id, string ad, decimal fiyat) : base(id, ad, fiyat)
        //{
        //}

        /// <summary>
        /// Kamera Çözünürlüğü
        /// </summary>
        public int KameraCozunurlugu { get; set; }
        /// <summary>
        /// Çift Sim Desteği
        /// </summary>
        public bool CiftSimDestegi { get; set; }

        public bool CiftSimKullaniminiDestekle()
        {
            return CiftSimDestegi;
        }
    }
}