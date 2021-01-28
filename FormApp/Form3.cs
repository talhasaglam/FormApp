using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Odev2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // Sağ üstten çarpıya basılınca uygulamayı da kapat.
        }

        private void KapatButon_Click(object sender, EventArgs e) // Kapata tıklandığında
        {
            this.Hide(); // Form3 ü gizle
            Form1 anaEkran = new Form1(); // Form1 den nesne oluştur.
            anaEkran.Show();  // Form1 i göster.
        }

        private void richTextBox1_VisibleChanged(object sender, EventArgs e)
        {
            
            richTextBox1.Clear();
            StreamReader dosyaOku = new StreamReader("veriler.txt"); //O kuma işlemi için bir StreamReader nesnesi oluşturduk.

            string yazi = dosyaOku.ReadLine(); // Okunan satır yazi isimli stringe atanıyor.

            string[] kelimeler;


            int n = 1; // Tek satır çift satır  için.

            while (yazi != null)
            {


                System.Drawing.Font currentFont = richTextBox1.SelectionFont;
                System.Drawing.FontStyle newFontStyle;              // Yazının kalın yada ince olma işlemi için.

                
               

                if (n % 2 == 1)    // Eğer tek satırsa kalın değilse normal yap.
                {
                    
                    newFontStyle = FontStyle.Bold;  
                   
                }
                else

                    newFontStyle = FontStyle.Regular;



                kelimeler = yazi.Split(' ');  // Boşluğa göre okunan satırı kelimelere bölme işlemi yapılıyor.

                if (yazi[0] == 'k')  //Eğer ilk harf k ise
                {   
                    richTextBox1.AppendText(Environment.NewLine + kelimeler[1]);  // Richtextboxa ekle.
                    richTextBox1.Select(richTextBox1.Text.Length - kelimeler[1].Length, kelimeler[1].Length); //Değişkeni seç
                    richTextBox1.SelectionColor = Color.Red;  //Renk kırmızı yapıldı.
                    richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle); // Yazı kalınlık durumu.
                }
                if (yazi[0] == 'm')
                {
                    richTextBox1.AppendText(Environment.NewLine + kelimeler[1]);  // Richtextboxa ekle.
                    richTextBox1.Select(richTextBox1.Text.Length - kelimeler[1].Length, kelimeler[1].Length);   //Değişkeni seç
                    richTextBox1.SelectionColor = Color.Blue;  //Renk mavi yapıldı.
                    richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle); // Yazı kalınlık durumu
                }
                if (yazi[0] == 'y')
                {
                    richTextBox1.AppendText(Environment.NewLine + kelimeler[1]); // Richtextboxa ekle.
                    richTextBox1.Select(richTextBox1.Text.Length - kelimeler[1].Length, kelimeler[1].Length); //Değişkeni seç
                    richTextBox1.SelectionColor = Color.Green; //Renk yeşil yapıldı.
                    richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle); // Yazı kalınlık durumu
                }

                if (yazi[1] == 'k')
                {
                    richTextBox1.AppendText(" " + kelimeler[2]); // Richtextboxa ekle.
                    richTextBox1.Select(richTextBox1.Text.Length - kelimeler[2].Length, kelimeler[2].Length); //Değişkeni seç
                    richTextBox1.SelectionColor = Color.Red; //Renk kırmızı yapıldı.
                    richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle); // Yazı kalınlık durumu
                }
                if (yazi[1] == 'm')
                {
                    richTextBox1.AppendText(" " + kelimeler[2]); // Richtextboxa ekle.
                    richTextBox1.Select(richTextBox1.Text.Length - kelimeler[2].Length, kelimeler[2].Length); //Değişkeni seç
                    richTextBox1.SelectionColor = Color.Blue; //Renk mavi yapıldı.
                    richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle); // Yazı kalınlık durumu
                }
                if (yazi[1] == 'y')
                {
                    richTextBox1.AppendText(" " + kelimeler[2]); // Richtextboxa ekle.
                    richTextBox1.Select(richTextBox1.Text.Length - kelimeler[2].Length, kelimeler[2].Length); //Değişkeni seç
                    richTextBox1.SelectionColor = Color.Green; //Renk yeşil yapıldı.
                    richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle); // Yazı kalınlık durumu
                }

                if (yazi[2] == 'k')
                {
                    richTextBox1.AppendText(" " + kelimeler[3]); // Richtextboxa ekle.
                    richTextBox1.Select(richTextBox1.Text.Length - kelimeler[3].Length, kelimeler[3].Length); //Değişkeni seç
                    richTextBox1.SelectionColor = Color.Red; //Renk kırmızı yapıldı.
                    richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle); // Yazı kalınlık durumu
                }
                if (yazi[2] == 'm')
                {
                    richTextBox1.AppendText(" " + kelimeler[3]); // Richtextboxa ekle.
                    richTextBox1.Select(richTextBox1.Text.Length - kelimeler[3].Length, kelimeler[3].Length); //Değişkeni seç
                    richTextBox1.SelectionColor = Color.Blue; //Renk mavi yapıldı.
                    richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle); // Yazı kalınlık durumu
                }
                if (yazi[2] == 'y')
                {
                    richTextBox1.AppendText(" " + kelimeler[3]); // Richtextboxa ekle.
                    richTextBox1.Select(richTextBox1.Text.Length - kelimeler[3].Length, kelimeler[3].Length); //Değişkeni seç
                    richTextBox1.SelectionColor = Color.Green; //Renk yeşil yapıldı.
                    richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle); // Yazı kalınlık durumu
                }

              
                yazi = dosyaOku.ReadLine();
                n++;  // kaçıncı satır olduğunu bulabilmek için arttırma işlemi yapılıyor.
            

            }

            dosyaOku.Close();

        }
    }
}
