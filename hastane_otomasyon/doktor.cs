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
    public partial class doktor : Form
    {
        public doktor()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("user=root; server=localhost; port=3306; database=hastane_database; password=*j3483zG");
        MySqlDataAdapter da;
        DataSet ds;
        MySqlCommand cmd;

        private void button_geri_Click(object sender, EventArgs e)
        {

            anasayfa anasayfa = new anasayfa();
            Hide();
            anasayfa.ShowDialog();
        }
        public void dataGridView_doktorlar_doldur()
        {

            da = new MySqlDataAdapter(" select * from doktor", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "doktor");
            dataGridView_doktor.DataSource = ds.Tables["doktor"];
            con.Close();
        }
        private void button_ekle_Click(object sender, EventArgs e)
        {
            con.Open();

            try
            {
                cmd = new MySqlCommand("insert into doktor (id,doktor_ad,doktor_soyad,sifre,yetki_id) value(" + textBox_id.Text + ",'" + textBox_ad.Text + "','" + textBox_soyad.Text + "','" + textBox_parola.Text + "'," + textBox_yetki_id.Text + ")", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("kayıt işlemi başarılı bir şekilde gerçekleştirilmiştir.");
            }
            catch
            {
                MessageBox.Show("eksik giriş yaptınız lütfen tekrar deneyiniz.");
            }
            con.Close();
            dataGridView_doktorlar_doldur();
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
                    cmd.CommandText = "delete from doktor where id=" + textBox_id.Text;
                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("hatalı işlem yaptınız silme işlemi gerçekleştirilemedi.." + ex);
            }
            con.Close();
            dataGridView_doktorlar_doldur();
        }

        private void doktor_Load(object sender, EventArgs e)
        {
            dataGridView_doktorlar_doldur();
        }
    }
}
