using System;
using System.Collections;
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
    public partial class PokerOyunu : Form
    {
        public PokerOyunu()
        {
            InitializeComponent();
        }


        ArrayList kartlar = new ArrayList(); // kartlar adında array oluşturur
        string[] kartTur = new string[] { "Maça", "Karo", "Sinek", "Kupa" }; // kartTur adında array list oluşturur ve değer atamalarını yapar
        string[] kartNo = new string[] { "As", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Vale", "Kız", "Papaz" }; // karNo adında array list oluşturur ve değer atamalarını yapar.
        Random rasgele = new Random(); // Rastgele adında Random classı oluşturur.
        ArrayList oyuncu1deger = new ArrayList(); // oyuncu1deger adında array list oluşturur
        ArrayList oyuncu2deger = new ArrayList(); // oyuncu2deger adında array list oluşturur
        ArrayList oyuncu3deger = new ArrayList(); // oyuncu3deger adında array list oluşturur
        ArrayList oyuncu4deger = new ArrayList(); // oyuncu4deger adında array list oluşturur
        int sayac = 0; // sayac adında integer değişken oluşturur
        string yazi;   // yazi adında string değişken oluşturur

        void yazdirma()         // yazdirma adında fonksiyon tanımlar
        {
            if (sayac == 0)
            {
                yazi = "Elinizde bir şey yok";

            }

            if (sayac == 1)
            {
                yazi = "Elinizde ikili var";
            }

            if (sayac == 2)
            {
                yazi = "Elinizde üçlü var";
            }
            if (sayac == 3)
            {
                yazi = "Elinizde dörtlü var";
            }
            if (sayac == 4)
            {
                yazi = "Elinizde beşli var";
            }
        }

        private void button2_Click(object sender, EventArgs e)  // Buton 2ye tıklandığında "Çıkmak istediğinize emin misiniz" MessageBox olarak sorar.
        {                                                       // Cevap evet ise uygulamayı kapatır.
            DialogResult sonuc;
            sonuc = MessageBox.Show("Çıkmak İstediğinizden Eminmisiniz?", "Uyarı", MessageBoxButtons.OKCancel);
            {
                if (sonuc == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Buton 1'e tıklandığında listboxları temizler.
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            label5.Text = "1.Oyuncu"; // Kartlar dağıtım işlemi yapıldıktan sonra oyuncu numaraları
            label6.Text = "2.Oyuncu"; // silmemsi için numalaraları labellara atadım.
            label7.Text = "3.Oyuncu";
            label8.Text = "4.Oyuncu";
            kartlar.Clear();
            //Oyuncular için kartları oluşturur.
            for (int i = 0; i < kartTur.Length; i++)
            {
                for (int x = 0; x < kartNo.Length; x++)
                {
                    string gelenkart = kartTur[i] + "-" + kartNo[x];
                    kartlar.Add(gelenkart);
                }
            }
            // 1.Oyuncu için kartları oluşturur, RomoveAt ile aynı kartın oyuncuya terkar gelmemesi sağlanır.
            for (int i = 0; i < 5; i++)
            {
                int gidenkart = rasgele.Next(0, kartlar.Count);
                listBox1.Items.Add(kartlar[gidenkart]);
                kartlar.RemoveAt(gidenkart);
            }
            // 2.Oyuncu için kartları oluşturur, RomoveAt ile aynı kartın oyuncuya terkar gelmemesi sağlanır.
            for (int i = 0; i < 5; i++)
            {
                int gidenkart = rasgele.Next(0, kartlar.Count);
                listBox2.Items.Add(kartlar[gidenkart]);
                kartlar.RemoveAt(gidenkart);
            }
            // 3.Oyuncu için kartları oluşturur, RomoveAt ile aynı kartın oyuncuya terkar gelmemesi sağlanır.

            for (int i = 0; i < 5; i++)
            {
                int gidenkart = rasgele.Next(0, kartlar.Count);
                listBox3.Items.Add(kartlar[gidenkart]);
                kartlar.RemoveAt(gidenkart);
            }
            // 4.Oyuncu için kartları oluşturur, RomoveAt ile aynı kartın oyuncuya terkar gelmemesi sağlanır.

            for (int i = 0; i < 5; i++)
            {
                int gidenkart = rasgele.Next(0, kartlar.Count);
                listBox4.Items.Add(kartlar[gidenkart]);
                kartlar.RemoveAt(gidenkart);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Oyuncuların ellerindeki kartlar kontrol edilir.
            {
                foreach (string item in listBox1.Items)  // 1.Oyuncu için;
                {
                    string[] dizi = item.Split('-');     // kartları - işaretine göre ayırıyorum, ikinci kısmı index 1 oluyor, ayrı bir diziye alıyorum.
                    if (oyuncu1deger.Contains(dizi[1]))  // dizideki elemanı önceden tanımladığım dizi içinde arıyorum, burada ilk elemanı hemen diziye atmıyorum, çünkü kendisinden sonraki ile kıyaslanması gerekiyor.
                    {
                        sayac++;                         // eğer içeriyor ise sayaç++
                    }
                    oyuncu1deger.Add(dizi[1]);           // dizinin elemanının, kıyaslayacağım diziye eklenmesi..
                }
                yazdirma();                              //methodumu çağırıyorum..
                label5.Text = yazi;                      // methodumdaki yapıya göre yazı değişkenine ne geldi ise, ilgili alana yazdırıyorum.

                sayac = 0;                               // yeni dağıtım için sıfırlama işlemim, hem dizi hem sayaç.. Aynı şekilde diğer oyuncular içinde aşağıdaki işlemler bu şekilde yapılıyor.
                oyuncu1deger.Clear();
            }
            {
                foreach (string item in listBox2.Items) // Diğer oyuncular için aynı işlem tekrarlanır.
                {
                    string[] dizi = item.Split('-');
                    if (oyuncu2deger.Contains(dizi[1]))
                    {
                        sayac++;
                    }
                    oyuncu2deger.Add(dizi[1]);
                }
                yazdirma();
                label6.Text = yazi;
                sayac = 0;
                oyuncu2deger.Clear();
            }
            {
                foreach (string item in listBox3.Items)
                {
                    string[] dizi = item.Split('-');
                    if (oyuncu3deger.Contains(dizi[1]))
                    {
                        sayac++;
                    }
                    oyuncu3deger.Add(dizi[1]);
                }
                yazdirma();
                label7.Text = yazi;
                sayac = 0;
                oyuncu3deger.Clear();
            }
            {
                foreach (string item in listBox4.Items)
                {
                    string[] dizi = item.Split('-');
                    if (oyuncu4deger.Contains(dizi[1]))
                    {
                        sayac++;
                    }
                    oyuncu4deger.Add(dizi[1]);
                }
                yazdirma();
                label8.Text = yazi;
                sayac = 0;
                oyuncu4deger.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
