using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace GorselHepsiBirArada
{
    public partial class BesAdetNotGirInputBox : Form
    {
        public BesAdetNotGirInputBox()
        {
            InitializeComponent();
        }

        private void BesAdetNotGir_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // using Microsoft.VisualBasic; import etmeliyiz.
            int[] arr = new int[5];
            for(int i = 0;i <5; i++)
            {

                try
                {
                    arr[i] = Convert.ToInt32(Interaction.InputBox("{0}. Notu giriniz:", "{0}. Sayi girişi"));
                }
                catch
                {
                    // cancel basınca işlem iptal etmeli.
                    MessageBox.Show("0-100 arası tamsayı giriniz.");
                    i--;
                }
            }
            
            
            

        }
    }
}
