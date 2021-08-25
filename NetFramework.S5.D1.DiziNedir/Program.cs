using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetFramework.S5.D1.DiziNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ogrenciIsimListesi = new string[5];

            //sayılar 0 dan başlar

            ogrenciIsimListesi[0] = "Oğuzhan Değirmen";
            ogrenciIsimListesi[1] = "Kazım Bozkurt";
            ogrenciIsimListesi[2] = "Bekircan Kısacık";
            ogrenciIsimListesi[3] = "Yakup Dündar";
            ogrenciIsimListesi[4] = "Serkan İnkaya";

            //Console.WriteLine(ogrenciIsimListesi[1]);

            foreach (string item in ogrenciIsimListesi)
            {
                Console.WriteLine(item);
            }
            Console.Clear();

            for (int i = 0; i < ogrenciIsimListesi.Length; i++)
            {
                string gelenIsim = ogrenciIsimListesi[i];
                Console.WriteLine(gelenIsim);
            }

            Console.Clear();
        }
    }
}
