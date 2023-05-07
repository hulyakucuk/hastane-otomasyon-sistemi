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
    public partial class hastalar : Form
    {
        public hastalar()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("user=root; server=localhost; port=3306; database=hastane_database; password=*j3483zG");
        MySqlCommand cmd;
        MySqlDataReader dr;
        MySqlDataAdapter da;
        DataSet ds;


        private void hastalar_Load(object sender, EventArgs e)
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
            dataGridView_hastalar.DataSource = ds.Tables["hasta"]; //
            //datagridin kaynagı
            con.Close();
        }
        public void comboBox_kan_grubu_listele()
        {

            con.Open();
            cmd = new MySqlCommand("select * from kan_grubu", con);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            comboBox_kan_grubu.DisplayMember = "kan_grubu";
            comboBox_kan_grubu.ValueMember = "id";
            comboBox_kan_grubu.DataSource = dt;

            con.Close();
        }

        private void button_ekle_Click(object sender, EventArgs e)
        {
            con.Open();

            try
            {
                cmd.Connection = con;
                cmd.CommandText = "call hasta_a_ekle(" + textBox_id.Text + ",'" + textBox_ad.Text + "','" + textBox_soyad.Text + "', '" + textBox_cinsiyet.Text + "' , '" + textBox_tc_no.Text + "' , '" +textBox_tel_no.Text + "' ,'" +comboBox_kan_grubu.Text + "')";
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

        private void button_sil_Click(object sender, EventArgs e)
        {

            cmd = new MySqlCommand();
            con.Open();
            try
            {
                DialogResult result = MessageBox.Show("seçilen hastayı silmek istediğinize emin misiniz?", "silme onayı", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    cmd.Connection = con;
                    cmd.CommandText = "delete from hasta where id=" + textBox_id.Text;
                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("hatalı işlem yaptınız silme işlemi gerçekleştirilemedi.." + ex);
            }
            con.Close();
            dataGridView_hastalar_doldur();
        }

        private void button_guncelle_Click(object sender, EventArgs e)
        {
            cmd = new MySqlCommand();
            con.Open();
            try
            {

                DialogResult result = MessageBox.Show("seçilen hastayı güncellemek istediğinize emin misiniz?", "güncelleme onayı", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    cmd.Connection = con;
                    cmd.CommandText = "update hasta set hasta_ad='" + textBox_ad.Text + "' , hasta_soyad='" + textBox_soyad.Text + "' ,kan_grubu='" + comboBox_kan_grubu.Text + "' ,cinsiyet='" + textBox_cinsiyet.Text + "' ,tc_no='" + textBox_tc_no.Text + "' ,tel_no='" + textBox_tel_no.Text + "'  where id=" + textBox_id.Text;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("hatalı işlem yaptınız güncelleme işlemi gerçekleştirilemedi..");
            }
            con.Close();
            dataGridView_hastalar_doldur();
        }
    }
}
