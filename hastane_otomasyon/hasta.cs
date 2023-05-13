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
    public partial class hasta : Form
    {
        public hasta()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("user=root; server=localhost; port=3306; database=hastane_database; password=*j3483zG");
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataSet ds;
        MySqlDataReader dr;
        private void button_geri_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            Hide();
            anasayfa.ShowDialog();
        }

        private void hasta_Load(object sender, EventArgs e)
        {
            dataGridView_hastalar_doldur();
            comboBox_kan_grubu_listele();
        }
        public void dataGridView_hastalar_doldur()
        {

            da = new MySqlDataAdapter("select * from hasta", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "hasta");
            dataGridView_hastalar.DataSource = ds.Tables["hasta"];
            con.Close();
        }
        public void comboBox_kan_grubu_listele()
        {

            con.Open();
            cmd = new MySqlCommand("select * from kan_grubu", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox_kan_grubu.Items.Add(dr["kan_grubu"]);
            }

            con.Close();
        }

        private void button_ekle_Click(object sender, EventArgs e)
        {

            con.Open();

            try
            {
                cmd.Connection = con;
                cmd.CommandText = "call hasta_ekle__(" + textBox_id.Text + ",'" + textBox_ad.Text + "','" + textBox_soyad.Text + "', '" + textBox_cinsiyet.Text + "' ,'" + textBox_tel_no.Text + "', '" + textBox_tc_no.Text + "' ,'" + comboBox_kan_grubu.Text + "','" + textBox_parola.Text + "'," + textBox_yetki_id.Text + ")";
                cmd.ExecuteNonQuery();
                MessageBox.Show("kayıt işlemi başarılı bir şekilde gerçekleştirilmiştir.");
            }
            catch
            {
                MessageBox.Show("eksik giriş yaptınız lütfen tekrar deneyiniz.");
            }
            con.Close();
            dataGridView_hastalar_doldur();
        }

    }
}
