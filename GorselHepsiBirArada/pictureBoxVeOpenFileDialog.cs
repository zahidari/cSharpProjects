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
    public partial class pictureBoxVeOpenFileDialog : Form
    {
        public pictureBoxVeOpenFileDialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title  = "Dosya seçiniz:";// başlık
            openFileDialog1.Filter = "(*.png)|*.png|(*.jpeg)|*.jpeg|(*.bmp)|*.bmp";
            openFileDialog1.FilterIndex = 0; // yani jpeg bakacak
            openFileDialog1.InitialDirectory = "C:\\Users\\zagu\\Desktop"; //her seferinde burdan başlar
            

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;// doldurur
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                
                label1.Text = openFileDialog1.FileName;
            }
            
        }
    }
}
