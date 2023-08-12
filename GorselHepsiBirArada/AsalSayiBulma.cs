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
    public partial class AsalSayiBulma : Form
    {
        public AsalSayiBulma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = 0;
            bool flag = false;
            try
            {
                sayi = Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                textBox1.Text = "positif sayi gir";
                return;
            }

            for(int i =2; i <= sayi/2; i++)
            {
                if (sayi % i == 0)
                {
                    flag = true;
                    
                    break;
                } 
            }
            if(flag == true)
            {
                label2.Text = "Asal değildir.";
            }
            else
            {
                label2.Text = "Asaldır.";
            }
            flag = false;
          
        }
    }
}
