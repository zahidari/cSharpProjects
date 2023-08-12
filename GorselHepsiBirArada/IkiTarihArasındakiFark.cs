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
    public partial class IkiTarihArasındakiFark : Form
    {
        public IkiTarihArasındakiFark()
        {
            InitializeComponent();
        }

        private void IkiTarihArasındakiFark_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text =Math.Abs((dateTimePicker1.Value - dateTimePicker2.Value).Days).ToString()+" gün";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = Math.Abs((dateTimePicker1.Value - dateTimePicker2.Value).Days).ToString() + " gün";
        }
    }
}
