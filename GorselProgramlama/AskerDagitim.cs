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
    public partial class AskerDagitim : Form
    {
        public AskerDagitim()
        {
            InitializeComponent();
        }

        string[] kisilerDizisi = new string[0];    // "kisilerDizisi" adında array list oluşturur.
        string[] bolgelerDizisi = new string[0];   // "bolgelerDizisi" adında array list oluşturur.
        string[] esleme = new string[0];           // "eslesme" adında array list oluşturur.
        string[] deneme = new string[0];           // "deneme" adında array list oluşturur.
        bool donsunmu = true;                      // "donsunmu" adında boolean tanımlar "true" değerine eşitler.
        Random rastgelebolge = new Random();       // "Random" sınıfınfa "rastgelebolge" adında nesne oluşturur.
        

        private void btnKisiEkle_Click_1(object sender, EventArgs e) // kişi ekleme işlemi yapar
        {
            if (txtKisiEkle.Text != "") // Eğer txtKisiEkle.Text boş değil ise
            {
                lbxKisiler.Items.Add(txtKisiEkle.Text);   // KisiEKle textboxına girilen ismi lbxKisiler'e  ekler.
                Array.Resize(ref kisilerDizisi, kisilerDizisi.Length + 1); // kisilerDizisi array listesinin boytunu 1 arttırır.
                kisilerDizisi[kisilerDizisi.Length - 1] = txtKisiEkle.Text; // KisiEkleden gelen veriyi kisilerDizisi'nin sonuna ekler.
                txtKisiEkle.Clear(); // txt.KisiEkle textboxı temizler.
            }
        }

        private void btnBolgeEkle_Click_1(object sender, EventArgs e) // bölge ekleme işlemi yapar
        {
            if (txtBolgeEkle.Text != "")    // Eğer txtKisiEkle.Text boş değil ise
            {
                lbxBolgeler.Items.Add(txtBolgeEkle.Text); // BolgeEkle textboxına girilen ismi lbxBolgeler'e  ekler.
                Array.Resize(ref bolgelerDizisi, bolgelerDizisi.Length + 1); // kisilerDizisi array listesinin boytunu 1 arttırır.
                bolgelerDizisi[bolgelerDizisi.Length - 1] = txtBolgeEkle.Text; // BolgeEkle den gelen veriyi bolgelerDizisi'nin sonuna ekler.
                txtBolgeEkle.Clear();
            }
        }

        private void btnDagitimYap_Click(object sender, EventArgs e) // dağıtım işlemi yapar
        {
            lbxEslesmeler.Items.Clear();    // Eslesmeler isimli listboxı temizler.
            int kisi = kisilerDizisi.Count(); // kisi adında integer değişken tanımlar, kisilerDizisinin toplam öğeyi değer olarak atar.
            foreach (string a in kisilerDizisi)
            {
                int sayicek = rastgelebolge.Next(0, bolgelerDizisi.Count()); // sayicek adında integer değişken tanımlar. 
                Array.Resize(ref deneme, deneme.Length + 1);                 // "deneme" isimli array listin uzunluğunu 1 arttırr.
                deneme[deneme.Length - 1] = sayicek.ToString() + ";";       // Deneme arrayinin son elemanını sayicek değişkenini atar
                Array.Resize(ref esleme, esleme.Length + 1);                // esleme arrayinin boyutunu 1 arttırır
                esleme[esleme.Length - 1] = a + "-" + bolgelerDizisi[sayicek] + ";"; // kişi - bolge olarak son elemana ekler
                lbxEslesmeler.Items.Add(a + "-" + bolgelerDizisi[sayicek]); // Eslesmeler listboxuna ekler
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



    }
}
