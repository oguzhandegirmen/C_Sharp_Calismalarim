using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetFramework.S5.D2.DiziOrnekUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            /* //Örnek-1 : int veri tipinde bir dizi oluşturalım , kullanıcınız dizinin kaç elemanlı
             //olacağı bilgisini bize versin ve dizi içindeki alanları değer ataması yapsın. Daha sonra dizi
             //içerisindeki elemanların toplamlarını ve ortalamasını ekrana yazdıran bir uygulama yazalım.

             Console.WriteLine("Lütfen oluşturmak istediğimiz veri kümesinin uzunluğunu giriniz");
             string uygulama1DiziUzunluk = Console.ReadLine();
             int uygulamaDiziUzunlukInt = int.Parse(uygulama1DiziUzunluk);

             int[] uygulama1Dizi = new int[uygulamaDiziUzunlukInt];

             for (int uygulamaSayac = 0; uygulamaSayac < uygulama1Dizi.Length; uygulamaSayac++)
             {
                 Console.WriteLine("{0}. index e denk gelen değeri giriniz", uygulamaSayac);

                 uygulama1Dizi[uygulamaSayac] = int.Parse(Console.ReadLine());           
             }

             Console.WriteLine("Tebrikler dizinin içerisindeki tüm alanları doldurunuz");

             Console.WriteLine("Dizi içerisindeki değerler ve toplam, ortalama değeri aşağıdaki gibidir.");

             int uygulama1Toplam = 0, uygulama1Ortalama = 0;

             foreach (int item in uygulama1Dizi)
             {
                 Console.WriteLine(item);
                 uygulama1Toplam = uygulama1Toplam + item;
             }

             Console.WriteLine("+---------------------");

             Console.WriteLine(uygulama1Toplam);

             Console.WriteLine("Dizi içerisindeki eleman sayısı : {0}", uygulama1Dizi.Length);
             uygulama1Ortalama = uygulama1Toplam / uygulama1Dizi.Length;
             Console.WriteLine("Ortalama : {0}", uygulama1Ortalama);

             Console.ReadLine(); */

            // Örnek-2 : 20 elemanlı bir int dizi oluşturalım. Değerlerinizi random sınıfının next
            // fonksiyonu ile 1 - 10 arasındaki değerler ile dolduralım. Daha sonra dizi içerisindeki
            // elemanlarınızı ekrana yazdıralım ve ilgili dizi içerisinde kaç tane 4 değeri olduğunu bulalım.

            Random rnd = new Random();

            int[] uygulama2Dizi = new int[20];
            for (int uygulama2Sayac = 0; uygulama2Sayac < uygulama2Dizi.Length; uygulama2Sayac++)
            {
                uygulama2Dizi[uygulama2Sayac] = rnd.Next(1, 10);
            }

            int uygulama2Bul = 0;

            foreach (int item in uygulama2Dizi)
            {
                Console.WriteLine(item);
                if (item == 4)
                    uygulama2Bul++;

                
            }

            Console.WriteLine("Dizi içerisindeki 4 değeri {0}  adettir.", uygulama2Bul);

            Console.ReadLine();
        }
    }
}
