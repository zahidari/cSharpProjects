using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media; // bunu eklemeyi unutma

namespace GorselHepsiBirArada
{
    public partial class AlarmUygulamasiFormu : Form
    {
        public AlarmUygulamasiFormu()
        {
            InitializeComponent();
        }

        private void AlarmUygulamasiFormu_Load(object sender, EventArgs e)
        {
            //yukarıda using System.Media; ekledik.
            timer1.Enabled = true; // saati sürekli güncel görebilmek için yazdık.

        }

        private void Tarih_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //ilk labellere Tarih ve saatleri sürekli göstermesini sağladık.
            Tarih.Text = DateTime.Now.ToShortDateString();
            Saat.Text = DateTime.Now.ToLongTimeString();
        }
        SoundPlayer player1 = new SoundPlayer();// alarmı durdur  düğmesi için

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(numericUpDown1.Value == DateTime.Now.Hour && numericUpDown2.Value == DateTime.Now.Minute&& numericUpDown3.Value == DateTime.Now.Second)
            {
                timer2.Enabled = false;//alarm devreye girdiği için timeri kapat.
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = "C:/alarm.wav";
                player.Play();// bir kere çaldırır. ses dosyası bir kere açılır,bitince durur.
                //player.PlayLooping(); sürekli çaldırır.
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true; // sayacımızı çalıştırdık.
            timer2.Start();        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Enabled=false;
            player1.Stop();// ses doysasını kapdık. yani çalarken kapadık.
        }
    }
}
