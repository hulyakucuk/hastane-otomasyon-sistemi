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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hastane_otomasyon
{
    public partial class receteler : Form
    {
        public receteler()
        {
            InitializeComponent();
        }

        string constr = "server=localhost; user=root; password=*j3483zG; port=3306; database=hastane_database";
        MySqlConnection con;
        MySqlCommand cmd;
        DataTable dt;
        DataView dv;
        private void receteler_Load(object sender, EventArgs e)
        {
            dataGriddataGridView_recete_doldur();

        }
        public void dataGriddataGridView_recete_doldur()

        {
            con = new MySqlConnection(constr);
            con.Open();
            cmd = new MySqlCommand("select hasta_ad,hasta_soyad,sikayet,teshis,ilac_ad,kullanim_sekli from tedavi inner join hasta on hasta.id=tedavi.hasta_id inner join recete on tedavi.id=recete.tedavi_id inner join ilaclar on ilaclar.id=recete.ilac_id", con);
            dt=new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView_recete.DataSource = dt;
            con.Close();
        }

        private void button_hasta_ad_getir_Click(object sender, EventArgs e)
        {
            isme_gore_filtrele();
        }
        public void isme_gore_filtrele()
        {
            dv = new DataView(dt);
            string sart = "hasta_ad like '%" + textBox_hasta_adi.Text + "%'";
            dv.RowFilter = sart;
            dataGridView_recete.DataSource = dv;
        }
    }
}
