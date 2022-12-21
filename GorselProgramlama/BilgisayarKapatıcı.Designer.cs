namespace GorselProgramlama
{
    partial class BilgisayarKapatıcı
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
            this.components = new System.ComponentModel.Container();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Kalan_Sure = new System.Windows.Forms.Label();
            this.Saniye = new System.Windows.Forms.Label();
            this.Dakika = new System.Windows.Forms.Label();
            this.Saat = new System.Windows.Forms.Label();
            this.Gün = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(141, 150);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 28);
            this.button2.TabIndex = 18;
            this.button2.Text = "İptal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 84);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 50);
            this.button1.TabIndex = 17;
            this.button1.Text = "Bilgisayarı Kapat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(19, 181);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(76, 20);
            this.textBox4.TabIndex = 16;
            this.textBox4.Text = "0";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(19, 137);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(76, 20);
            this.textBox3.TabIndex = 15;
            this.textBox3.Text = "1";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(19, 84);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(76, 20);
            this.textBox2.TabIndex = 14;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 38);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Kapalı";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Kalan_Sure
            // 
            this.Kalan_Sure.AutoSize = true;
            this.Kalan_Sure.Location = new System.Drawing.Point(139, 23);
            this.Kalan_Sure.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Kalan_Sure.Name = "Kalan_Sure";
            this.Kalan_Sure.Size = new System.Drawing.Size(59, 13);
            this.Kalan_Sure.TabIndex = 23;
            this.Kalan_Sure.Text = "Kalan Süre";
            // 
            // Saniye
            // 
            this.Saniye.AutoSize = true;
            this.Saniye.Location = new System.Drawing.Point(38, 165);
            this.Saniye.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Saniye.Name = "Saniye";
            this.Saniye.Size = new System.Drawing.Size(39, 13);
            this.Saniye.TabIndex = 22;
            this.Saniye.Text = "Saniye";
            // 
            // Dakika
            // 
            this.Dakika.AutoSize = true;
            this.Dakika.Location = new System.Drawing.Point(36, 113);
            this.Dakika.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Dakika.Name = "Dakika";
            this.Dakika.Size = new System.Drawing.Size(41, 13);
            this.Dakika.TabIndex = 21;
            this.Dakika.Text = "Dakika";
            // 
            // Saat
            // 
            this.Saat.AutoSize = true;
            this.Saat.Location = new System.Drawing.Point(41, 69);
            this.Saat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Saat.Name = "Saat";
            this.Saat.Size = new System.Drawing.Size(29, 13);
            this.Saat.TabIndex = 20;
            this.Saat.Text = "Saat";
            // 
            // Gün
            // 
            this.Gün.AutoSize = true;
            this.Gün.Location = new System.Drawing.Point(44, 23);
            this.Gün.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Gün.Name = "Gün";
            this.Gün.Size = new System.Drawing.Size(27, 13);
            this.Gün.TabIndex = 19;
            this.Gün.Text = "Gün";
            // 
            // BilgisayarKapatıcı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 216);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Kalan_Sure);
            this.Controls.Add(this.Saniye);
            this.Controls.Add(this.Dakika);
            this.Controls.Add(this.Saat);
            this.Controls.Add(this.Gün);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BilgisayarKapatıcı";
            this.Text = "BilgisayarKapatıcı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Kalan_Sure;
        private System.Windows.Forms.Label Saniye;
        private System.Windows.Forms.Label Dakika;
        private System.Windows.Forms.Label Saat;
        private System.Windows.Forms.Label Gün;
    }
}