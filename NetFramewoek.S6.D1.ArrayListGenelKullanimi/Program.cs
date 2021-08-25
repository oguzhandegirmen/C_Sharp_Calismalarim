using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NetFramewoek.S6.D1.ArrayListGenelKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            int Capacity = 0;
            int Count = 0;

            ArrayList A1 = new ArrayList();

            // Tek Değer ekleme 
            A1.Add("Oğuzhan DEĞİRMEN");
            A1.Add(100);

            ArrayList A2 = new ArrayList();
            A2.Add("Emin");
            A2.Add("Kazım");

            A1.AddRange(A2);
        }
    }
}
