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
    public partial class BuyukKucukBulma : Form
    {
        public BuyukKucukBulma()
        {
            InitializeComponent();
        }
        bool flag=false;

        private void button1_Click(object sender, EventArgs e)
        {   // hata labelini ikinci basışında kaybolmasını sağlar.
            label3.Visible = false;


            int ilk=0, iki=0;
            try
            {
                 ilk = Convert.ToInt32(textBox1.Text);
                 iki = Convert.ToInt32(textBox2.Text);
                
            }
            catch(Exception ex)
            {
                label3.Visible = true;
                label3.Text = ex.Message;
                textBox1.Text = "sadece tamsayı gir";
                textBox2.Text = "sadece tamsayı gir";
                flag = true;
            }
            if(flag == false)
            {
                if (ilk > iki)
                {
                    textBox3.Text = ilk.ToString();
                }
                else if (iki > ilk)
                {
                    textBox3.Text= iki.ToString();
                }
                else
                {   // her ikiside olur. eşittirler.
                    textBox3.Text = iki.ToString();
                }
            }
            flag = false;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
