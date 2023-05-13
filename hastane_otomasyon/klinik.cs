using MySql.Data.MySqlClient;
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
    public partial class klinik : Form
    {
        public klinik()
        {
            InitializeComponent();
        }
        string constr = "server=localhost; user=root; password=*j3483zG; port=3306; database=hastane_database";
        MySqlConnection con;
        MySqlCommand cmd;
        DataTable dt;
        DataView dv;
        private void button_geri_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            Hide();
            anasayfa.ShowDialog();
        }

        private void klinik_Load(object sender, EventArgs e)
        {

            dataGridView_klinikler_doldur();
        }
        public void dataGridView_klinikler_doldur()

        {
            con = new MySqlConnection(constr);
            con.Open();
            cmd = new MySqlCommand(" select klinik_ad,COUNT(*) as 'doktor sayısı' from poliklinik inner join randevu on poliklinik.id=randevu.klinik_id inner join doktor on randevu.doktor_id=doktor.id group by poliklinik.id", con);
            dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView_klinikler.DataSource = dt;
            con.Close();
        }
        public void isme_gore_filtrele()
        {
            dv = new DataView(dt);
            string sart = "klinik_ad like '%" + textBox_klinik_ad.Text + "%'";
            dv.RowFilter = sart;
            dataGridView_klinikler.DataSource = dv;
        }

        private void button_getir_Click(object sender, EventArgs e)
        {
            isme_gore_filtrele();
        }
    }
}
