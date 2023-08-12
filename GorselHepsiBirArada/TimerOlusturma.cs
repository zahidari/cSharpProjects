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
    public partial class TimerOlusturma : Form
    {
        public TimerOlusturma()
        {
            InitializeComponent();
        }

        private void TimerOlusturma_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;// timer nesnesini aktif ettik.
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random renk = new Random();
            this.BackColor = Color.FromArgb(renk.Next(1, 100), renk.Next(1, 100), renk.Next(1, 100));

        }
    }
}
