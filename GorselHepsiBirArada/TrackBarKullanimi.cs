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
    public partial class TrackBarKullanimi : Form
    {
        public TrackBarKullanimi()
        {
            InitializeComponent();
        }

        private void TrackBarKullanimi_Load(object sender, EventArgs e)
        {
            trackBar1.Minimum = 10;
            trackBar1.Maximum = 25;
            trackBar1.TickFrequency = 2; // trackbarda gösterilecek çizgilerin arası
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {   // font yazı Boyutu demektir.
            textBox1.Font = new Font("Tahoma", trackBar1.Value);
        }
    }
}
