namespace GorselProgramlama
{
    partial class SlotMakine
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
            this.label2 = new System.Windows.Forms.Label();
            this.KazanmaIhtimaliEtiket = new System.Windows.Forms.Label();
            this.ParaEkleDugme = new System.Windows.Forms.Button();
            this.JetonSayisiEtiket2 = new System.Windows.Forms.TextBox();
            this.OynaDugme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(149, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Jeton Sayısı";
            // 
            // KazanmaIhtimaliEtiket
            // 
            this.KazanmaIhtimaliEtiket.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KazanmaIhtimaliEtiket.Location = new System.Drawing.Point(12, 21);
            this.KazanmaIhtimaliEtiket.Name = "KazanmaIhtimaliEtiket";
            this.KazanmaIhtimaliEtiket.Size = new System.Drawing.Size(362, 39);
            this.KazanmaIhtimaliEtiket.TabIndex = 9;
            this.KazanmaIhtimaliEtiket.Text = "Kazanma İhtimali";
            // 
            // ParaEkleDugme
            // 
            this.ParaEkleDugme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ParaEkleDugme.Location = new System.Drawing.Point(69, 187);
            this.ParaEkleDugme.Name = "ParaEkleDugme";
            this.ParaEkleDugme.Size = new System.Drawing.Size(105, 70);
            this.ParaEkleDugme.TabIndex = 8;
            this.ParaEkleDugme.Text = "Para Ekle";
            this.ParaEkleDugme.UseVisualStyleBackColor = true;
            this.ParaEkleDugme.Click += new System.EventHandler(this.ParaEkleDugme_Click);
            // 
            // JetonSayisiEtiket2
            // 
            this.JetonSayisiEtiket2.Location = new System.Drawing.Point(118, 128);
            this.JetonSayisiEtiket2.Name = "JetonSayisiEtiket2";
            this.JetonSayisiEtiket2.Size = new System.Drawing.Size(163, 22);
            this.JetonSayisiEtiket2.TabIndex = 7;
            // 
            // OynaDugme
            // 
            this.OynaDugme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OynaDugme.Location = new System.Drawing.Point(211, 185);
            this.OynaDugme.Name = "OynaDugme";
            this.OynaDugme.Size = new System.Drawing.Size(105, 72);
            this.OynaDugme.TabIndex = 6;
            this.OynaDugme.Text = "Oyna";
            this.OynaDugme.UseVisualStyleBackColor = true;
            this.OynaDugme.Click += new System.EventHandler(this.OynaDugme_Click);
            // 
            // SlotMakine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 297);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.KazanmaIhtimaliEtiket);
            this.Controls.Add(this.ParaEkleDugme);
            this.Controls.Add(this.JetonSayisiEtiket2);
            this.Controls.Add(this.OynaDugme);
            this.Name = "SlotMakine";
            this.Text = "SlotMakine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label KazanmaIhtimaliEtiket;
        private System.Windows.Forms.Button ParaEkleDugme;
        private System.Windows.Forms.TextBox JetonSayisiEtiket2;
        private System.Windows.Forms.Button OynaDugme;
    }
}