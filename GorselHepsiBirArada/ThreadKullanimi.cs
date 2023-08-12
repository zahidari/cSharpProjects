using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;// bunu eklemeyi unutma!!

namespace GorselHepsiBirArada
{
    public partial class ThreadKullanimi : Form
    {
        public ThreadKullanimi()
        {
            InitializeComponent();
            Form.CheckForIllegalCrossThreadCalls = false;
        }
        public void ProgressDoldur(ProgressBar prgBar,Label lbl,int min, int max)
        {
            prgBar.Minimum = min;
            prgBar.Maximum = max;
            prgBar.Step = 5;
            for(int i = prgBar.Minimum; i <= prgBar.Maximum; i++)
            {
                prgBar.Value = i;
                lbl.Text = i.ToString();
            }
        }


        private void ThreadKullanimi_Load(object sender, EventArgs e)
        {
            //yukarıya using System.Threading; yaz
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread start1 = new Thread(delegate () { ProgressDoldur(progressBar1, label1, 0, 10000); });
            Thread start2 = new Thread(delegate () { ProgressDoldur(progressBar2, label2, 0, 100); });
            Thread start3 = new Thread(delegate() { ProgressDoldur(progressBar3, label3, 0, 10); });
            start1.Start();
            start2.Start();
            start3.Start();
        }
    }
}
