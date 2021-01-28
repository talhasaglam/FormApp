namespace Odev2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.YeniKayitButon = new System.Windows.Forms.Button();
            this.KayitListeleButon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // YeniKayitButon
            // 
            this.YeniKayitButon.Location = new System.Drawing.Point(216, 106);
            this.YeniKayitButon.Name = "YeniKayitButon";
            this.YeniKayitButon.Size = new System.Drawing.Size(142, 43);
            this.YeniKayitButon.TabIndex = 0;
            this.YeniKayitButon.Text = "Yeni Kayıt Ekle";
            this.YeniKayitButon.UseVisualStyleBackColor = true;
            this.YeniKayitButon.Click += new System.EventHandler(this.YeniKayitButon_Click);
            // 
            // KayitListeleButon
            // 
            this.KayitListeleButon.Location = new System.Drawing.Point(216, 183);
            this.KayitListeleButon.Name = "KayitListeleButon";
            this.KayitListeleButon.Size = new System.Drawing.Size(142, 44);
            this.KayitListeleButon.TabIndex = 1;
            this.KayitListeleButon.Text = "Kayıtları Listele";
            this.KayitListeleButon.UseVisualStyleBackColor = true;
            this.KayitListeleButon.Click += new System.EventHandler(this.KayitListeleButon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(590, 366);
            this.Controls.Add(this.KayitListeleButon);
            this.Controls.Add(this.YeniKayitButon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button YeniKayitButon;
        private System.Windows.Forms.Button KayitListeleButon;
    }
}

