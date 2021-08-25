using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S8.D1.OOPNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            M1.TCKimliknumara = "60301366724";
            M1.İsim = "Oğuzhan";
            M1.Soyisim = "Değirmen";
            M1.cinsiyet = 717770001;

            Musteri M2 = M1;

            M2.İsim = "Murat";
            M1.TCKimliknumara = "60301366702";

            M2 = null;
            M1 = null;

            string isim = M2.İsim;

        }
    }
}
