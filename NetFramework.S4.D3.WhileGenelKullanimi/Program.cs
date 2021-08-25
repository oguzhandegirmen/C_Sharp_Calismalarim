using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetFramework.S4.D3.WhileGenelKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 den 10a kadar yazdırma
            //
            //forla görünümü 
            //
            //for (int i = 1; i <= 10; i++)
            //{

            //    Console.WriteLine(i);

            //}
            //Console.ReadLine();


            //While ile gösterimi
            //
            //int sayac = 1;
            //while (sayac <= 10)
            //{
            //    Console.WriteLine(sayac);
            //    sayac++;
            //}
            //Console.ReadLine();


            //Örnek Uygulama-1
            //Console.WriteLine("Lütfen bir sayı giriniz:");
            //string kullanicidanGelenDeger = Console.ReadLine();
            //int ornekKullanimSayac = int.Parse(kullanicidanGelenDeger);

            //while (ornekKullanimSayac!=0)
            //{
            //    Console.WriteLine(ornekKullanimSayac);
            //    ornekKullanimSayac = ornekKullanimSayac - 1;
            //    //ornekKullanimSayac--;
            //}

            //Console.WriteLine("Örnek 1 işlemi tamamladı");

            //Console.ReadLine();


            //Örnek Uygulama-2
            //Console.WriteLine("Lütfen Toplamak istediğiniz sayıları giriniz. ");
            //Console.WriteLine("Not : -1 değeri işlemlerinizi duruyor.");

            //int ornekKullanimToplam = 0;
            //while (true)
            //{
            //    string Ornek2KullaniciGelenDeger = Console.ReadLine();
            //    int Ornek2KulGelenDegerInt = int.Parse(Ornek2KullaniciGelenDeger);
            //    if (Ornek2KulGelenDegerInt < 0)
            //        break;
            //    else
            //        ornekKullanimToplam = ornekKullanimToplam + Ornek2KulGelenDegerInt;

            //}
            //Console.WriteLine("Toplam Değer : {0}", ornekKullanimToplam);
            //Console.ReadLine();


            //Örnek Uygulama-3

            int sistemUretSayi = 0;
            int tahminAdet = 1;
            Random rnd = new Random();
            sistemUretSayi = rnd.Next(1, 10);

            while (true)
            {
                Console.Write("{0} . deneme = Lütfen sistemin üretmiş olduğu sayıyı tahmin ediniz :",tahminAdet);
                string rndKullaniciGelen = Console.ReadLine();

                int rndKullaniciGelenInt = int.Parse(rndKullaniciGelen);

                //if (int.Parse(rndKullaniciGelen) == sistemUretSayi)
                if (rndKullaniciGelenInt == sistemUretSayi)
                {
                    tahminAdet++;
                    Console.WriteLine("{0}. denemenizde değeri buldunuz Tebrikler !", tahminAdet);
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("{0}. denemizde, Tahmin edemediniz lütfen yeniden deneyin ... ", tahminAdet);
                    tahminAdet++;
                }
            }
            Console.Clear();
        }
    }
}
