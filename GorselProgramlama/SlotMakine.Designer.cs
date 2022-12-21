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
            this.label2.Location = new System.Drawing.Point(112, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Jeton Sayısı";
            // 
            // KazanmaIhtimaliEtiket
            // 
            this.KazanmaIhtimaliEtiket.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KazanmaIhtimaliEtiket.Location = new System.Drawing.Point(9, 17);
            this.KazanmaIhtimaliEtiket.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.KazanmaIhtimaliEtiket.Name = "KazanmaIhtimaliEtiket";
            this.KazanmaIhtimaliEtiket.Size = new System.Drawing.Size(272, 32);
            this.KazanmaIhtimaliEtiket.TabIndex = 9;
            this.KazanmaIhtimaliEtiket.Text = "Kazanma İhtimali";
            // 
            // ParaEkleDugme
            // 
            this.ParaEkleDugme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ParaEkleDugme.Location = new System.Drawing.Point(52, 152);
            this.ParaEkleDugme.Margin = new System.Windows.Forms.Padding(2);
            this.ParaEkleDugme.Name = "ParaEkleDugme";
            this.ParaEkleDugme.Size = new System.Drawing.Size(79, 57);
            this.ParaEkleDugme.TabIndex = 8;
            this.ParaEkleDugme.Text = "Para Ekle";
            this.ParaEkleDugme.UseVisualStyleBackColor = true;
            this.ParaEkleDugme.Click += new System.EventHandler(this.ParaEkleDugme_Click);
            // 
            // JetonSayisiEtiket2
            // 
            this.JetonSayisiEtiket2.Location = new System.Drawing.Point(88, 104);
            this.JetonSayisiEtiket2.Margin = new System.Windows.Forms.Padding(2);
            this.JetonSayisiEtiket2.Name = "JetonSayisiEtiket2";
            this.JetonSayisiEtiket2.Size = new System.Drawing.Size(123, 20);
            this.JetonSayisiEtiket2.TabIndex = 7;
            // 
            // OynaDugme
            // 
            this.OynaDugme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OynaDugme.Location = new System.Drawing.Point(158, 150);
            this.OynaDugme.Margin = new System.Windows.Forms.Padding(2);
            this.OynaDugme.Name = "OynaDugme";
            this.OynaDugme.Size = new System.Drawing.Size(79, 58);
            this.OynaDugme.TabIndex = 6;
            this.OynaDugme.Text = "Oyna";
            this.OynaDugme.UseVisualStyleBackColor = true;
            this.OynaDugme.Click += new System.EventHandler(this.OynaDugme_Click);
            // 
            // SlotMakine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 241);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.KazanmaIhtimaliEtiket);
            this.Controls.Add(this.ParaEkleDugme);
            this.Controls.Add(this.JetonSayisiEtiket2);
            this.Controls.Add(this.OynaDugme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SlotMakine";
            this.Text = "Slot Makinesi - 212106062 - Umut Kuzu";
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