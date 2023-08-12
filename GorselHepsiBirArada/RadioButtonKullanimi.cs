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
    public partial class RadioButtonKullanimi : Form
    {
        public RadioButtonKullanimi()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "Çemberi seçtiniz.";
        }
    }
}
