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
            this.btnDagitimYap.Location = new System.Drawing.Point(257, 380);
            this.btnDagitimYap.Margin = new System.Windows.Forms.Padding(4);
            this.btnDagitimYap.Name = "btnDagitimYap";
            this.btnDagitimYap.Size = new System.Drawing.Size(279, 28);
            this.btnDagitimYap.TabIndex = 15;
            this.btnDagitimYap.Text = "Dagitim Yap";
            this.btnDagitimYap.UseVisualStyleBackColor = true;
            this.btnDagitimYap.Click += new System.EventHandler(this.btnDagitimYap_Click);
            // 
            // btnBolgeEkle
            // 
            this.btnBolgeEkle.Location = new System.Drawing.Point(387, 344);
            this.btnBolgeEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnBolgeEkle.Name = "btnBolgeEkle";
            this.btnBolgeEkle.Size = new System.Drawing.Size(100, 28);
            this.btnBolgeEkle.TabIndex = 14;
            this.btnBolgeEkle.Text = "Bolge Ekle";
            this.btnBolgeEkle.UseVisualStyleBackColor = true;
            this.btnBolgeEkle.Click += new System.EventHandler(this.btnBolgeEkle_Click_1);
            // 
            // btnKisiEkle
            // 
            this.btnKisiEkle.Location = new System.Drawing.Point(167, 344);
            this.btnKisiEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnKisiEkle.Name = "btnKisiEkle";
            this.btnKisiEkle.Size = new System.Drawing.Size(100, 28);
            this.btnKisiEkle.TabIndex = 13;
            this.btnKisiEkle.Text = "Kisi Ekle";
            this.btnKisiEkle.UseVisualStyleBackColor = true;
            this.btnKisiEkle.Click += new System.EventHandler(this.btnKisiEkle_Click_1);
            // 
            // txtBolgeEkle
            // 
            this.txtBolgeEkle.Location = new System.Drawing.Point(299, 311);
            this.txtBolgeEkle.Margin = new System.Windows.Forms.Padding(4);
            this.txtBolgeEkle.Name = "txtBolgeEkle";
            this.txtBolgeEkle.Size = new System.Drawing.Size(187, 22);
            this.txtBolgeEkle.TabIndex = 12;
            // 
            // txtKisiEkle
            // 
            this.txtKisiEkle.Location = new System.Drawing.Point(79, 312);
            this.txtKisiEkle.Margin = new System.Windows.Forms.Padding(4);
            this.txtKisiEkle.Name = "txtKisiEkle";
            this.txtKisiEkle.Size = new System.Drawing.Size(187, 22);
            this.txtKisiEkle.TabIndex = 11;
            // 
            // lbxEslesmeler
            // 
            this.lbxEslesmeler.FormattingEnabled = true;
            this.lbxEslesmeler.ItemHeight = 16;
            this.lbxEslesmeler.Location = new System.Drawing.Point(529, 43);
            this.lbxEslesmeler.Margin = new System.Windows.Forms.Padding(4);
            this.lbxEslesmeler.Name = "lbxEslesmeler";
            this.lbxEslesmeler.Size = new System.Drawing.Size(192, 292);
            this.lbxEslesmeler.TabIndex = 10;
            // 
            // lbxBolgeler
            // 
            this.lbxBolgeler.FormattingEnabled = true;
            this.lbxBolgeler.ItemHeight = 16;
            this.lbxBolgeler.Location = new System.Drawing.Point(299, 43);
            this.lbxBolgeler.Margin = new System.Windows.Forms.Padding(4);
            this.lbxBolgeler.Name = "lbxBolgeler";
            this.lbxBolgeler.Size = new System.Drawing.Size(187, 260);
            this.lbxBolgeler.TabIndex = 9;
            // 
            // lbxKisiler
            // 
            this.lbxKisiler.FormattingEnabled = true;
            this.lbxKisiler.ItemHeight = 16;
            this.lbxKisiler.Location = new System.Drawing.Point(79, 43);
            this.lbxKisiler.Margin = new System.Windows.Forms.Padding(4);
            this.lbxKisiler.Name = "lbxKisiler";
            this.lbxKisiler.Size = new System.Drawing.Size(187, 260);
            this.lbxKisiler.TabIndex = 8;
            // 
            // AskerDagitim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDagitimYap);
            this.Controls.Add(this.btnBolgeEkle);
            this.Controls.Add(this.btnKisiEkle);
            this.Controls.Add(this.txtBolgeEkle);
            this.Controls.Add(this.txtKisiEkle);
            this.Controls.Add(this.lbxEslesmeler);
            this.Controls.Add(this.lbxBolgeler);
            this.Controls.Add(this.lbxKisiler);
            this.Name = "AskerDagitim";
            this.Text = "AskerDagitim";
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