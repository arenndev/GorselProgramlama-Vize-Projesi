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
    public partial class SlotMakine : Form
    {
        public SlotMakine()
        {
            InitializeComponent();
        }


        private int jetonSayisi = 0; // Kasada kaç jeton olduğunu tutan değişken
        private bool onceParaVerdigi = false; // Makinanın daha önce para verip vermediğini tutan değişken
        private Random rng = new Random(); // Rastgele sayı üretebilmek için kullanılacak nesne

        private void OynaDugme_Click(object sender, EventArgs e)
        {
            // Kullanıcının oynaması için yeterli jeton olup olmadığını kontrol edin
            if (jetonSayisi < 1)
            {
                MessageBox.Show("Önce para eklemelisiniz!");
                return;
            }
            jetonSayisi--; // Oynandığı için jeton sayısını azaltın
            JetonSayisiEtiket2.Text = jetonSayisi.ToString(); // Jeton sayısını güncelleyin

            if (jetonSayisi >= 10 && !onceParaVerdigi)
            {
                // %20 kazanma şansı
                if (rng.Next(1, 101) <= 20)
                {
                    MessageBox.Show("KAZANDINIZ!");
                    onceParaVerdigi = true; // Makina şimdi para verdi, bundan sonra %5 kazanma şansı verilecek
                }
                else
                {
                    MessageBox.Show("Kaybettiniz :(");
                }
            }
            else if (jetonSayisi >= 10 && onceParaVerdigi)
            {
                // %5 kazanma şansı
                if (rng.Next(1, 101) <= 5)
                {
                    MessageBox.Show("KAZANDINIZ!");
                }


                else if (jetonSayisi >= 10 && onceParaVerdigi)
                {
                    // %5 kazanma şansı
                    if (rng.Next(1, 101) <= 5)
                    {
                        MessageBox.Show("KAZANDINIZ!");
                    }
                    else
                    {
                        MessageBox.Show("Kaybettiniz :(");
                    }
                }

            }
            else
            {
                MessageBox.Show("Kaybettiniz :(");
            }
            GuncelleKazanmaIhtimali();
        }

        private void ParaEkleDugme_Click(object sender, EventArgs e)
        {
            // Kasaya 1 jeton ekleyin
            jetonSayisi++;
            JetonSayisiEtiket2.Text = jetonSayisi.ToString();
            GuncelleKazanmaIhtimali();
        }

        private void GuncelleKazanmaIhtimali()
        {
            if (jetonSayisi < 10)
            {
                KazanmaIhtimaliEtiket.Text = "Kazanma ihtimali: 0%";
            }
            else if (!onceParaVerdigi)
            {
                KazanmaIhtimaliEtiket.Text = "Kazanma ihtimali: 20%";
            }
            else
            {
                KazanmaIhtimaliEtiket.Text = "Kazanma ihtimali: 5%";
            }
        }
    }
}
