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
    public partial class Hasta_Sil : Form
    {
        public Hasta_Sil()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("user=root; server=localhost; port=3306; database=hastane_database; password=*j3483zG");
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataSet ds;
        private void button_geri_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            Hide();
            anasayfa.ShowDialog();
        }
        public void dataGridView_hastalar_doldur()
        {

            da = new MySqlDataAdapter("select * from hasta", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "hasta");
            dataGridView_hastalar.DataSource = ds.Tables["hasta"]; //
            con.Close();
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

        private void Hasta_Sil_Load(object sender, EventArgs e)
        {
            dataGridView_hastalar_doldur();
        }
    }
}
