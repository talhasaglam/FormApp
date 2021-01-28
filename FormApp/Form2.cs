using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void KayitEkleButon_Click(object sender, EventArgs e)
        {

            if (AdBox.Text == "" || SoyadBox.Text == "" || TelefonBox.Text == "")   // Ad,soyad veya telefon girilmemişse uyarı ver.
            {
                MessageBox.Show("Gerekli alanları doldurun.");
            }

            else if (Kirmizi1.Checked == false && Mavi1.Checked == false && Yesil1.Checked == false) // Ad için renk seçilmemişse uyarı ver.
            {
                MessageBox.Show("Ad için renk seçin.");
            }
            else if (Kirmizi2.Checked == false && Mavi2.Checked == false && Yesil2.Checked == false) // Soyad için renk seçilmemişse uyarı ver.
            {
                MessageBox.Show("Soyad için renk seçin.");
            }
            else if (Kirmizi3.Checked == false && Mavi3.Checked == false && Yesil3.Checked == false) // Telefon için renk seçilmemişse uyarı ver.
            {
                MessageBox.Show("Telefon için renk seçin.");
            }

            else
            {


                StreamWriter dosya = File.AppendText("veriler.txt");   // Dosya yazma işlemi
                if (Kirmizi1.Checked == true)   // Eğer kırmızı renk seçiliyse dosyaya radiobuttonun textini yaz.
                {
                    dosya.Write(Kirmizi1.Text);
                }
                if (Mavi1.Checked == true)  // Eğer mavi renk seçiliyse dosyaya radiobuttonun textini yaz.
                {
                    dosya.Write(Mavi1.Text);
                }

                if (Yesil1.Checked == true)   // Eğer yeşil renk seçiliyse dosyaya radiobuttonun textini yaz.
                {
                    dosya.Write(Yesil1.Text);  // BUNLAR GROUP BOX KULLANILARAK 3LÜ GRUPLAR HALİNE GETİRİLDİ. KARIŞMA DURUMU OLUŞMUYOR.
                }
                if (Kirmizi2.Checked == true)
                {
                    dosya.Write(Kirmizi2.Text);  // Eğer kırmızı renk seçiliyse dosyaya radiobuttonun textini yaz.
                }
                if (Mavi2.Checked == true)
                {
                    dosya.Write(Mavi2.Text);  // Eğer mavi renk seçiliyse dosyaya radiobuttonun textini yaz.
                }
                if (Yesil2.Checked == true)
                {
                    dosya.Write(Yesil2.Text);  // Eğer yeşil renk seçiliyse dosyaya radiobuttonun textini yaz.
                }
                if (Kirmizi3.Checked == true)
                {
                    dosya.Write(Kirmizi3.Text);  // Eğer kırmızı renk seçiliyse dosyaya radiobuttonun textini yaz.
                }
                if (Mavi3.Checked == true)
                {
                    dosya.Write(Mavi3.Text);  // Eğer mavi renk seçiliyse dosyaya radiobuttonun textini yaz.
                }
                if (Yesil3.Checked == true)
                {
                    dosya.Write(Yesil3.Text);  // Eğer yeşil renk seçiliyse dosyaya radiobuttonun textini yaz.
                }

                dosya.Write(" "); // Dosyaya boşluk yaz.



                dosya.Write(AdBox.Text + " ");
                dosya.Write(SoyadBox.Text + " ");   // Ad,Soyad,Telefon girdilerini dosyaya yaz.
                dosya.WriteLine(TelefonBox.Text);
                dosya.Close();

                MessageBox.Show("Kayıt ekleme işleminiz başarıyla gerçkleştirildi.");

                this.Hide();   // Form2 yi gizle.
                Form1 anaEkran = new Form1();  // Form1 den nesne oluştur.
                anaEkran.Show();  // Form1 e dön.

            }

            
          
            
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // Sağ üstten çarpıya basıldığında uygulamayı da kapat.
        }
    }
}
