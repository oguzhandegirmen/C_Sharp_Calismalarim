using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetFramework.S4.D1.ForGenelKullanım
{
    class Program
    {
        static void Main(string[] args)
        {
            //#region For Dögüsü genel kullanımı
            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine("Ben bir for döngüsüyüm");
            //}
            //#endregion
            //Console.Clear();
            //#region Ekran üzerinde 1 - 10 değerleri yazdıralım.

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i + ". tekrar !");
            //}
            //#endregion
            //Console.Clear();
            //#region 1 - 100 arasındaki çift sayıları ekran üzerinde yazdıralım
            //for (int sayac=1; sayac<=100; sayac++)
            //{
            //    if (sayac % 2 == 0)
            //    {
            //        Console.WriteLine(sayac + "- çift sayılar !");
            //    }
            //}
            //#endregion
            //Console.Clear();
            //#region 1-100 arasındaki çift sayıların toplamı
            //int toplam = 0;
            //for(int sayac = 1; sayac<=100; sayac++)
            //{
            //    if(sayac%2==0)
            //    {
            //        // toplam = toplam + sayac;
            //        toplam += sayac;
            //    }
            //}
            //Console.WriteLine("1 ile 100 arsındaki çift sayıların toplamı : {0}", toplam);

            //Console.ReadLine();
            //#endregion


            //#region girilen sayının faktöriyelini alma

            //string kullaniciGelenDeger = string.Empty;
            //int kullaniciGelenDegerInt = 0;
            //int faktoriyelHesapla = 1;

            //Console.WriteLine("Lütfen faktöriyel hesabı yapmak istediğiniz değeri ekrana yazınız: ");
            //kullaniciGelenDeger = Console.ReadLine();
            //kullaniciGelenDegerInt = int.Parse(kullaniciGelenDeger);

            //for (int i = kullaniciGelenDegerInt; i > 1; i--)
            //{
            //    faktoriyelHesapla = faktoriyelHesapla * i;
            //    // faktöriyelHesapla *= i;


            //}
            //Console.WriteLine("{0} değerin faktöriyel sonucu: {1}", kullaniciGelenDeger, faktoriyelHesapla);
            //Console.ReadLine();
            //#endregion

            //#region
            //int sonsuzDonguSayac = 0;
            //for (; ; )
            //{
            //    sonsuzDonguSayac++;
            //    //break anahtar kelimesi
            //    //if (sonsuzDonguSayac == 2)
            //    //break;
            //    //contine anahtar kelimesi 
            //    if (sonsuzDonguSayac == 2)
            //        continue;

            //    Console.WriteLine(sonsuzDonguSayac);

            //    Console.WriteLine("Merhaba ben bir sonsuz döngüyüm");
            //}
            //#endregion


            //#region iç içe for dögüsü kullanımı

            //for (int i = 1; i<20; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //#endregion
            //Console.Clear();


            //#region çarpım tablosu

            //for (int i = 1; i <= 9; i++ )
            //{
            //    for (int y = 1; y <= 9; y++)
            //    {
            //        int carpimSonu = i * y;
            //        Console.Write("{0}*{1}={2} \t", i, y, carpimSonu);
            //    }
            //    Console.WriteLine();
            //}
            //#endregion

            //Console.Clear();



        }
    }
}
