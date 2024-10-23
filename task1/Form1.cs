using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = int.Parse(textBox1.Text);
            int sayi2 = int.Parse(textBox2.Text);
            int sonuc = 0;
            for (int i = 0; i < sayi2; i++)
            {
                sonuc += sayi1;
            }
            label1.Text = "Sonuç: " + sonuc.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
