using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Invoice
{
  public class İslemler
    {
        public static double txtbirimfiyat { get; set; }
        public static double txturunmiktar { get; set; }
        public static double iskonto { get; set; }
        public static double kdv { get; set; }
        public static double txtiskontotl { get; set; }
        public static double txtkdvtl { get; set; }
        public static double txttopfiyat { get; set; }
        public static int txtiskontoyuzde { get; set; }
        public static double a { get; set; }
        public static double b { get; set; }
        public static double c { get; set; }
        public  static double d { get; set; }
   
        public static void FaturaHesapla()
        {

            double a = txtbirimfiyat * txturunmiktar;

            if (iskonto.ToString() == txtiskontoyuzde.ToString())
            {
                iskonto = (a * iskonto) / 100;
                a = a - iskonto;
            }

            if (kdv == 18)
            {
                kdv = a * 0.18;
                a = a + kdv;
            }
            if (kdv == 8)
            {
                kdv = a * 0.08;
                a = a + kdv;
            }
            if (kdv == 1)
            {
                kdv = a * 0.01;
                a = a + kdv;
            }
            if (kdv == 0)
            {
                kdv = a;
                a = a + kdv;
            }

            b= kdv;
            c = iskonto;
            d = a + b;
        }
    }
}
