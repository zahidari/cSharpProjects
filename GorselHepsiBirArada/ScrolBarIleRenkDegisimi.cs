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
    public partial class ScrolBarIleRenkDegisimi : Form
    {
        public ScrolBarIleRenkDegisimi()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int r, g, b;

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            this.BackColor = Color.FromArgb(vScrollBar1.Value, vScrollBar2.Value, vScrollBar3.Value);
        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            this.BackColor = Color.FromArgb(vScrollBar1.Value, vScrollBar2.Value, vScrollBar3.Value);
        }

        private void vScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            this.BackColor = Color.FromArgb(vScrollBar1.Value, vScrollBar2.Value, vScrollBar3.Value);
        }

        

        private void ScrolBarIleRenkDegisimi_Load(object sender, EventArgs e)
        {
            r = rnd.Next(0,255);
            g = rnd.Next(0,255);
            b = rnd.Next(0,255);

            this.BackColor = Color.FromArgb(r,g,b);

            vScrollBar1.Value = r;
            vScrollBar2.Value = g;
            vScrollBar3.Value = b;
        }

    }
}
