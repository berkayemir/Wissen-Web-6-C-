using System;

namespace İf_Soru_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //bir üniversitede bir ögrencinin not ortalaması
            //60 ve üzerindeyse öğrenci başarılı değilse başarısız kabul ediliyor
            //öğrencinin ortalaması vize ve filan notları üzerinden şu şekilde hesaplanıyor
            //vize'nin %40 ı ile finalin %60'ı toplanıyor
            //Bu duruma göre Vize ve final notları klavyeden girilen bir ögrencinin Not ortalaması ve başarı durumunu
            //yazdıran program
            //ayrıca devamsızlık sınırı 10 gündür
            //vize ve final notları ile devamsızlık yaptıgı gün sayısı klavyeden girilen ögrencinin

            //Console.WriteLine("Lütfen Ögrencinin adını giriniz");
            //string ogrenciAd = Console.ReadLine();
            //Console.Write("Lütfen ögrencinin Vize notunu giriniz: ");
            //double vize = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Lütfen ögrencinin final notunu giriniz: ");
            //double final = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Lütfen öğrencinin devamsız gün sayısını giriniz");
            //int devamsızlık = Convert.ToInt32(Console.ReadLine());
            //double ort = (vize * 0.4 + final * 0.6) ;
            //if (devamsızlık>=10)
            //{
            //    Console.WriteLine("Devamsızlıkdan dolayı BAŞARISIZ");
            //}
            //else if (ort >= 60 && devamsızlık<10)
            //{
            //    Console.WriteLine($"Ögrenci {ogrenciAd} {ort} ortalama ile BAŞARILI");
            //}
            //else if(ort<60 && devamsızlık<10)
            //{
            //    Console.WriteLine($"Ögrenci {ogrenciAd} {ort} ortalama ile BAŞARISIZ");
            //}

            //Console.ReadLine();

            /*Bir magazadan alınan ürünün fiyatı 100 liradan büyük veya eşitse 5 tl olan kargo ücreti alınmamaktadır
             ürünün fiyatı girildiginde,toplam ödenesi gerekn tutarı bulup ekrana yazdıran programı hazırlayınız
             */

            //Console.WriteLine("Ürünün fiyatını giriniz");
            //double fiyat = Convert.ToDouble(Console.ReadLine());
            //if (fiyat>=100)
            //{
            //    Console.WriteLine($"Toplam ödenmesi gerekn tutar: {fiyat} + 0tl kargo={fiyat}");
            //}
            //else
            //{
            //    Console.WriteLine($"Toplam ödenmesi gereken tuar : {fiyat} + 5 tl kargo={fiyat+5}");
            //}

            /*
             * Klavyeden girilecek iki ürün fiyatının toplamı 200 tl ve üzerindeyse
             * 2.üründen %30 indirim yapılması gerekmektedir
             * buna göre iki ürün fiyatını girdiren ve gerekli hesaplamayı yapan toplam tutarı ekranda göster
        //     */
            //    Console.WriteLine("Lütfen ürün fiyatlarını giriniz:");
            //    double urun1 = Convert.ToDouble(Console.ReadLine());
            //    double urun2 = Convert.ToDouble(Console.ReadLine());
            //    double top = urun1 + urun2;
            //    if (top>=200)
            //    {
            //        urun2 = urun2-(urun2 * 0.3);
            //        double yeniTop = urun1 + urun2;
            //        Console.WriteLine($"Toplam : {yeniTop}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Toplam: {top}");
            //    }

            //   Console.ReadLine();
            //}
            double indirimliTutar = 0;
            double kargoUcreti = 25;
            Console.Write("ürün 1 in fiatı: ");
            double urun1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("ürün 2 nin fiyatı: ");
            double urun2 = Convert.ToDouble(Console.ReadLine());
            double genelTutar = urun1 + urun2;

            if (genelTutar>=200)
            {
                indirimliTutar = genelTutar - urun2 * 0.35;
                if (indirimliTutar >= 250)
                {
                    kargoUcreti = 0;
                }
            }
            else
            {
                indirimliTutar = genelTutar;
            }
            
            double odenecekTutar = indirimliTutar + kargoUcreti;
            Console.WriteLine("**********************");
            Console.WriteLine($"ürün 1 Fiyat        : {urun1}");
            Console.WriteLine($"ürün 2 Fiyat        : {urun2}");
            Console.WriteLine($"Genel Tutar         : {genelTutar}");
            Console.WriteLine($"İndirimli Tutar     : {indirimliTutar}");
            Console.WriteLine($"Kargo Bedeli        : {kargoUcreti}");
            Console.WriteLine($"Ödenecek Tutar      : {odenecekTutar}");
                         

            Console.ReadLine();
        }
    }
}