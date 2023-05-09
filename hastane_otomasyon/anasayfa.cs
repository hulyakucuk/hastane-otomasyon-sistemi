using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hastane_otomasyon
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }
        public static string a_yetki;
        private void button_doktor_Click(object sender, EventArgs e)
        {
            doktor doktor = new doktor();
            Hide();
            doktor.ShowDialog();
        }

        private void anasayfa_Load(object sender, EventArgs e)
        {
            if (a_yetki == "1")
            {
                button_doktor.Enabled = false;
                button_hasta_sil.Enabled = false;
            }
        }

        private void button_hasta_ekle_Click(object sender, EventArgs e)
        {
              hasta hasta_ekle=new hasta();
              Hide();
              hasta_ekle.ShowDialog();
        }

        private void button_randevular_Click(object sender, EventArgs e)
        {
            randevu randevu = new randevu();
            Hide();
            randevu.ShowDialog();
        }

        private void button_recete_Click(object sender, EventArgs e)
        {
            receteler receteler = new receteler();
            Hide();
            receteler.ShowDialog();
        }

        private void button_klinikler_Click(object sender, EventArgs e)
        {
            klinik klinik = new klinik();
            Hide(); 
            klinik.ShowDialog();
        }

        private void button_hasta_sil_Click(object sender, EventArgs e)
        {
            Hasta_Sil Hasta_Sil = new Hasta_Sil();
            Hide();
            Hasta_Sil.ShowDialog();
            
        }
    }
}
