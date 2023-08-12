using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselHepsiBirArada
{
    public partial class ListBoxOgrenciVeriIsle : Form
    {
        public ListBoxOgrenciVeriIsle()
        {
            InitializeComponent();
        }

        private void ListBoxOgrenciVeriIsle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a, b, c;
            a = textBox1.Text;
            b = (a.Substring(4, 2));
            c = b;
          
            if (c == "12")
                listBox2.Items.Add("Eğitim Fakültesi");
            else if(c == "13")
                listBox2.Items.Add("Mühendislik Fakültesi");
            else if (c == "14")
                listBox2.Items.Add("Hukuk Fakültesi");
            else if (c == "15")
                listBox2.Items.Add("İletişim Fakültesi");

            int x, y;
            x = Convert.ToInt32(textBox4.Text);
            y = Convert.ToInt32(textBox5.Text);

            if (y > 100 | y < 0)
            {
                MessageBox.Show("hatalı gırıs");
            }
            if (x > 100 | x < 0)
            {
                MessageBox.Show("hatalı gırıs");
            }
            double ort;
            ort = (x * 0.40) + (y * 0.60);
            listBox4.Items.Add(ort);
            if (ort >= 89.5 && ort <= 100)
                listBox5.Items.Add("AA");
            else if (ort >= 79.5 && ort < 89.5)
                listBox5.Items.Add("BA");
            else if (ort >= 69.5 && ort < 79.5)
                listBox5.Items.Add("BB");
            else if (ort >= 59.5 && ort < 69.5)
                listBox5.Items.Add("CB");
            else if (ort >= 49.5 && ort < 59.5)
                listBox5.Items.Add("CC");
            else if (ort >= 39.5 && ort < 49.5)
                listBox5.Items.Add("DD");
            if (ort >= 0 && ort < 39.5)
                listBox5.Items.Add("FF");
            listBox3.Items.Add(textBox2.Text + " " + textBox3.Text);
            string d, son, f;
            d = textBox1.Text;
            son = (d.Substring(2, 2));
            f = "20" + son;
            listBox1.Items.Add(f);

        }
    }
}
