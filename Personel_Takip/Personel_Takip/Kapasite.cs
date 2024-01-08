using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_Takip
{
    public partial class Kapasite : Form
    {
        public static int yonetimKapasite { get; set; } = 2;
        public static int muhasebeKapasite { get; set; } = 1;

        public static int sekreterKapasite { get; set; } = 2;
        public static int pazarlamaKapasite { get; set; } = 4;
        public static int uretimKapasite { get; set; } = 6;
        public static int lojistikKapasite { get; set; } = 5;

        public Kapasite()
        {
            InitializeComponent();

        }
     
       public static int Mevcut()
        {
            return yonetimKapasite+muhasebeKapasite+sekreterKapasite+pazarlamaKapasite+uretimKapasite+lojistikKapasite;
        }

        public void LabelKapasiteGuncelle(Label label)
        {
            int toplamKapasite = yonetimKapasite + muhasebeKapasite +
                              sekreterKapasite + pazarlamaKapasite +
                              uretimKapasite + lojistikKapasite;
            double yonetimYuzde = (double)yonetimKapasite / toplamKapasite * 100;
            double muhasebeYuzde = (double)muhasebeKapasite / toplamKapasite * 100;
            double sekreterYuzde = (double)sekreterKapasite / toplamKapasite * 100;
            double pazarlamaYuzde = (double)pazarlamaKapasite / toplamKapasite * 100;
            double uretimYuzde = (double)uretimKapasite / toplamKapasite * 100;
            double lojistikYuzde = (double)lojistikKapasite / toplamKapasite * 100;

             
            label.Text = $"Toplam Kapasite: {toplamKapasite}\n\n" +
                         $"Yönetim Kapasite: {yonetimKapasite} ({yonetimYuzde:N2}%)\n" +
                         $"Muhasebe Kapasite: {muhasebeKapasite} ({muhasebeYuzde:N2}%)\n" +
                         $"Sekreter Kapasite: {sekreterKapasite} ({sekreterYuzde:N2}%)\n" +
                         $"Pazarlama Kapasite: {pazarlamaKapasite} ({pazarlamaYuzde:N2}%)\n" +
                         $"Üretim Kapasite: {uretimKapasite} ({uretimYuzde:N2}%)\n" +
                         $"Lojistik Kapasite: {lojistikKapasite} ({lojistikYuzde:N2}%)";
        }

        private void Kapasite_Load(object sender, EventArgs e)
        {
           
            LabelKapasiteGuncelle(labelKapasite);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DepartmanIsleri f1 = new DepartmanIsleri();
            f1.Show();
            this.Hide();
        }
    }
}
