using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetFramework.S4.D5.WhileOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ödev-1
            //
            //string kullaniciAdi = string.Empty;
            //string sifre = string.Empty;
            //int sayac = 0;

            //do
            //{
            //    //sayac ile kontrol etmeniz önemli bunun nedeni do while içerisinde herhangi bir if koşulu ile
            //    //şartlarımızı kontrol etmedik while ( şart ) blogu içerisinde kontrollerimizi yaptığımız için
            //    //değerin hatalı veya doğru olduğunu sayac adındaki bu değişken üzerinden kontrol ettik.

            //    if (sayac > 0)
            //        Console.WriteLine("Kullanıcı adı veya şifre değerlerinizden birisi hatalı");

            //    Console.WriteLine("Kullanıcı Adınızı Giriniz: ");
            //    kullaniciAdi = Console.ReadLine();

            //    Console.WriteLine("Şifreyi Giriniz: ");
            //    sifre = Console.ReadLine();

            //    sayac++;
            //}
            //while (kullaniciAdi.ToLower() != "demo" || sifre.ToLower() != "demo");

            //Console.WriteLine("Başarılı kullanıcı girişi");


            //Ödev-2 : Kullanıcıdan 1 ile x arasında bir sayı girmesini isteyin. Daha sonra sistem kullanıcının girmiş olduğu 1 ile x değerleri arasında
            //bir sayı tahmini yapsın. Daha sonra kullanıcın sistemin tahmin etmiş olduğu sayıyı bulamaya çalışsın. Bulamaz ise yeniden sorsun. Ne
            //zaman kullanıcı ilgili değeri bulursa Y kadar denediniz ve sonuca ulaştınız dersin.

            
            int odev2tahmin = 0;
            int odev2uretilenSayi = 0;
            int odev2sayac = 0;

            Console.WriteLine("Tahmin oyunu için en yüksek değeri giriniz");
            int odev2kullaniciMaxValue = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            odev2uretilenSayi = rnd.Next(1, odev2kullaniciMaxValue);

            do
            {
                odev2sayac++;
                Console.WriteLine("{0} hakkınız üretilen sayıyı tahmin ediniz", odev2sayac);
                odev2tahmin = int.Parse(Console.ReadLine());
            } while (odev2tahmin != odev2uretilenSayi);

            Console.WriteLine("{0}. kere denediniz Sayıyı tahmin ettiniz", odev2sayac);

        }
    }
}
