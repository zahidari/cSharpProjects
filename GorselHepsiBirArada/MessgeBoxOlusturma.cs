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
    public partial class MessgeBoxOlusturma : Form
    {
        public MessgeBoxOlusturma()
        {
            InitializeComponent();
        }

        private void MessgeBoxOlusturma_Load(object sender, EventArgs e)
        {

        }

        private void MessgeBoxOlusturma_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show(
                "Programı kapatmak istiyor musunuz?",
                "Program uyarısı",
                MessageBoxButtons.YesNo,
                //YesNo, OKCancel,CancelTryContinue,RetryCancel,AbortRetryIgnore, OK,YesNoCancel ...
                MessageBoxIcon.Warning,
                // Warning'!', Question,Information'i', Error'x', Exclamation'!'
                MessageBoxDefaultButton.Button2
                );

            //kapanmadan önce bir pencere daha açar.
            if (sonuc == DialogResult.No)
            {
                e.Cancel = true;
                MessageBox.Show("iptal edildi");
            }
            else
            {
                MessageBox.Show("kapanıyor.");
            }

        }
    }
}
