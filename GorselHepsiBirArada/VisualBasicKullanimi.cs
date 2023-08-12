using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;// bunu ekstra ekledik

namespace GorselHepsiBirArada
{
    public partial class VisualBasicKullanimi : Form
    {
        public VisualBasicKullanimi()
        {
            InitializeComponent();
        }

        private void VisualBasicKullanimi_Load(object sender, EventArgs e)
        {
            //yukarıya ekleme yapmalıyız.
            //using Microsoft.VisualBasic;

            //InputBox("Çıkacak Mesaj Bilgisi","Başlık","Varsayılan değer",Ekran Yatay
            //Uzaklığı, Ekrana Dikey Uzaklığı);
            Interaction.MsgBox("açılışta çıkarım");
            string ad;
            ad = Interaction.InputBox("Adınız", "Gir", "Murtaza", 50, 50);
            Interaction.MsgBox(ad);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ilkSayi = Convert.ToInt32(Interaction.InputBox("ilk sayi:"));
            int ikinciSayi = Convert.ToInt32(Interaction.InputBox("ikinci sayi:"));
            if (ilkSayi > ikinciSayi)
            {
                Interaction.MsgBox("buyuk olan: " + ilkSayi);
            }
            else Interaction.MsgBox("buyuk olan: " + ikinciSayi);
           
        }
    }
}
