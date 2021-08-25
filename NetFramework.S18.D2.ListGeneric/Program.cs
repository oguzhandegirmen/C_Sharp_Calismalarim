using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S18.D2.ListGeneric
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> sayilarim = new List<int>();

            sayilarim.Add(1);

            int[] eklenecekData1 = new int[3];
            eklenecekData1[0] = 2;
            eklenecekData1[1] = 3;
            eklenecekData1[2] = 4;

            for (int i = 0; i<eklenecekData1.Length; i++)
            {
                sayilarim.Add(eklenecekData1[i]);
            } 
        }
    }
}
