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
    public partial class DizilerForm : Form
    {
        public DizilerForm()
        {
            InitializeComponent();
        }

        int[] arr;// global bir array tanımladık.
        int arrLen = 1;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Clear();
                ++arrLen;
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            arr = new int[arrLen];//.items.count önemli
            // burası 2 kere farklı eklemde hata veriyor out of Range

            
            for(int i =0; i<arrLen-1;i++)
            {
                arr[i] = Convert.ToInt32(listBox1.Items[i]);
                textBox2.Text += arr[i].ToString();
            }


            // list boxu temizler ki array'a
            // iki kere aynı şeyi eklememek için.
            listBox1.Items.Clear();
        }
    }
}
