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
    public partial class ListBoxileArkaPlanDegistirme : Form
    {
        public ListBoxileArkaPlanDegistirme()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.Text)
            {
                case "mavi":this.BackColor = Color.Blue; break;
                case "kırmızı":this.BackColor= Color.Red; break;
                default:this.BackColor = Color.White; break;
            }
        }
    }
}
