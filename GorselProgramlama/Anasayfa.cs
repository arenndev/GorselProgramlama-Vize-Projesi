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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AskerDagitim form2 = new AskerDagitim();
            form2.Show(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SlotMakine form3 = new SlotMakine();    
            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PokerOyunu form4 = new PokerOyunu();
            form4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BuyukUnluUyumu form5 = new BuyukUnluUyumu();
            form5.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BilgisayarKapatıcı form6 = new BilgisayarKapatıcı();
            form6.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SatrancAtinHareketi form7 =  new SatrancAtinHareketi();
            form7.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            HesapMakinesi form8 = new HesapMakinesi();
            form8.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            NotDefteri form9 = new NotDefteri();
            form9.Show();
        }
    }
}
