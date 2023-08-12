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
    public partial class arkaPlanDegistir : Form
    {
        public arkaPlanDegistir()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //üst başlık değişecektir.
            this.Text = "Form2 button1 e tıkladınız.";
            //arka plan değişti
            this.BackColor = Color.Tomato;
            //button kayboldu.
            button1.Visible = false;
            button2.Visible = true;    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Text = "Form2 button2 ye tıkladınız.";
            this.BackColor = Color.Brown;
            button1.Visible = true;
            button2.Visible = false;
        }
    }
}
