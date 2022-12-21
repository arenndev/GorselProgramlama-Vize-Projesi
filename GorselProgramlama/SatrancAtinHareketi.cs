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
    public partial class SatrancAtinHareketi : Form
    {
        public SatrancAtinHareketi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            //Metin kutusundan giriş alır.
            string input = textBox1.Text;


            if (input.Length < 2)    // İnput 2 karakterden küçük girilirse MessageBox göster.
            {
                MessageBox.Show("Lütfen Geçerli Bir Kordinat Giriniz");
                return;
            }

            // At'ın pozisyonunun satırını ve sütununu almak için girişi ayırır.
            char column;
            int row;

            // Geçersiz kordinat girilirse try catch çalışır
            try
            {
                column = input[0];
                row = int.Parse(input[1].ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Geçerli Bir Kordinat Giriniz");
                return;
            }

            if (row > 8 || row < 1 || column < 'A' || column > 'H')
            {
                MessageBox.Show("Lütfen Geçerli Bir Kordinat Girin");
                return;
            }

            // Olası pozisyonları tutmak için liste oluşturur.
            List<string> possiblePositions = new List<string>();

            // At için tüm olası pozisyonları kontrol eder.
            if (column - 2 >= 'A' && row - 1 >= 1) possiblePositions.Add((char)(column - 2) + (row - 1).ToString());
            if (column - 2 >= 'A' && row + 1 <= 8) possiblePositions.Add((char)(column - 2) + (row + 1).ToString());
            if (column - 1 >= 'A' && row - 2 >= 1) possiblePositions.Add((char)(column - 1) + (row - 2).ToString());
            if (column - 1 >= 'A' && row + 2 <= 8) possiblePositions.Add((char)(column - 1) + (row + 2).ToString());
            if (column + 1 <= 'H' && row - 2 >= 1) possiblePositions.Add((char)(column + 1) + (row - 2).ToString());
            if (column + 1 <= 'H' && row + 2 <= 8) possiblePositions.Add((char)(column + 1) + (row + 2).ToString());
            if (column + 2 <= 'H' && row - 1 >= 1) possiblePositions.Add((char)(column + 2) + (row - 1).ToString());
            if (column + 2 <= 'H' && row + 1 <= 8) possiblePositions.Add((char)(column + 2) + (row + 1).ToString());

            // Listbox'ı temizler.
            listBox1.Items.Clear();

            // Olası pozisyonları listbox'a ekler.
            foreach (string position in possiblePositions)
            {
                listBox1.Items.Add(position);
            }
        }
    }
}
