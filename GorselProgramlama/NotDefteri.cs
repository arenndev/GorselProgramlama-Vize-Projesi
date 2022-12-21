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

namespace GorselProgramlama
{
    public partial class NotDefteri : Form
    {
        public NotDefteri()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            btnGeriAl.Enabled = textBox1.CanUndo;
            btnYinele.Enabled = textBox1.CanUndo;
        }

        // seçili metni keser
        private void btnKes_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        // seçili metni kopyalar
        private void btnKopyala_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        // panodaki metni seçilen yere yapıştırır.
        private void btnYapıştır_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        // son değişikliği geri alır.
        private void btnGeriAl_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }

        // yineleme işlemi:
        // text box yapılan sadece bir değişikliği geri alabildiği için
        // yapılan değişikliği geri alma işlemini geri alır,
        // dolayısıyla önceki haline döner. 
        private void btnYinele_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }

        // seçili metin varsa kes, kopyala, yapıştır butonlarını kullanılabilir yap.
        private void textBox1_Click(object sender, EventArgs e)
        {
            btnKes.Enabled = textBox1.SelectionLength > 0;
            btnKopyala.Enabled = textBox1.SelectionLength > 0;
            btnYapıştır.Enabled = Clipboard.GetText().Length > 0;
        }

        // metni sola hizala
        private void btnSola_Click(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Left;

            btnSola.Checked = true;
            btnSaga.Checked = false;
            btnOrtala.Checked = false;
        }

        // metni ortaya hizala
        private void btnOrtala_Click(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Center;

            btnSola.Checked = false;
            btnSaga.Checked = false;
            btnOrtala.Checked = true;

        }

        // metni sağa hizala
        private void btnSaga_Click(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Right;

            btnSola.Checked = false;
            btnSaga.Checked = true;
            btnOrtala.Checked = false;

        }

        // sözcük kaydırı aktif/deaktif et
        private void btnKelimeKaydır_Click(object sender, EventArgs e)
        {
            textBox1.WordWrap = !textBox1.WordWrap;
            btnKelimeKaydır.Checked = textBox1.WordWrap;
        }

        // basılan keylere göre caps lock ve num lock durumlarını güncelle
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            lblCAPS.Text = Console.CapsLock ? "CAPS" : "";
            lblNUM.Text = Console.NumberLock ? "NUM" : "";
        }

        // yazı rengini ayarlamak için renk dialoğunu açar
        private void btnYazıRengi_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = colorDialog1.Color;
            }
        }

        // zemin rengini ayarlamak için renk dialoğunu açar
        private void btnZeminRengi_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.BackColor = colorDialog1.Color;
            }
        }

        // yazı tipini ayarlamak için yazı tipi diaolğunu açar.
        private void btnYaziTipi_Click(object sender, EventArgs e)
        {
            try
            {
                // dialoğun açılıştaki fontu metin kutusunun fontu olsun
                fontDialog1.Font = textBox1.Font;

                // yazı seçilip ok denildikten sonra yazı tipini metne uygula
                if (fontDialog1.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Font = fontDialog1.Font;
                    // seçilen rengi de yazı rengine uygula
                    textBox1.ForeColor = fontDialog1.Color;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // yeni döküman 
        private void btnYeni_Click(object sender, EventArgs e)
        {
            // kendisinin bir kopyasını çalıştırır.
            System.Diagnostics.Process.Start(Application.ProductName);
        }

        // dosya_adı değişkeni dosya açma kaydetme işlemlerinde kullanılacak
        string dosya_adı = null;

        // dosya açma işlemi
        private void btnAç_Click(object sender, EventArgs e)
        {
            // eğer dosya açma dialoğunda dosya seçilmiş ve tamam denilmiş ise
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // dosya adı seçilen dosya olacak.
                dosya_adı = openFileDialog1.FileName;

                // seçilen dosya ile programımız arasına bir boru hattı açıyoruz
                StreamReader sr = new StreamReader(
                   openFileDialog1.FileName,
                   Encoding.GetEncoding(1254) // Türkçe dil kodu
                   );

                // borudan dosyayı sonuna kadar okuyoruz.
                textBox1.Text = sr.ReadToEnd();

                // sonra boruyu kapatıyoruz. 
                sr.Close();

                // formun başlığına dosya adını ekliyoruz.
                this.Text = "Not Defteri [" + dosya_adı + "]";
            }
        }

        // farklı kaydetme işlemi
        private void farklıKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // eğer dosya açma dialoğunda dosya seçilmiş ve tamam denilmiş ise
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // dosya adı seçilen dosya olacak.
                dosya_adı = saveFileDialog1.FileName;

                // kaydetme işlemine git
                btnKaydet_ButtonClick(null, null);
            }
        }

        // kaydetme işlemi
        private void btnKaydet_ButtonClick(object sender, EventArgs e)
        {
            // eğer ilk defa kaydetmek istiyorsak dosya adı için farklı kaydeti çalıştır
            if (dosya_adı == null)
            {
                // farklı kaydete git
                farklıKaydetToolStripMenuItem_Click(null, null);
            }
            else
            {
                // daha önce kaydetmiş isek elimizde zaten bir dosya adı var, 
                // yapılan değişiklikler önceki dosyanın üzerine yazılacak.

                // programımız ile diskteki dosya arasına bir boru hattı açıyoruz.
                StreamWriter sw = new StreamWriter(
                   dosya_adı, false,
                   Encoding.GetEncoding(1254)); // Türkçe dil kodu

                // borudan tüm bilgiyi diskteki dosyaya akıtıyoruz.
                sw.Write(textBox1.Text);

                // sonra boruda kalan bilgiyi de silkeliyoruz.
                sw.Flush();

                // sonra boruyu kapatıyoruz.
                sw.Close();

                // formun başlığına dosya adını ekliyoruz.
                this.Text = "Not Defteri [" + dosya_adı + "]";
            }

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
