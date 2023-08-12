namespace GorselHepsiBirArada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ilk pop up
            object tarih;// DateTime tarih; þeklinde de tanýmlanabilir.
            tarih = DateTime.Now;
            MessageBox.Show("hello welcome, þu an tarih ve saat: "+tarih);
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            //burada bir nesne oluþturduk. ve buttona basýnca o form penceresi açýlacak.
            arkaPlanDegistir arkaPlanDegistir = new arkaPlanDegistir();
            arkaPlanDegistir.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BuyukKucukBulma bulNesne = new BuyukKucukBulma();
            bulNesne.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListBoxileArkaPlanDegistirme li = new ListBoxileArkaPlanDegistirme();
            li.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessgeBoxOlusturma msg = new MessgeBoxOlusturma();
            msg.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            VisualBasicKullanimi vs = new VisualBasicKullanimi();
            vs.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ComboBoxEkleme cm = new ComboBoxEkleme();
            cm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ThreadKullanimi th = new ThreadKullanimi();
            th.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AsalSayiBulma asal1 = new AsalSayiBulma();
            asal1.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MatematikselFonksiyonlar mat1 =  new MatematikselFonksiyonlar();
            mat1.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            TimerOlusturma tim1 = new TimerOlusturma();
            tim1.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AlarmUygulamasiFormu alm1 = new AlarmUygulamasiFormu();
            alm1.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DateTimePickerForm dtpf = new DateTimePickerForm();
            dtpf.Show();  
        }

        private void button13_Click(object sender, EventArgs e)
        {
            IkiTarihArasýndakiFark trh1 = new IkiTarihArasýndakiFark();
            trh1.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ProgressBarKullanimi prg = new ProgressBarKullanimi();
            prg.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ToolStripKullanimi tsk = new ToolStripKullanimi();
            tsk.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            DizilerForm df = new DizilerForm();
            df.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            RadioButtonKullanimi rdbt = new RadioButtonKullanimi();
            rdbt.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            BesAdetNotGirInputBox bsadntgr = new BesAdetNotGirInputBox();
            bsadntgr.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            ScrolBarIleRenkDegisimi scrBrRnk = new ScrolBarIleRenkDegisimi();
            scrBrRnk.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            TrackBarKullanimi trkBarKul = new TrackBarKullanimi();
            trkBarKul.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            pictureBoxVeOpenFileDialog podk=new pictureBoxVeOpenFileDialog();
            podk.Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            VeritabaniUygulamasi veritabaiU = new VeritabaniUygulamasi();
            veritabaiU.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            ListBoxOgrenciVeriIsle liovi = new ListBoxOgrenciVeriIsle();
            liovi.Show();
        }
    }
}