namespace Odev2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AdBox = new System.Windows.Forms.TextBox();
            this.SoyadBox = new System.Windows.Forms.TextBox();
            this.TelefonBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.KayitEkleButon = new System.Windows.Forms.Button();
            this.Kirmizi1 = new System.Windows.Forms.RadioButton();
            this.Mavi1 = new System.Windows.Forms.RadioButton();
            this.Yesil1 = new System.Windows.Forms.RadioButton();
            this.Kirmizi2 = new System.Windows.Forms.RadioButton();
            this.Mavi2 = new System.Windows.Forms.RadioButton();
            this.Yesil2 = new System.Windows.Forms.RadioButton();
            this.Kirmizi3 = new System.Windows.Forms.RadioButton();
            this.Mavi3 = new System.Windows.Forms.RadioButton();
            this.Yesil3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdBox
            // 
            this.AdBox.Location = new System.Drawing.Point(92, 68);
            this.AdBox.Name = "AdBox";
            this.AdBox.Size = new System.Drawing.Size(117, 20);
            this.AdBox.TabIndex = 0;
            // 
            // SoyadBox
            // 
            this.SoyadBox.Location = new System.Drawing.Point(92, 111);
            this.SoyadBox.Name = "SoyadBox";
            this.SoyadBox.Size = new System.Drawing.Size(117, 20);
            this.SoyadBox.TabIndex = 1;
            // 
            // TelefonBox
            // 
            this.TelefonBox.Location = new System.Drawing.Point(92, 157);
            this.TelefonBox.Name = "TelefonBox";
            this.TelefonBox.Size = new System.Drawing.Size(117, 20);
            this.TelefonBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telefon";
            // 
            // KayitEkleButon
            // 
            this.KayitEkleButon.Location = new System.Drawing.Point(106, 207);
            this.KayitEkleButon.Name = "KayitEkleButon";
            this.KayitEkleButon.Size = new System.Drawing.Size(87, 23);
            this.KayitEkleButon.TabIndex = 6;
            this.KayitEkleButon.Text = "Kayıt Ekle";
            this.KayitEkleButon.UseVisualStyleBackColor = true;
            this.KayitEkleButon.Click += new System.EventHandler(this.KayitEkleButon_Click);
            // 
            // Kirmizi1
            // 
            this.Kirmizi1.AutoSize = true;
            this.Kirmizi1.BackColor = System.Drawing.Color.Red;
            this.Kirmizi1.Location = new System.Drawing.Point(6, 23);
            this.Kirmizi1.Name = "Kirmizi1";
            this.Kirmizi1.Size = new System.Drawing.Size(31, 17);
            this.Kirmizi1.TabIndex = 7;
            this.Kirmizi1.TabStop = true;
            this.Kirmizi1.Text = "k";
            this.Kirmizi1.UseVisualStyleBackColor = false;
            // 
            // Mavi1
            // 
            this.Mavi1.AutoSize = true;
            this.Mavi1.BackColor = System.Drawing.Color.Blue;
            this.Mavi1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Mavi1.Location = new System.Drawing.Point(57, 23);
            this.Mavi1.Name = "Mavi1";
            this.Mavi1.Size = new System.Drawing.Size(33, 17);
            this.Mavi1.TabIndex = 8;
            this.Mavi1.TabStop = true;
            this.Mavi1.Text = "m";
            this.Mavi1.UseVisualStyleBackColor = false;
            // 
            // Yesil1
            // 
            this.Yesil1.AutoSize = true;
            this.Yesil1.BackColor = System.Drawing.Color.Green;
            this.Yesil1.Location = new System.Drawing.Point(107, 23);
            this.Yesil1.Name = "Yesil1";
            this.Yesil1.Size = new System.Drawing.Size(30, 17);
            this.Yesil1.TabIndex = 9;
            this.Yesil1.TabStop = true;
            this.Yesil1.Text = "y";
            this.Yesil1.UseVisualStyleBackColor = false;
            // 
            // Kirmizi2
            // 
            this.Kirmizi2.AutoSize = true;
            this.Kirmizi2.BackColor = System.Drawing.Color.Red;
            this.Kirmizi2.Location = new System.Drawing.Point(6, 14);
            this.Kirmizi2.Name = "Kirmizi2";
            this.Kirmizi2.Size = new System.Drawing.Size(31, 17);
            this.Kirmizi2.TabIndex = 10;
            this.Kirmizi2.TabStop = true;
            this.Kirmizi2.Text = "k";
            this.Kirmizi2.UseVisualStyleBackColor = false;
            // 
            // Mavi2
            // 
            this.Mavi2.AutoSize = true;
            this.Mavi2.BackColor = System.Drawing.Color.Blue;
            this.Mavi2.Location = new System.Drawing.Point(57, 14);
            this.Mavi2.Name = "Mavi2";
            this.Mavi2.Size = new System.Drawing.Size(33, 17);
            this.Mavi2.TabIndex = 11;
            this.Mavi2.TabStop = true;
            this.Mavi2.Text = "m";
            this.Mavi2.UseVisualStyleBackColor = false;
            // 
            // Yesil2
            // 
            this.Yesil2.AutoSize = true;
            this.Yesil2.BackColor = System.Drawing.Color.Green;
            this.Yesil2.Location = new System.Drawing.Point(107, 14);
            this.Yesil2.Name = "Yesil2";
            this.Yesil2.Size = new System.Drawing.Size(30, 17);
            this.Yesil2.TabIndex = 12;
            this.Yesil2.TabStop = true;
            this.Yesil2.Text = "y";
            this.Yesil2.UseVisualStyleBackColor = false;
            // 
            // Kirmizi3
            // 
            this.Kirmizi3.AutoSize = true;
            this.Kirmizi3.BackColor = System.Drawing.Color.Red;
            this.Kirmizi3.Location = new System.Drawing.Point(6, 16);
            this.Kirmizi3.Name = "Kirmizi3";
            this.Kirmizi3.Size = new System.Drawing.Size(31, 17);
            this.Kirmizi3.TabIndex = 13;
            this.Kirmizi3.TabStop = true;
            this.Kirmizi3.Text = "k";
            this.Kirmizi3.UseVisualStyleBackColor = false;
            // 
            // Mavi3
            // 
            this.Mavi3.AutoSize = true;
            this.Mavi3.BackColor = System.Drawing.Color.Blue;
            this.Mavi3.Location = new System.Drawing.Point(57, 16);
            this.Mavi3.Name = "Mavi3";
            this.Mavi3.Size = new System.Drawing.Size(33, 17);
            this.Mavi3.TabIndex = 14;
            this.Mavi3.TabStop = true;
            this.Mavi3.Text = "m";
            this.Mavi3.UseVisualStyleBackColor = false;
            // 
            // Yesil3
            // 
            this.Yesil3.AutoSize = true;
            this.Yesil3.BackColor = System.Drawing.Color.Green;
            this.Yesil3.Location = new System.Drawing.Point(107, 16);
            this.Yesil3.Name = "Yesil3";
            this.Yesil3.Size = new System.Drawing.Size(30, 17);
            this.Yesil3.TabIndex = 15;
            this.Yesil3.TabStop = true;
            this.Yesil3.Text = "y";
            this.Yesil3.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Kirmizi1);
            this.groupBox1.Controls.Add(this.Mavi1);
            this.groupBox1.Controls.Add(this.Yesil1);
            this.groupBox1.Location = new System.Drawing.Point(226, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 47);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Kirmizi2);
            this.groupBox2.Controls.Add(this.Mavi2);
            this.groupBox2.Controls.Add(this.Yesil2);
            this.groupBox2.Location = new System.Drawing.Point(226, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(153, 37);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.Kirmizi3);
            this.groupBox3.Controls.Add(this.Mavi3);
            this.groupBox3.Controls.Add(this.Yesil3);
            this.groupBox3.Location = new System.Drawing.Point(226, 138);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(153, 39);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(587, 368);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.KayitEkleButon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TelefonBox);
            this.Controls.Add(this.SoyadBox);
            this.Controls.Add(this.AdBox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AdBox;
        private System.Windows.Forms.TextBox SoyadBox;
        private System.Windows.Forms.TextBox TelefonBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button KayitEkleButon;
        private System.Windows.Forms.RadioButton Kirmizi1;
        private System.Windows.Forms.RadioButton Mavi1;
        private System.Windows.Forms.RadioButton Yesil1;
        private System.Windows.Forms.RadioButton Kirmizi2;
        private System.Windows.Forms.RadioButton Mavi2;
        private System.Windows.Forms.RadioButton Yesil2;
        private System.Windows.Forms.RadioButton Kirmizi3;
        private System.Windows.Forms.RadioButton Mavi3;
        private System.Windows.Forms.RadioButton Yesil3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}