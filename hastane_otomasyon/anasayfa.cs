using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace hastane_otomasyon
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }
        public static string a_yetki;

        private void anasayfa_Load(object sender, EventArgs e)
        {
            if (a_yetki == "personel")
            {
                button_hasta.Enabled = false;
                button_doktor.Enabled = false;
            }
        }

        private void button_recete_Click(object sender, EventArgs e)
        {
            receteler receteler= new receteler();
            receteler.ShowDialog();
        }

        private void button_geri_Click(object sender, EventArgs e)
        {
            Form1 form1_sayfası_donus = new Form1();
            Hide();
            form1_sayfası_donus.ShowDialog();
            
        }

        private void button_hasta_Click(object sender, EventArgs e)
        {
            hastalar hastalar = new hastalar();
            Hide();
            hastalar.ShowDialog();
        }
    }
}
