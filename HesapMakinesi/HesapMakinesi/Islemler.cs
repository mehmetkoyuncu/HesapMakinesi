using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapMakinesi
{
   public class Islemler
    {
        public int sayi1 { get; set; }
        public int sayi2 { get; set; }
       

        public int Toplama(int sayi1,int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            return sonuc;
        }
        public int Cikarma(int sayi1, int sayi2)
        {
            int sonuc = sayi1 - sayi2;
            return sonuc;
        }
        public int Carpma(int sayi1, int sayi2)
        {
            int sonuc = sayi1 * sayi2;
            return sonuc;
        }
        public int Bolme(int sayi1, int sayi2)
        {
           if(sayi2==0)
            {
                System.Windows.Forms.MessageBox.Show("Bölen 0 Olamaz..");
            }
            int sonuc = sayi1 / sayi2;
            return sonuc;
        }






      


    }
}
