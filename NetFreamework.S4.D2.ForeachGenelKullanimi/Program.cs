using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetFreamework.S4.D2.ForeachGenelKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            #region foreach genel kullanımı
            string[] Isimler = new[] {"Oguzhan Degirmen", "Kazım Bozkurt", "Yakup Dundar",
            "Serkan İnkaya", "Durmus Emin"};

          foreach (string item in Isimler)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Örnek Uygulamalar...

            #endregion
        }
    }
}
