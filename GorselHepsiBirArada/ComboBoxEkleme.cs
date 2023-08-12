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
    public partial class ComboBoxEkleme : Form
    {
        public ComboBoxEkleme()
        {
            InitializeComponent();
        }
        // burda flag kullandık ki button 2 1 defa çalışsın(global variable)
        bool flag = false;


        private void button1_Click(object sender, EventArgs e)
        {
            this.AutoSize = true;// otomatik sığdırma

            for(int i = 0; i< 7; i++)
            {
                ComboBox cmb = new ComboBox();
                cmb.Location = new Point(5, i * 35);
                cmb.BackColor = Color.FromArgb(240, i * 30, i * 20);
                cmb.Items.Add(i*40);
                this.Controls.Add(cmb);
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (flag == false)//flag sayesinde 1 kere ekleme yaptık
            {
                string[] hafta = { "Pazartesi", "Salı", "çarşamba", "perşembe", "cuma", "cumartesi", "pazar" }; ;

                foreach (string str in hafta)
                {
                    comboBox1.Items.Add(str);
                }
            }
            flag= true;
        }
    }
}
