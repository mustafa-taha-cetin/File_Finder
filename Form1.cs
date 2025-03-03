using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

 // ----------------yeni kütüphane---------------------
using System.IO;

namespace Metin_Belgesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string dosyaAdi, dosyaYolu;
        StreamWriter sw;

        private void button2_Click(object sender, EventArgs e)
        {
            dosyaAdi = textBox2.Text;
            sw = File.CreateText(dosyaYolu + "//" + dosyaAdi + ".txt");
            sw.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                dosyaYolu = folderBrowserDialog1.SelectedPath.ToString(); // seçtiğimiz alanı dosya yolu olarak belirler
                textBox1.Text = dosyaYolu;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Metin Dosyalar|*.txt"; // filtreleme uyguladık
            saveFileDialog1.Title = "Metin Belgesi Kayıt";
            saveFileDialog1.ShowDialog();
            StreamWriter kaydet = new StreamWriter(saveFileDialog1.FileName);
            kaydet.WriteLine(richTextBox1.Text);
            kaydet.Close();
            MessageBox.Show("Kayıt oluşturuldu");
        }




    }
}
