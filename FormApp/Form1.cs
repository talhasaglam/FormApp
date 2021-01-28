using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void YeniKayitButon_Click(object sender, EventArgs e)
        {
            Form2 kayitEkle = new Form2(); // Form2 den nesne oluşturdum.
            kayitEkle.Show();  //  Kayıt Ekleye tıklandığından Form2 nin gösterilmesi sağlanıyor.
            this.Hide();  // Form1 i gizledim.
        }

        private void KayitListeleButon_Click(object sender, EventArgs e)
        {
            Form3 kayitListele = new Form3(); // Form3 den nesne oluşturdum.
            kayitListele.Show(); //  Kayıt Listeleye tıklandığından Form3 ün gösterilmesi sağlanıyor.
            this.Hide(); // Form1 i gizledim.
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // Sağ üstteki çarpıya basınca uygulamayı sonlandırıyo. Form3 ten Form1 e geçiş yapınca sonlandırma yapmadığı için yazdım.
        }
    }
}
