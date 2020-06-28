using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {

        

           
            try
            {
                const int maxi = Int32.MaxValue;
                int sayi1 = int.Parse(txtBirinciSayi.Text);
                int sayi2 = int.Parse(txt2Sayi.Text);
                int sonuc = 0;

                

                if (sayi1 > maxi && sayi2 > maxi && sonuc > maxi)
                    MessageBox.Show("Sayı limiti aşıldı");

                string islemTuru = ddlIslem.Text;

                Islemler islem = new Islemler();




                if (islemTuru!=null)
                {

                    if (islemTuru == "+")
                    {
                        sonuc = islem.Toplama(sayi1, sayi2);
                    }
                    else if (islemTuru == "-")
                    {
                        sonuc = islem.Cikarma(sayi1, sayi2);
                    }
                    else if (islemTuru == "*")
                    {
                        sonuc = islem.Carpma(sayi1, sayi2);
                    }
                    else if (islemTuru == "/")
                    {
                        sonuc = islem.Bolme(sayi1, sayi2);
                    }
                    else
                    {
                        MessageBox.Show("İşlem türü boş geçilemez..");
                    }

                    labelSonuc.Text = "Sonuc : " + sonuc.ToString();

                  
                   

                    if (sonuc > maxi)
                    {
                        MessageBox.Show("Maximum limit aşıldı");
                    }

                }

            }
            catch(Exception excep)
            {
                MessageBox.Show(excep.ToString());
            }

           


            
        }

        private void txtBirinciSayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt2Sayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

    }
}
