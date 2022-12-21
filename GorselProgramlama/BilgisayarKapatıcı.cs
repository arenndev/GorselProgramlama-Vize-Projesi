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
    public partial class BilgisayarKapatıcı : Form
    {
        public BilgisayarKapatıcı()
        {
            InitializeComponent();
        }

        DateTime closeDate;
        Timer timer; //Timer classı içerisine timer nesnesi oluşturuldu.
        private void Form1_Load(object sender, EventArgs e)
        {
            timer = timer1; // timer değişlenine timer1 atandı.

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now >= closeDate) //Şuanki zaman kapanma zamanından büyük veya eşitse çalışır
            {
                System.Diagnostics.Process.Start("shutdown", "-f -s -t 0"); //Bİlgisayarı kapatma kodu
                timer.Stop();
                return;
            }
            label1.Text = (closeDate - DateTime.Now).ToString(); // kalan zamanı yazdırma
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double days = Convert.ToDouble(textBox1.Text);  // textBox1'in yazısını double değişkenine çeviriğ days değişkenine atar.
            double hours = Convert.ToDouble(textBox2.Text); // textBox2'nin yazısını double değişkenine çeviriğ days değişkenine atar.
            double minutes = Convert.ToDouble(textBox3.Text); // textBox3'ün yazısını double değişkenine çeviriğ days değişkenine atar.
            double seconds = Convert.ToDouble(textBox4.Text); // textBox4'ün yazısını double değişkenine çeviriğ days değişkenine atar.
            closeDate = DateTime.Now // Şu anki zamana günleri saati dakikayı ve saniyeyi ekler
                .AddDays(days)
                .AddHours(hours)
                .AddMinutes(minutes)
                .AddSeconds(seconds);
            timer.Start();
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer.Stop();  // timerı durdurur
            label1.Text = "Kapalı";
            button2.Enabled = false;
        }
    }
}
