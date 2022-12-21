namespace GorselProgramlama
{
    partial class AskerDagitim
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
            this.btnDagitimYap = new System.Windows.Forms.Button();
            this.btnBolgeEkle = new System.Windows.Forms.Button();
            this.btnKisiEkle = new System.Windows.Forms.Button();
            this.txtBolgeEkle = new System.Windows.Forms.TextBox();
            this.txtKisiEkle = new System.Windows.Forms.TextBox();
            this.lbxEslesmeler = new System.Windows.Forms.ListBox();
            this.lbxBolgeler = new System.Windows.Forms.ListBox();
            this.lbxKisiler = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnDagitimYap
            // 
            this.btnDagitimYap.Location = new System.Drawing.Point(193, 309);
            this.btnDagitimYap.Name = "btnDagitimYap";
            this.btnDagitimYap.Size = new System.Drawing.Size(209, 23);
            this.btnDagitimYap.TabIndex = 15;
            this.btnDagitimYap.Text = "Dagitim Yap";
            this.btnDagitimYap.UseVisualStyleBackColor = true;
            this.btnDagitimYap.Click += new System.EventHandler(this.btnDagitimYap_Click);
            // 
            // btnBolgeEkle
            // 
            this.btnBolgeEkle.Location = new System.Drawing.Point(290, 280);
            this.btnBolgeEkle.Name = "btnBolgeEkle";
            this.btnBolgeEkle.Size = new System.Drawing.Size(75, 23);
            this.btnBolgeEkle.TabIndex = 14;
            this.btnBolgeEkle.Text = "Bolge Ekle";
            this.btnBolgeEkle.UseVisualStyleBackColor = true;
            this.btnBolgeEkle.Click += new System.EventHandler(this.btnBolgeEkle_Click_1);
            // 
            // btnKisiEkle
            // 
            this.btnKisiEkle.Location = new System.Drawing.Point(125, 280);
            this.btnKisiEkle.Name = "btnKisiEkle";
            this.btnKisiEkle.Size = new System.Drawing.Size(75, 23);
            this.btnKisiEkle.TabIndex = 13;
            this.btnKisiEkle.Text = "Kisi Ekle";
            this.btnKisiEkle.UseVisualStyleBackColor = true;
            this.btnKisiEkle.Click += new System.EventHandler(this.btnKisiEkle_Click_1);
            // 
            // txtBolgeEkle
            // 
            this.txtBolgeEkle.Location = new System.Drawing.Point(224, 253);
            this.txtBolgeEkle.Name = "txtBolgeEkle";
            this.txtBolgeEkle.Size = new System.Drawing.Size(141, 20);
            this.txtBolgeEkle.TabIndex = 12;
            // 
            // txtKisiEkle
            // 
            this.txtKisiEkle.Location = new System.Drawing.Point(59, 254);
            this.txtKisiEkle.Name = "txtKisiEkle";
            this.txtKisiEkle.Size = new System.Drawing.Size(141, 20);
            this.txtKisiEkle.TabIndex = 11;
            // 
            // lbxEslesmeler
            // 
            this.lbxEslesmeler.FormattingEnabled = true;
            this.lbxEslesmeler.Location = new System.Drawing.Point(397, 35);
            this.lbxEslesmeler.Name = "lbxEslesmeler";
            this.lbxEslesmeler.Size = new System.Drawing.Size(145, 238);
            this.lbxEslesmeler.TabIndex = 10;
            // 
            // lbxBolgeler
            // 
            this.lbxBolgeler.FormattingEnabled = true;
            this.lbxBolgeler.Location = new System.Drawing.Point(224, 35);
            this.lbxBolgeler.Name = "lbxBolgeler";
            this.lbxBolgeler.Size = new System.Drawing.Size(141, 212);
            this.lbxBolgeler.TabIndex = 9;
            // 
            // lbxKisiler
            // 
            this.lbxKisiler.FormattingEnabled = true;
            this.lbxKisiler.Location = new System.Drawing.Point(59, 35);
            this.lbxKisiler.Name = "lbxKisiler";
            this.lbxKisiler.Size = new System.Drawing.Size(141, 212);
            this.lbxKisiler.TabIndex = 8;
            // 
            // AskerDagitim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnDagitimYap);
            this.Controls.Add(this.btnBolgeEkle);
            this.Controls.Add(this.btnKisiEkle);
            this.Controls.Add(this.txtBolgeEkle);
            this.Controls.Add(this.txtKisiEkle);
            this.Controls.Add(this.lbxEslesmeler);
            this.Controls.Add(this.lbxBolgeler);
            this.Controls.Add(this.lbxKisiler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AskerDagitim";
            this.Text = "Asker Dağıtım Otomasyonu - 212106062 - Umut Kuzu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDagitimYap;
        private System.Windows.Forms.Button btnBolgeEkle;
        private System.Windows.Forms.Button btnKisiEkle;
        private System.Windows.Forms.TextBox txtBolgeEkle;
        private System.Windows.Forms.TextBox txtKisiEkle;
        private System.Windows.Forms.ListBox lbxEslesmeler;
        private System.Windows.Forms.ListBox lbxBolgeler;
        private System.Windows.Forms.ListBox lbxKisiler;
    }
}