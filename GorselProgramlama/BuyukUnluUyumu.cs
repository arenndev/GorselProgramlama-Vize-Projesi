using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselProgramlama
{
    public partial class BuyukUnluUyumu : Form
    {
        public BuyukUnluUyumu()
        {
            InitializeComponent();
        }

        string kalinharfler = "AIOUaıou"; // kalinharfler isimli string değişken oluşturuldu "AIOUaıou" değer ataması yapıldı.
        string inceharfler = "EİÖÜeiöü"; // inceharfler isimli string değişken oluşturuldu "EİÖÜeiöü" değer ataması yapıldı.
        string rakamlar = "0123456789";  // rakamlar isimli string değişken oluşturuldu "01234567789" değer ataması yapıldı.
        string metin;                   // metin isimli string değişken oluşturuldu. Değer ataması yapılmadı.

        private void button1_Click(object sender, EventArgs e)
        {   // Hatalı kelime girme durumları kontrol ediliyor.
            if (textBox1.Text.Contains(" "))                    // eğer textBox1 " " ise ...
            {
                MessageBox.Show("Lütfen Tek Kelime Giriniz");   // ..ekrana mesaj kutusu çıkar "Lütfen Tek Kelime Giriniz" yazar
                textBox1.Focus();                               // textBox1 'e odaklan komutu
                textBox1.Clear();                               // textBox1 'i temizle
                label1.Text = "";                               // label1 'in yazısına boş değer ata
            }

            else if (textBox1.Text == null)                     // eğer textBox1 null ise
            {
                MessageBox.Show("Lütfen Bir Kelime Giriniz");   // ..ekrana mesaj kutusu çıkar "Lütfen Bir Kelime Giriniz" yazar
                textBox1.Focus();                               // textBox1 'e odaklan komutu
                textBox1.Clear();                               // textBox1 'i temizle
                label1.Text = "";                               // label1 'in yazısına boş değer ata
            }

            else if (textBox1.Text == " ")                      // eğer textBox1 " " ise
            {
                MessageBox.Show("Lütfen Bir Kelime Giriniz");   // ..ekrana mesaj kutusu çıkar "Lütfen Bir Kelime Giriniz" yazar
                textBox1.Focus();                               // textBox1 'e odaklan komutu
                textBox1.Clear();                               // textBox1 'i temizle
                label1.Text = "";                               // label1 'in yazısına boş değer ata
            }
            else { kelimekontrol(); }
        }

        void kelimekontrol()                // kelime kontrol fonksiyonu
        {
            metin = textBox1.Text;          // metin adında değişken oluşturur textBox1'in yazınını bu değişkene atar.
            bool varyok1 = false;           //varyok1 adındaki boolean değişkeni false olarak tanımlar
            bool varyok2 = false;           //varyok2 adındaki boolean değişkeni false olarak tanımlar
            bool varyok3 = false;           //varyok3 adındaki boolean değişkeni false olarak tanımlar

            foreach (char item in metin)
            {
                // kalinharfler değişkenini kontrol eder, eğer kalın harf var ise TRUE
                if (kalinharfler.IndexOf(item) != -1)
                {
                    varyok1 = true;
                }
                // inceharfler değişkenini kontrol eder, eğer ince harf va ise TRUE
                if (inceharfler.IndexOf(item) != -1)
                {
                    varyok2 = true;
                }
                // rakamlar değişkenini kontrol eder , eğer var ise TRUE
                if (rakamlar.IndexOf(item) != -1)
                {
                    varyok3 = true;
                }
            }

            // Kalın harf ve İnce harf ise Büyük ünlü uyumuna uymaz
            if (varyok1 == true && varyok2 == true)
            {
                label1.Text = "Büyük Ünlü Uyumuna Uymuyor";
            }

            else if (varyok1 != varyok2)
            {
                label1.Text = "Büyük Ünlü Uyumuna Uyuyor";
            }
            // Eğer varyok3 true ise kelime rakam içerir.
            else if (varyok3 == true)
            {
                label1.Text = "Kelime lütfen rakam içermesin.";
            }

            else if (varyok3 == true && (varyok1 == true || varyok1 == false || varyok2 == true || varyok2 == false))
            {
                label1.Text = "Kelime lütfen rakam içermesin.";
            }
            // Yukarıdaki durumlardan hiç birine uymuyor ise;
            else
            {
                label1.Text = "Kelime Sesli Harf İçermiyor";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Çıkmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.OKCancel);

            if (sonuc == DialogResult.OK)
            {
                Application.Exit();
            }

        }
    }
}
